using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_Besar
{
    public partial class Login : Form
    {
        DataMotoClyfeDataContext db = new DataMotoClyfeDataContext();
        public static string LoggeInUsername { get; private set; }
        public Login()
        {
            InitializeComponent();
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

        private void linkLabelRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                byte[] hashedBytes = sha256.ComputeHash(passwordBytes);
                // Konversi Array ke Dalam Bentuk String Base64
                string hashedPassword = Convert.ToBase64String(hashedBytes);
                return hashedPassword;
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = HashPassword(tbPassword.Text);

            var user = db.data_users.FirstOrDefault(u => u.username == username && u.password == password);

            if (user != null)
            {
                Login.LoggeInUsername = username;

                if (user.role == "admin")
                {
                    MenuUtamaAdmin menuAdmin = new MenuUtamaAdmin();
                    menuAdmin.Show();
                }
                else if (user.role == "user")
                {
                    MenuUtamaUser menuUser = new MenuUtamaUser();
                    menuUser.Show();
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Gagal. Periksa kembali username dan password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbUsername.Clear();
                tbPassword.Clear();
            }
        }
    }
}
