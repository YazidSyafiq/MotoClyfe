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
    public partial class RiwayatSewaUser : Form
    {
        DataMotoClyfeDataContext db = new DataMotoClyfeDataContext();
        public RiwayatSewaUser()
        {
            InitializeComponent();
            LoadDataRiwayatSewaUsers();
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

        private void LoadDataRiwayatSewaUsers()
        {
            var riwayatSewa = from kembali in db.data_pengembalians
                              join sewa in db.data_sewas on kembali.id_sewa equals sewa.id_sewa
                              where sewa.data_user.username == Login.LoggeInUsername && kembali.status_pengembalian == "Sudah Dikembalikan"
                              select new
                              {
                                  ID_Pengembalian = kembali.id_pengembalian,
                                  ID_Sewa = sewa.id_sewa,
                                  Username = sewa.data_user.username,
                                  Plat = sewa.data_motor.plat_nomor,
                                  Tanggal_Sewa = sewa.tanggal_sewa,
                                  Tanggal_Pengembalian = kembali.date_pengembalian
                              };
            dataGridViewRiwayatSewa.DataSource = riwayatSewa.ToList();
        }
    }
}
