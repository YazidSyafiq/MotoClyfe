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
    public partial class Register : Form
    {
        DataMotoClyfeDataContext db = new DataMotoClyfeDataContext();
        public Register()
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

        private void linkLabelLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
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

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            string konfirmasi = tbKonfirmasiPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(konfirmasi))
            {
                MessageBox.Show("Username, Password, dan Konfirmasi Harus Terisi Semua!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (db.data_users.Any(u => u.username == username))
                {
                    MessageBox.Show("Username yang Anda Masukkan Sudah Terdaftar. Masukkan Username yang Berbeda!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if(password == konfirmasi)
                    {
                        string hashPassword = HashPassword(password);

                        var newUser = new data_user
                        {
                            username = username,
                            password = hashPassword,
                            role = "user"
                        };

                        db.data_users.InsertOnSubmit(newUser);
                        db.SubmitChanges();

                        DialogResult result;
                        result = MessageBox.Show("Anda Berhasil Melakukan Registrasi. Silahkan Login", "Success", MessageBoxButtons.OKCancel);

                        if (result == DialogResult.OK)
                        {
                            Login login = new Login();
                            login.Show();
                            this.Hide();
                        }
                        else
                        {
                            tbUsername.Clear();
                            tbPassword.Clear();
                            tbKonfirmasiPassword.Clear();

                            this.Show();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Pastikan Bahwa Isi Password dan Konfirmasi Password Sama!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
