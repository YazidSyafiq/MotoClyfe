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
    public partial class PersediaanMotorAdmin : Form
    {
        DataMotoClyfeDataContext db = new DataMotoClyfeDataContext();
        public PersediaanMotorAdmin()
        {
            InitializeComponent();
            LoadDataPersediaanMotor();

            tbCC.KeyPress += TextBoxNumericOnly;
            tbTahunMotor.KeyPress += TextBoxNumericOnly;
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            MenuUtamaAdmin menuUtama = new MenuUtamaAdmin();
            menuUtama.Show();
            this.Hide();
        }

        private void TextBoxNumericOnly(object sender, KeyPressEventArgs e)
        {
            // Memeriksa apakah karakter yang dimasukkan adalah digit atau kontrol karakter
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Mencegah karakter yang tidak valid
                e.Handled = true;
            }
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            string namaMotor = tbNamaMotor.Text;
            string jenisMotor = cbJenisMotor.SelectedItem?.ToString();
            string pabrikanMotor = cbPabrikan.SelectedItem?.ToString();
            int cc, tahun;
            string plat = tbPlat.Text;
            string statusMotor = cbStatusMotor.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(namaMotor) || string.IsNullOrEmpty(jenisMotor) || string.IsNullOrEmpty(pabrikanMotor) || !int.TryParse(tbCC.Text, out cc) || !int.TryParse(tbTahunMotor.Text, out tahun) || string.IsNullOrEmpty(plat) || string.IsNullOrEmpty(statusMotor))
            {
                MessageBox.Show("Semua Data Harus Terisi Semua!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            else
            {
                if (db.data_motors.Any(motor => motor.plat_nomor == plat))
                {
                    MessageBox.Show("Data Motor Tersebut Sudah Ada, Silahkan Memasukkan Data Baru!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var newMotor = new data_motor
                    {
                        nama_motor = namaMotor,
                        jenis_motor = jenisMotor,
                        pabrikan_motor = pabrikanMotor,
                        ukuran_mesin = cc,
                        tahun_pembuatan = tahun,
                        plat_nomor = plat,
                        status_motor = statusMotor,
                    };

                    db.data_motors.InsertOnSubmit(newMotor);
                    db.SubmitChanges();
                    MessageBox.Show("Data Berhasil Ditambahkan", "Success", MessageBoxButtons.OK);

                    LoadDataPersediaanMotor();
                    ClearInput();
                }
            }
        }

        private void LoadDataPersediaanMotor()
        {
            var dataMotor = from motor in db.data_motors
                            select new
                            {
                                ID = motor.id_motor,
                                Nama = motor.nama_motor,
                                Jenis = motor.jenis_motor,
                                Pabrikan = motor.pabrikan_motor,
                                CC = motor.ukuran_mesin,
                                Tahun = motor.tahun_pembuatan,
                                Plat = motor.plat_nomor,
                                Status = motor.status_motor,
                            };
            dataGridViewPersediaanMotor.DataSource = dataMotor.ToList();
        }

        private void ClearInput()
        {
            tbNamaMotor.Clear();
            cbJenisMotor.SelectedIndex = -1;
            cbPabrikan.SelectedIndex = -1;
            tbCC.Clear();
            tbTahunMotor.Clear();
            tbPlat.Clear();
            cbStatusMotor.SelectedIndex = -1;
        }

        private void dataGridViewPersediaanMotor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridViewPersediaanMotor.Rows[e.RowIndex];
                string selectedNama = selectedRow.Cells["Nama"].Value.ToString();
                string selectedJenis = selectedRow.Cells["Jenis"].Value.ToString();
                string selectedPabrikan = selectedRow.Cells["Pabrikan"].Value.ToString();
                int selectedCC = Convert.ToInt32(selectedRow.Cells["CC"].Value);
                int selectedTahun = Convert.ToInt32(selectedRow.Cells["Tahun"].Value);
                string selectedPlat = selectedRow.Cells["Plat"].Value.ToString();
                string selectedStatusMotor = selectedRow.Cells["Status"].Value.ToString();


                // Tampilkan data yang dipilih di TextBox
                tbNamaMotor.Text = selectedNama;
                cbJenisMotor.SelectedItem = selectedJenis;
                cbPabrikan.SelectedItem = selectedPabrikan;
                tbCC.Text = selectedCC.ToString();
                tbTahunMotor.Text = selectedTahun.ToString();
                tbPlat.Text = selectedPlat;
                cbStatusMotor.SelectedItem = selectedStatusMotor;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string namaMotor = tbNamaMotor.Text;
            string jenisMotor = cbJenisMotor.SelectedItem?.ToString();
            string pabrikanMotor = cbPabrikan.SelectedItem?.ToString();
            int cc, tahun;
            string plat = tbPlat.Text;
            string statusMotor = cbStatusMotor.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(namaMotor) || string.IsNullOrEmpty(jenisMotor) || string.IsNullOrEmpty(pabrikanMotor) || !int.TryParse(tbCC.Text, out cc) || !int.TryParse(tbTahunMotor.Text, out tahun) || string.IsNullOrEmpty(plat) || string.IsNullOrEmpty(statusMotor))
            {
                MessageBox.Show("Untuk Update, Pastikan Data Sudah Sudah Terisi Dengan Benar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (int.TryParse(dataGridViewPersediaanMotor.CurrentRow.Cells["ID"].Value.ToString(), out int selectedId))
                {
                    var selectedMotor = db.data_motors.FirstOrDefault(motor => motor.id_motor == selectedId);
                    if (selectedMotor != null)
                    {
                        selectedMotor.nama_motor = namaMotor;
                        selectedMotor.jenis_motor = jenisMotor;
                        selectedMotor.pabrikan_motor = pabrikanMotor;
                        selectedMotor.ukuran_mesin = cc;
                        selectedMotor.tahun_pembuatan = tahun;
                        selectedMotor.plat_nomor = plat;
                        selectedMotor.status_motor = statusMotor;

                        db.SubmitChanges();
                        MessageBox.Show("Data Berhasil Diperbarui", "Success", MessageBoxButtons.OK);
                        ClearInput();
                        LoadDataPersediaanMotor();
                    }
                    else
                    {
                        MessageBox.Show("Data Motor Tidak Ditemukan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Klik Pada Data Motor yang Akan Diupdate Terlebih Dahulu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string namaMotor = tbNamaMotor.Text;
            string jenisMotor = cbJenisMotor.SelectedItem?.ToString();
            string pabrikanMotor = cbPabrikan.SelectedItem?.ToString();
            int cc, tahun;
            string plat = tbPlat.Text;
            string statusMotor = cbStatusMotor.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(namaMotor) && !string.IsNullOrEmpty(jenisMotor) && !string.IsNullOrEmpty(pabrikanMotor) && int.TryParse(tbCC.Text, out cc) && int.TryParse(tbTahunMotor.Text, out tahun) && !string.IsNullOrEmpty(plat) && !string.IsNullOrEmpty(statusMotor))
            {
                DialogResult result;
                result = MessageBox.Show("Apakah Anda Yakin Akan Menghapus Data Ini?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                if (result == DialogResult.Yes)
                {
                    if (int.TryParse(dataGridViewPersediaanMotor.CurrentRow.Cells["ID"].Value.ToString(), out int selectedId))
                    {
                        var selectedMotor = db.data_motors.FirstOrDefault(motor => motor.id_motor == selectedId);

                        if (selectedMotor != null)
                        {
                            db.data_motors.DeleteOnSubmit(selectedMotor);
                            db.SubmitChanges();
                            MessageBox.Show("Data Berhasil Dihapus", "Success", MessageBoxButtons.OK);
                            LoadDataPersediaanMotor();
                            ClearInput();
                        }
                        else
                        {
                            MessageBox.Show("Data Motor Tidak Ditemukan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Klik Pada Data Motor yang Akan Dihapus Terlebih Dahulu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Untuk Menghapus Data, Pastikan Data Yang Dipilih Sudah Benar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
