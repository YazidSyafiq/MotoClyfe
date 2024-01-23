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
    public partial class KonfirmasiSewa : Form
    {
        DataMotoClyfeDataContext db = new DataMotoClyfeDataContext();
        public KonfirmasiSewa()
        {
            InitializeComponent();
            LoadDataKonfirmasiSewa();

            tbIdSewa.ReadOnly = true;
            tbUsername.ReadOnly = true;
            tbNamaMotor.ReadOnly = true;
            tbJenisMotor.ReadOnly = true;
            tbPabrikan.ReadOnly = true;
            tbCC.ReadOnly = true;
            tbTahunMotor.ReadOnly = true;
            tbPlat.ReadOnly = true;
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
            MenuUtamaAdmin menu = new MenuUtamaAdmin();
            menu.Show();
            this.Hide();
        }

        private void LoadDataKonfirmasiSewa()
        {
            var dataSewa = from sewa in db.data_sewas
                           join user in db.data_users on sewa.id_user equals user.id_user
                           join motor in db.data_motors on sewa.id_motor equals motor.id_motor
                           where sewa.status_sewa == "Menunggu Konfirmasi"
                           select new
                           {
                               ID_Sewa = sewa.id_sewa,
                               Username = user.username,
                               Plat = motor.plat_nomor,
                               Tanggal_Sewa = sewa.tanggal_sewa,
                               Waktu_Sewa = sewa.waktu_sewa
                           };
            dataGridViewKonfirmasiSewa.DataSource = dataSewa.ToList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string username = tbSearchUser.Text;

            var dataSewa = from sewa in db.data_sewas
                           join user in db.data_users on sewa.id_user equals user.id_user
                           join motor in db.data_motors on sewa.id_motor equals motor.id_motor
                           where user.username == username && sewa.status_sewa == "Menunggu Konfirmasi"
                           select new
                           {
                               ID_Sewa = sewa.id_sewa,
                               Username = user.username,
                               Plat = motor.plat_nomor,
                               Tanggal_Sewa = sewa.tanggal_sewa,
                               Waktu_Sewa = sewa.waktu_sewa
                           };
            dataGridViewKonfirmasiSewa.DataSource = dataSewa.ToList();
        }

        private void dataGridViewKonfirmasiSewa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridViewKonfirmasiSewa.Rows[e.RowIndex];
                string selectedID = selectedRow.Cells["ID_Sewa"].Value.ToString();
                string selectedUsername = selectedRow.Cells["Username"].Value.ToString();
                string selectedPlat = selectedRow.Cells["Plat"].Value.ToString();
                string selectedTanggal = selectedRow.Cells["Tanggal_Sewa"].Value.ToString();
                string selectedWaktu = selectedRow.Cells["Waktu_Sewa"].Value.ToString();

                // Tampilkan data yang dipilih di TextBox
                var dataSewa = db.data_sewas.Where(sewa => sewa.id_sewa == int.Parse(selectedID)).FirstOrDefault();

                if (dataSewa != null)
                {
                    tbIdSewa.Text = dataSewa.id_sewa.ToString();
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

        private void btnKonfirmasiSewa_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string namaMotor = tbNamaMotor.Text;
            string jenisMotor = tbJenisMotor.Text;
            string pabrikanMotor = tbPabrikan.Text;
            int cc, tahun;
            string plat = tbPlat.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(namaMotor) || string.IsNullOrEmpty(jenisMotor) || string.IsNullOrEmpty(pabrikanMotor) || !int.TryParse(tbCC.Text, out cc) || !int.TryParse(tbTahunMotor.Text, out tahun) || string.IsNullOrEmpty(plat))
            {
                MessageBox.Show("Untuk Konfirmasi Sewa, Pastikan Data Sudah Sudah Terisi Dengan Benar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                    var selectedSewa = db.data_sewas.FirstOrDefault(sewa => sewa.id_sewa == int.Parse(tbIdSewa.Text));
                    if (selectedSewa != null) 
                    {
                        selectedSewa.status_sewa = "Disewakan";

                        db.SubmitChanges();

                        MessageBox.Show("Konfirmasi Sewa Berhasil, Pastikan DP dan Jaminan Sudah Diberikan", "Success", MessageBoxButtons.OK);
                        ClearInput();
                        LoadDataKonfirmasiSewa();
                    }
                    else
                    {
                        MessageBox.Show("Data Motor Tidak Ditemukan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
        }
        private void ClearInput()
        {
            tbIdSewa.Clear();
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
