using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kasirapotik
{
    public partial class Dasbor : Form
    {
        public Dasbor()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuMasterIdentitas menuMasterIdentitas = new MenuMasterIdentitas();
            menuMasterIdentitas.Show(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPembelian MenuPembelian = new MenuPembelian();
            MenuPembelian.Show(this);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Laporanpelanggan Laporanpelanggan = new Laporanpelanggan();
            Laporanpelanggan.Show(this);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try

            {

                Koneksi.conn.Open();

                MessageBox.Show("Koneksi Database Berhasil");

            }

            catch (Exception)

            {


                MessageBox.Show("Koneksi Gagal");

            }
        }
    }
}
