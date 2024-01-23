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
    public partial class MenuUtamaUser : Form
    {
        public MenuUtamaUser()
        {
            InitializeComponent();
            labelUsername.Text = Login.LoggeInUsername;
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

        private void btnSewa_Click(object sender, EventArgs e)
        {
            SewaMotor sewaMotor = new SewaMotor();
            sewaMotor.Show();
            this.Hide();
        }

        private void btnPengembalian_Click(object sender, EventArgs e)
        {
            PengembalianSewa pengembalianSewa = new PengembalianSewa();
            pengembalianSewa.Show();
            this.Hide();
        }

        private void btnRiwayatSewa_Click(object sender, EventArgs e)
        {
            RiwayatSewaUser riwayatSewa = new RiwayatSewaUser();
            riwayatSewa.Show();
            this.Hide();
        }
    }
}
