using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace WindowsFormsApplication3
{
    public partial class Form2 : Form
    {
        public string idterpilih1;
        MySqlConnection koneksi = new MySqlConnection("SERVER=localhost;DATABASE=coffeshop;UID=root;PASSWORD=;");
        public MySqlCommand command;
        //private Form1 form1;
        public Form2()
        {
            InitializeComponent();
            //this.form1 = form1;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            koneksi.Open();
            kirimData();
            koneksi.Close();
        }

        public void kirimData() {
            
            MySqlCommand command;
            command = koneksi.CreateCommand();

            command.CommandText = "SELECT * FROM barang";
            //Menampilkan data ke data GRID
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            //dataGridView1.DataSource = dataset.Tables[0].DefaultView;
            dgpembelian.DataSource = dataset.Tables[0].DefaultView;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //open koneksi
            koneksi.Open();

            //init sql command
            MySqlCommand command;
            command = koneksi.CreateCommand();

            //input data query
            command.CommandText = "INSERT INTO barang (namabarang, harga1, stok, tanggal) VALUES(@namabarang,@harga1,@stok,@tanggal);";

            //tambahkan parameter
            command.Parameters.AddWithValue("@namabarang", tbbarang.Text);
            command.Parameters.AddWithValue("@harga1", tbharga.Text);
            command.Parameters.AddWithValue("@stok", tbjumlah.Text);
            command.Parameters.AddWithValue("@tanggal", dateTimePicker1.Text);
            //Message box berhasil disimpan
            MessageBox.Show("data berhasil disimpan");

            //execute query
            command.ExecuteNonQuery();

            //kosongkan form
            tbbarang.Text= "";
            tbjumlah.Text = "";
            tbharga.Text = "";
            
            //Load data
            kirimData();

            //tutup koneksi
            koneksi.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        public void tbbarang_TextChanged(object sender, EventArgs e)
        {

        }

        public void tbjumlah_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgpembelian_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            koneksi.Open();
            command = new MySqlCommand("update barang set namabarang='" + tbbarang.Text + "'harga'" + tbharga.Text + "'jumlah'" + tbjumlah.Text +"' where id='" + idterpilih1 + "'", koneksi);
            command.ExecuteNonQuery();
            kirimData();
            koneksi.Close();
        }

        private void dgpembelian_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dgpembelian.CurrentCell.RowIndex;
            idterpilih1 = dgpembelian.Rows[row].Cells[0].Value.ToString();
            tbbarang.Text = dgpembelian.Rows[row].Cells[1].Value.ToString();
            tbharga.Text = dgpembelian.Rows[row].Cells[2].Value.ToString();
            tbjumlah.Text = dgpembelian.Rows[row].Cells[3].Value.ToString();
        }

        private void btnhapus_Click(object sender, EventArgs e)
        {
            int row = dgpembelian.CurrentCell.RowIndex;
            idterpilih1 = dgpembelian.Rows[row].Cells[0].Value.ToString();

            koneksi.Open();
            command = new MySqlCommand("delete from barang where id='" + idterpilih1 + "'", koneksi);
            command.ExecuteNonQuery();
            kirimData();
            koneksi.Close();
        }
    }
}
