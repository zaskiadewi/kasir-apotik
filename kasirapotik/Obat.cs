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
    public partial class Obat : Form
    {
        public MySqlCommand cmd;
        public string idobat;

        public void Tampil()
        {
           


        }
        public Obat()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Supplier Supplier = new Supplier();
            Supplier.Show(this);
        }

        private void button7_Click(object sender, EventArgs e)
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

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Obat Obat = new Obat();
            Obat.Show(this);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dasbor Dasbor = new Dasbor();
            Dasbor.Show(this);
        }

        private void Tableobat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Obat_Load(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM tblobat", Koneksi.conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            Tableobat.DataSource = ds.Tables[0];
            Koneksi.conn.Close(); Tampil();
        }

        private void Tableobat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = Tableobat.CurrentCell.RowIndex;
            idobat = Tableobat.Rows[baris].Cells[0].Value.ToString();


            comboBox1.Text = Tableobat.Rows[baris].Cells[1].Value.ToString();
            comboBox2.Text = Tableobat.Rows[baris].Cells[2].Value.ToString();
            textBox20.Text = Tableobat.Rows[baris].Cells[3].Value.ToString();
            textBox2.Text = Tableobat.Rows[baris].Cells[4].Value.ToString();
            comboBox3.Text = Tableobat.Rows[baris].Cells[5].Value.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            cmd = new MySqlCommand("INSERT INTO `tblobat` (`id_obat`, `idsatuan`, `idkategori`, `namaobat`, `kodeobat`, `titipan`) VALUES (NULL, '"+comboBox1.Text+"', '"+comboBox2.Text+"', '"+textBox20.Text+"', '"+textBox2.Text+"', '"+comboBox3.Text+"'); ;", Koneksi.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("data berhasil ditambah");
            Koneksi.conn.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            cmd = new MySqlCommand("UPDATE `tblobat` SET `idsatuan` = '"+comboBox1.Text+"', `idkategori` = '"+comboBox2.Text+"', `namaobat` = '"+textBox20.Text+"', `kodeobat` = '"+textBox2.Text+"', `titipan` = '"+comboBox3.Text+"' WHERE `tblobat`.`id_obat` = '"+idobat+"'; ;", Koneksi.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("data berhasil disimpan");
            Koneksi.conn.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            cmd = new MySqlCommand("DELETE FROM tblobat WHERE `tblobat`.`id_obat` = '"+idobat+"';", Koneksi.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("data berhasil dihapus");
            Koneksi.conn.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
