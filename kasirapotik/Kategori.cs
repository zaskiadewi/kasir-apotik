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
    public partial class Kategori : Form
    {
        public MySqlCommand cmd;
        public string idkategori;

        public void Tampil()
        {
            


        }
        public Kategori()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Obat Obat = new Obat();
            Obat.Show(this);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuMasterIdentitas MenuMasterIdentitas = new MenuMasterIdentitas();
            MenuMasterIdentitas.Show(this);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Satuan Satuan = new Satuan();
            Satuan.Show(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pelanggan Pelanggan = new Pelanggan();
            Pelanggan.Show(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kategori Kategori = new Kategori();
            Kategori.Show(this);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Supplier Supplier = new Supplier();
            Supplier.Show(this);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dasbor Dasbor = new Dasbor();
            Dasbor.Show(this);
        }

        private void Tablekategori_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Kategori_Load(object sender, EventArgs e)
        {
                Koneksi.conn.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM tblkategori", Koneksi.conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                Tablekategori.DataSource = ds.Tables[0];
                Koneksi.conn.Close();
        }

        private void Tablekategori_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = Tablekategori.CurrentCell.RowIndex;
            idkategori = Tablekategori.Rows[baris].Cells[0].Value.ToString();


            textBox3.Text = Tablekategori.Rows[baris].Cells[1].Value.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            cmd = new MySqlCommand("DELETE FROM tblkategori WHERE `tblkategori`.`idkategori` = '"+idkategori+"';", Koneksi.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("data berhasil dihapus");
            Koneksi.conn.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            cmd = new MySqlCommand("INSERT INTO `tblkategori` (`idkategori`, `kategori`) VALUES (NULL, '"+textBox3.Text+"');", Koneksi.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("data berhasil ditambah");
            Koneksi.conn.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            cmd = new MySqlCommand("UPDATE `tblkategori` SET `kategori` = '"+textBox3.Text+"' WHERE `tblkategori`.`idkategori` = '"+idkategori+"'; ;", Koneksi.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("data berhasil disimpan");
            Koneksi.conn.Close();
        }
    }
}
