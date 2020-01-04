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
        MySqlConnection koneksi = new MySqlConnection("SERVER=localhost;DATABASE=coffeshop;UID=root;PASSWORD=;");
        public MySqlCommand command;
        private Form1 form1;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
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
            form1.dataGridView1.DataSource = dataset.Tables[0].DefaultView;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //open koneksi
            koneksi.Open();

            //init sql command
            MySqlCommand command;
            command = koneksi.CreateCommand();

            //input data query
            command.CommandText = "INSERT INTO barang (barang, harga1, stok, tanggal) VALUES(@barang,@harga1,@stok,@tanggal);";

            //tambahkan parameter
            command.Parameters.AddWithValue("@barang", tbbarang.Text);
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
    }
}
