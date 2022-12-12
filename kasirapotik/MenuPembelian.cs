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
    public partial class MenuPembelian : Form
    {
        Koneksi koneksi = new Koneksi();

        public void Tampil()
        {
        


        }
        public MenuPembelian()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPembelian MenuPembelian = new MenuPembelian();
            MenuPembelian.Show(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPenjualan MenuPenjualan = new MenuPenjualan();
            MenuPenjualan.Show(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuHutang MenuHutang = new MenuHutang();
            MenuHutang.Show(this);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPiutang MenuPiutang = new MenuPiutang();
            MenuPiutang.Show(this);
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dasbor Dasbor = new Dasbor();
            Dasbor.Show(this);
        }

        private void Tablepembelian_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MenuPembelian_Load(object sender, EventArgs e)
        {
            Tampil();
        }
    }
}
