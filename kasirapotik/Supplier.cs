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
    public partial class Supplier : Form
    {
        public MySqlCommand cmd;
        public string idsupplier;

        public void Tampil()
        {
          


        }
        public Supplier()
        {
            InitializeComponent();
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

        private void Tablesupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM tblsupplier", Koneksi.conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            Tablesupplier.DataSource = ds.Tables[0];
            Koneksi.conn.Close(); Tampil();
        }

        private void Tablesupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = Tablesupplier.CurrentCell.RowIndex;
            idsupplier = Tablesupplier.Rows[baris].Cells[0].Value.ToString();


            textBox1.Text = Tablesupplier.Rows[baris].Cells[1].Value.ToString();
            textBox3.Text = Tablesupplier.Rows[baris].Cells[2].Value.ToString();
            textBox2.Text = Tablesupplier.Rows[baris].Cells[3].Value.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            cmd = new MySqlCommand("UPDATE `tblsupplier` SET `idsupplier` = '"+idsupplier+"', `supplier` = '"+textBox1.Text+"', `alamatsupplier` = '"+textBox3.Text+"', `no.telponsupplier` = '"+textBox2.Text+"', `utang` = '400' WHERE `tblsupplier`.`idsupplier` = '"+idsupplier+"'; ;", Koneksi.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("data berhasil disimpan");
            Koneksi.conn.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            cmd = new MySqlCommand("INSERT INTO `tblsupplier` (`idsupplier`, `supplier`, `alamatsupplier`, `no.telponsupplier`, `utang`) VALUES (NULL, '"+textBox1.Text+"', '"+textBox3.Text+"', '"+textBox2.Text+"', '20000'); ;", Koneksi.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("data berhasil ditambah");
            Koneksi.conn.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            cmd = new MySqlCommand("DELETE FROM tblsupplier WHERE `tblsupplier`.`idsupplier` = '"+idsupplier+"';", Koneksi.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("data berhasil dihapus");
            Koneksi.conn.Close();
        }
    }
}
