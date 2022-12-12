using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kasirapotik
{
    public partial class Pelanggan : Form
    {
        public MySqlCommand cmd;
        public string idpelanggan;

        public void Tampil()
        {
         


        }
        public Pelanggan()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pelanggan_Load(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM tblpelanggan", Koneksi.conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            Tablepelanggan.DataSource = ds.Tables[0];
            Koneksi.conn.Close(); Tampil();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kategori Kategori = new Kategori();
            Kategori.Show(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuMasterIdentitas MenuMasterIdentitas = new MenuMasterIdentitas();
            MenuMasterIdentitas.Show(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Satuan Satuan = new Satuan();
            Satuan.Show(this);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            cmd = new MySqlCommand("INSERT INTO `tblpelanggan` (`idpelanggan`, `pelanggan`, `alamatpelanggan`, `no.telponpelanggan`) VALUES (NULL, '"+textBox2.Text+"', '"+textBox1.Text+"', '"+textBox4.Text+"'); ;", Koneksi.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("data berhasil ditambah");
            Koneksi.conn.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dasbor Dasbor = new Dasbor();
            Dasbor.Show(this);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Supplier Supplier = new Supplier();
            Supplier.Show(this);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Obat Obat = new Obat();
            Obat.Show(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pelanggan Pelanggan = new Pelanggan();
            Pelanggan.Show(this);
        }

        private void Tablepelanggan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Tablepelanggan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = Tablepelanggan.CurrentCell.RowIndex;
            idpelanggan = Tablepelanggan.Rows[baris].Cells[0].Value.ToString();


            textBox2.Text = Tablepelanggan.Rows[baris].Cells[1].Value.ToString();
            textBox1.Text = Tablepelanggan.Rows[baris].Cells[2].Value.ToString();
            textBox4.Text = Tablepelanggan.Rows[baris].Cells[3].Value.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            cmd = new MySqlCommand("UPDATE `tblpelanggan` SET `pelanggan` = '"+textBox2.Text+"', `alamatpelanggan` = '"+textBox1.Text+"', `no.telponpelanggan` = '"+textBox4.Text+"' WHERE `tblpelanggan`.`idpelanggan` = '"+idpelanggan+"'; ;", Koneksi.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("data berhasil disimpan");
            Koneksi.conn.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            cmd = new MySqlCommand("DELETE FROM tblpelanggan WHERE `tblpelanggan`.`idpelanggan` = '"+idpelanggan+"';", Koneksi.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("data berhasil dihapus");
            Koneksi.conn.Close();
        }
    }
}
