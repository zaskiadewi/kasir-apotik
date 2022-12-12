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
    public partial class Satuan : Form
    {
        public MySqlCommand cmd;
        public string idsatuan;


        public void Tampil()
        {
           

           
        }
        public Satuan()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM tblsatuan", Koneksi.conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            Tablesatuan.DataSource = ds.Tables[0];
            Koneksi.conn.Close(); Tampil();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuMasterIdentitas menuMasterIdentitas = new MenuMasterIdentitas();
            menuMasterIdentitas.Show(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pelanggan Pelanggan = new Pelanggan();
            Pelanggan.Show(this);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kategori Kategori = new Kategori();
            Kategori.Show(this);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Obat Obat = new Obat();
            Obat.Show(this);
        }

        private void button7_Click(object sender, EventArgs e)
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

        private void Tablesatuan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Tablesatuan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = Tablesatuan.CurrentCell.RowIndex;
            idsatuan = Tablesatuan.Rows[baris].Cells[0].Value.ToString();


            textBox20.Text = Tablesatuan.Rows[baris].Cells[1].Value.ToString();
            textBox1.Text = Tablesatuan.Rows[baris].Cells[2].Value.ToString();
            textBox2.Text = Tablesatuan.Rows[baris].Cells[3].Value.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            cmd = new MySqlCommand("INSERT INTO `tblsatuan` (`idsatuan`, `satuanbesar`, `satuankecil`, `nilai`) VALUES (NULL, '"+textBox20.Text+"', '"+textBox1.Text+"', '"+textBox2.Text+"'); ;", Koneksi.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("data berhasil ditambah");
            Koneksi.conn.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            cmd = new MySqlCommand("UPDATE `tblsatuan` SET `satuanbesar` = '"+textBox20.Text+"', `satuankecil` = '"+textBox1.Text+"', `nilai` = '"+textBox2.Text+"' WHERE `tblsatuan`.`idsatuan` = '"+idsatuan+"'; ;", Koneksi.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("data berhasil disimpan");
            Koneksi.conn.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            cmd = new MySqlCommand("DELETE FROM tblsatuan WHERE `tblsatuan`.`idsatuan` = '"+idsatuan+"';", Koneksi.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("data berhasil dihapus");
            Koneksi.conn.Close();
        }
    }
}
