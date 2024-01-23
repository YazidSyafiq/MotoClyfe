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
    public partial class PengembalianSewa : Form
    {
        DataMotoClyfeDataContext db = new DataMotoClyfeDataContext();
        public PengembalianSewa()
        {
            InitializeComponent();
            LoadDataSewa();

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

        private void LoadDataSewa()
        {
            var dataSewa = from sewa in db.data_sewas
                           join user in db.data_users on sewa.id_user equals user.id_user
                           join motor in db.data_motors on sewa.id_motor equals motor.id_motor
                           where user.username == Login.LoggeInUsername && sewa.status_sewa == "Disewakan"
                           select new
                           {
                               Username = user.username,
                               Plat = motor.plat_nomor,
                               Tanggal_Sewa = sewa.tanggal_sewa,
                               Waktu_Sewa = sewa.waktu_sewa
                           };
            dataGridViewSewa.DataSource = dataSewa.ToList();
        }

        private void dataGridViewSewa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridViewSewa.Rows[e.RowIndex];
                string selectedUsername = selectedRow.Cells["Username"].Value.ToString();
                string selectedPlat = selectedRow.Cells["Plat"].Value.ToString();
                string selectedTanggal = selectedRow.Cells["Tanggal_Sewa"].Value.ToString();
                string selectedWaktu = selectedRow.Cells["Waktu_Sewa"].Value.ToString();

                var dataSewa = db.data_sewas
                               .Where(sewa => sewa.data_motor.plat_nomor == selectedPlat && sewa.status_sewa == "Disewakan")
                               .FirstOrDefault();

                if (dataSewa != null)
                {
                    tbUsername.Text = dataSewa.data_user.username;
                    tbNamaMotor.Text = dataSewa.data_motor.nama_motor;
                    tbJenisMotor.Text = dataSewa.data_motor.jenis_motor;
                    tbPabrikan.Text = dataSewa.data_motor.pabrikan_motor;
                    tbCC.Text = dataSewa.data_motor.ukuran_mesin.ToString();
                    tbTahunMotor.Text = dataSewa.data_motor.tahun_pembuatan.ToString();
                    tbPlat.Text = dataSewa.data_motor.plat_nomor;
                }
            }
        }

        private void btnPengembalian_Click(object sender, EventArgs e)
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
                var dataSewa = db.data_sewas
                               .Where(sewa => sewa.data_motor.plat_nomor == plat && sewa.status_sewa == "Disewakan")
                               .FirstOrDefault();

                if (dataSewa != null)
                {
                    var dataPengembalian = new data_pengembalian
                    {
                        id_sewa = dataSewa.id_sewa,
                        date_pengembalian = DateTime.Now.Date,
                        time_pengembalian = DateTime.Now.TimeOfDay,
                        status_pengembalian = "Menunggu Konfirmasi"
                    };
                    db.data_pengembalians.InsertOnSubmit(dataPengembalian);
                    dataSewa.status_sewa = "Menunggu Konfirmasi Pengembalian";
                    db.SubmitChanges();

                    MessageBox.Show("Pengajuan Pengembalian Anda Berhasil, Selanjutnya Silahkan Menuju Kasir Untuk Melakukan Konformasi Termasuk Menyerahkan Kunci Motor dan STNK", "Success", MessageBoxButtons.OK);

                    ClearInput();
                    LoadDataSewa();
                }
                else
                {
                    MessageBox.Show("Data motor tidak ditemukan atau motor tidak sedang disewakan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
