using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kasirapotik
{
    public partial class MenuMasterIdentitas : Form
    {
        public MySqlCommand cmd;
        public string ididentitas;
       

        public void Tampil()
        {

           
        }

        public MenuMasterIdentitas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            cmd = new MySqlCommand("INSERT INTO `tblidentitas` (`id_identitas`, `nama apotek`, `alamat apotek`, `caption pertama`, `caption kedua`, `caption ketiga`, `jangkauan hari expired`, `no.telponapotek`) VALUES (NULL, '"+textBox18.Text+"', '"+textBox13.Text+"', '"+textBox16.Text+"', '"+textBox15.Text+"', '"+textBox14.Text+"', '"+textBox17.Text+"', '"+textBox19.Text+"');", Koneksi.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("data berhasil ditambah");
            Koneksi.conn.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            cmd = new MySqlCommand("UPDATE `tblidentitas` SET `nama apotek` = '"+textBox18.Text+"', `alamat apotek` = '"+textBox13.Text+"', `caption pertama` = '"+textBox16.Text+"', `caption kedua` = '"+textBox15.Text+"', `caption ketiga` = '"+textBox14.Text+"', `jangkauan hari expired` = '"+textBox17.Text+"', `no.telponapotek` = '"+textBox19.Text+"' WHERE `tblidentitas`.`id_identitas` = '"+ididentitas+"';", Koneksi.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("data berhasil disimpan");
            Koneksi.conn.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            cmd = new MySqlCommand("DELETE FROM tblidentitas WHERE `tblidentitas`.`id_identitas` = '"+ididentitas+"';", Koneksi.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("data berhasil dihapus");
            Koneksi.conn.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPembelian identitas = new MenuPembelian();
            identitas.ShowDialog();
        }
        
        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM tblidentitas", Koneksi.conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            Tableidentitas.DataSource = ds.Tables[0];
            Koneksi.conn.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Satuan Satuan = new Satuan();
            Satuan.Show(this);
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Pelanggan Pelanggan = new Pelanggan();
            Pelanggan.Show(this);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kategori Kategori = new Kategori();
            Kategori.Show(this);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            this.Hide();
            Obat Obat = new Obat();
            Obat.Show(this);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            this.Hide();
            Supplier Supplier = new Supplier();
            Supplier.Show(this);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Dasbor Dasbor = new Dasbor();
            Dasbor.Show(this);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void Tableidentitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = Tableidentitas.CurrentCell.RowIndex;
            ididentitas = Tableidentitas.Rows[baris].Cells[0].Value.ToString();
            

            textBox18.Text = Tableidentitas.Rows[baris].Cells[1].Value.ToString();
            textBox13.Text = Tableidentitas.Rows[baris].Cells[2].Value.ToString();
            textBox16.Text = Tableidentitas.Rows[baris].Cells[3].Value.ToString();
            textBox15.Text = Tableidentitas.Rows[baris].Cells[4].Value.ToString();
            textBox14.Text = Tableidentitas.Rows[baris].Cells[5].Value.ToString();
            textBox17.Text = Tableidentitas.Rows[baris].Cells[6].Value.ToString();
            textBox19.Text = Tableidentitas.Rows[baris].Cells[7].Value.ToString();

        }
    }
}
