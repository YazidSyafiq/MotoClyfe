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
    public partial class MenuUtamaAdmin : Form
    {
        public MenuUtamaAdmin()
        {
            InitializeComponent();
            labelUsername.Text = Login.LoggeInUsername;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Apakah Anda Yakin Ingin Logout dari Akun Ini?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();
                this.Hide();
            }
            else
            {
                this.Show();
            }
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

        private void btnPersediaanMotor_Click(object sender, EventArgs e)
        {
            PersediaanMotorAdmin persediaanMotorForAdmin = new PersediaanMotorAdmin();
            persediaanMotorForAdmin.Show();
            this.Hide();
        }

        private void btnKonfirmasiSewa_Click(object sender, EventArgs e)
        {
            KonfirmasiSewa sewa = new KonfirmasiSewa();
            sewa.Show();
            this.Hide();
        }

        private void btnKonfirmasiPengembalian_Click(object sender, EventArgs e)
        {
            KonfirmasiPengembalian pengembalian = new KonfirmasiPengembalian();
            pengembalian.Show();
            this.Hide();
        }

        private void btnDaftarUser_Click(object sender, EventArgs e)
        {
            DaftarUser daftarUser = new DaftarUser();
            daftarUser.Show();
            this.Hide();
        }

        private void btnRiwayatSewa_Click(object sender, EventArgs e)
        {
            RiwayatSewaAdmin riwayatSewa = new RiwayatSewaAdmin();
            riwayatSewa.Show();
            this.Hide();
        }
    }
}
