using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_Besar
{
    public partial class SewaMotor : Form
    {
        DataMotoClyfeDataContext db = new DataMotoClyfeDataContext();
        public SewaMotor()
        {
            InitializeComponent();
            LoadDataPersediaanMotor();


            tbUsername.ReadOnly = true;
            tbNamaMotor.ReadOnly = true;
            tbJenisMotor.ReadOnly = true;
            tbPabrikan.ReadOnly = true;
            tbCC.ReadOnly = true;
            tbTahunMotor.ReadOnly = true;
            tbPlat.ReadOnly = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MenuUtamaUser menuUtama = new MenuUtamaUser();
            menuUtama.Show();
            this.Hide();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Apakah Anda Yakin Ingin Keluar?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        private void LoadDataPersediaanMotor()
        {
            var dataMotor = from motor in db.data_motors
                            where motor.status_motor == "Tersedia"
                            select new
                            {
                                Nama = motor.nama_motor,
                                Jenis = motor.jenis_motor,
                                Pabrikan = motor.pabrikan_motor,
                                CC = motor.ukuran_mesin,
                                Tahun = motor.tahun_pembuatan,
                                Plat = motor.plat_nomor,
                            };
            dataGridViewSewa.DataSource = dataMotor.ToList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string pabrikan = cbPabrikanMotor.SelectedItem?.ToString();

            var dataMotor = from motor in db.data_motors
                            where motor.pabrikan_motor == pabrikan && motor.status_motor == "Tersedia"
                            select new
                            {
                                Nama = motor.nama_motor,
                                Jenis = motor.jenis_motor,
                                Pabrikan = motor.pabrikan_motor,
                                CC = motor.ukuran_mesin,
                                Tahun = motor.tahun_pembuatan,
                                Plat = motor.plat_nomor,
                            };
            dataGridViewSewa.DataSource = dataMotor.ToList();
        }

        private void dataGridViewSewa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridViewSewa.Rows[e.RowIndex];
                string selectedNama = selectedRow.Cells["Nama"].Value.ToString();
                string selectedJenis = selectedRow.Cells["Jenis"].Value.ToString();
                string selectedPabrikan = selectedRow.Cells["Pabrikan"].Value.ToString();
                int selectedCC = Convert.ToInt32(selectedRow.Cells["CC"].Value);
                int selectedTahun = Convert.ToInt32(selectedRow.Cells["Tahun"].Value);
                string selectedPlat = selectedRow.Cells["Plat"].Value.ToString();

                // Tampilkan data yang dipilih di TextBox
                tbUsername.Text = Login.LoggeInUsername;
                tbNamaMotor.Text = selectedNama;
                tbJenisMotor.Text = selectedJenis;
                tbPabrikan.Text = selectedPabrikan;
                tbCC.Text = selectedCC.ToString();
                tbTahunMotor.Text = selectedTahun.ToString();
                tbPlat.Text = selectedPlat;
            }
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string namaMotor = tbNamaMotor.Text;
            string jenisMotor = tbJenisMotor.Text;
            string pabrikanMotor = tbPabrikan.Text;
            int cc, tahun;
            string plat = tbPlat.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(namaMotor) || string.IsNullOrEmpty(jenisMotor) || string.IsNullOrEmpty(pabrikanMotor) || !int.TryParse(tbCC.Text, out cc) || !int.TryParse(tbTahunMotor.Text, out tahun) || string.IsNullOrEmpty(plat))
            {
                MessageBox.Show("Untuk Mengajukan Sewa, Pastikan Data Sudah Sudah Terisi Dengan Benar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var userId = (from user in db.data_users where user.username == username select user.id_user).FirstOrDefault();
                var motorId = (from motor in db.data_motors where motor.plat_nomor == plat select motor.id_motor).FirstOrDefault();

                if (userId != 0 && motorId != 0)
                {
                    var selectedMotor = db.data_motors.Single(motor => motor.id_motor == motorId && motor.status_motor == "Tersedia");

                    if (selectedMotor != null)
                    {
                        var sewaMotor = new data_sewa
                        {
                            id_user = userId,
                            id_motor = selectedMotor.id_motor,
                            tanggal_sewa = DateTime.Now.Date,
                            waktu_sewa = DateTime.Now.TimeOfDay,
                            status_sewa = "Menunggu Konfirmasi"
                        };

                        db.data_sewas.InsertOnSubmit(sewaMotor);
                        selectedMotor.status_motor = "Tidak Tersedia";
                        db.SubmitChanges();

                        MessageBox.Show("Pengajuan Sewa Anda Berhasil, Selanjutnya Silahkan Menuju Kasir Untuk Melakukan Konformasi Termasuk Membayar DP dan Menyerahkan Jaminan", "Success", MessageBoxButtons.OK);

                        ClearInput();
                        LoadDataPersediaanMotor();
                    }
                    else
                    {
                        MessageBox.Show("Motor tidak tersedia untuk disewa.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("User atau motor tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void ClearInput()
        {
            tbUsername.Clear();
            tbNamaMotor.Clear();
            tbJenisMotor.Clear();
            tbPabrikan.Clear();
            tbCC.Clear();
            tbTahunMotor.Clear();
            tbPlat.Clear();
        }
    }
}
