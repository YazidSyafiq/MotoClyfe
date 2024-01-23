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
    public partial class DaftarUser : Form
    {
        DataMotoClyfeDataContext db = new DataMotoClyfeDataContext();
        public DaftarUser()
        {
            InitializeComponent();
            LoadDataUser();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MenuUtamaAdmin menu = new MenuUtamaAdmin();
            menu.Show();
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

        private void LoadDataUser()
        {
            var userData = from user in db.data_users
                           where user.role == "user"
                           select new
                           {
                               ID_User = user.id_user,
                               Username = user.username,
                           };
            dataGridViewUser.DataSource = userData.ToList();
        }
    }
}
