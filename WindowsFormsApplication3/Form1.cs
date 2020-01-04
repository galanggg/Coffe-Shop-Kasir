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
    public partial class Form1 : Form
    {
        public string idterpilih;
        MySqlConnection koneksi = new MySqlConnection("SERVER=localhost;DATABASE=coffeshop;UID=root;PASSWORD=;");
        public MySqlCommand command;

        public Form1()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            koneksi.Open();
            loadData();
            koneksi.Close();
        }

        public void loadData() { 
            //inisialisasi MySQL Command
            MySqlCommand command;
            command = koneksi.CreateCommand();

            command.CommandText = "SELECT * FROM transaksi";

            //Menampilkan data ke data GRID
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            datagridkontak.DataSource = dataset.Tables[0].DefaultView;
            dataGridView2.DataSource = dataset.Tables[0].DefaultView;
        }

        public void hapusData() {
            
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void datagridkontak_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            //open koneksi
            koneksi.Open();

            //init sql command
            MySqlCommand command;
            command = koneksi.CreateCommand();

            //input data query
            command.CommandText = "INSERT INTO transaksi (nama, jumlah, harga, total, tanggal) VALUES(@nama,@jumlah,@harga,@total, @tanggal);";
            
            //tambahkan parameter
            command.Parameters.AddWithValue("@nama", comboBox1.Text);
            command.Parameters.AddWithValue("@jumlah", tbjumlah.Text);
            command.Parameters.AddWithValue("@harga", tbharga.Text);
            command.Parameters.AddWithValue("@total",  tbtotal.Text);
            command.Parameters.AddWithValue("@tanggal", dateTimePicker1.Text);
            //Message box berhasil disimpan
            MessageBox.Show("data berhasil disimpan");

            //execute query
            command.ExecuteNonQuery();

            //kosongkan form
            comboBox1.Text = "";
            tbjumlah.Text = "";
            tbharga.Text = "";
            tbtotal.Text = "";

            //Load data
            loadData();

            //tutup koneksi
            koneksi.Close();


        }

        private void tbalamat_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ptransaksi_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btntotal_Click(object sender, EventArgs e)
        {
            int harga, jumlah, tmp;
            double total2 = 0.0;
            double total1 = 0.0;

            harga = int.Parse(tbharga.Text);
            jumlah = int.Parse(tbjumlah.Text);

            tmp = harga * jumlah;

            total1 = tmp;

            tbtotal.Text = "Rp " + total1.ToString();
           
        }


        private void cblatte_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "cappucino") {
                pictureBox5.Image = Image.FromFile("C:\\Users\\user\\Music\\asset\\cappucino.jfif");
                tbharga.Text = "15000";
             } /*else if(comboBox1.Text == "espresso") {
                 pictureBox5.Image = Image.FromFile("C:\\Users\\User\\Documents\\Coffe-Shop-Kasir\\asset\\espresso.jpg");
                 tbharga.Text = "20000";
             } else if (comboBox1.Text == "affogato"){
                 pictureBox5.Image = Image.FromFile("C:\\Users\\User\\Documents\\Coffe-Shop-Kasir\\asset\\affogato.jpeg");
                tbharga.Text = "23000";
             }else if (comboBox1.Text == "latte"){
                pictureBox5.Image = Image.FromFile("C:\\Users\\User\\Documents\\Coffe-Shop-Kasir\\asset\\latte.jpg");
                tbharga.Text = "25000";
            } */
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void tbharga_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (tbuser.Text == "admin" && tbpass.Text == "123")
            {
                pbeli.Visible = true;
                plogin.Visible = false;
            }
            else if (tbuser.Text == "kasir" && tbpass.Text == "000")
            {
                ptransaksi.Visible = true;
                pbeli.Visible = false;
                plogin.Visible = false;

            }
            else
            {
                MessageBox.Show("");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            plogin.Visible = true;
        }

        private void btnlogout2_Click(object sender, EventArgs e)
        {
            plogin.Visible = true;
        }

        private void tbtotal_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void pbeli_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            int row = dataGridView2.CurrentCell.RowIndex;
            idterpilih = dataGridView2.Rows[row].Cells[0].Value.ToString();

            koneksi.Open();
            command = new MySqlCommand("delete from transaksi where id='" + idterpilih + "'", koneksi);
            command.ExecuteNonQuery();
            loadData();
            koneksi.Close();

            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pmenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridView2.CurrentCell.RowIndex;
            idterpilih = dataGridView2.Rows[row].Cells[0].Value.ToString();
            comboBox1.Text = dataGridView2.Rows[row].Cells[1].Value.ToString();
            tbjumlah.Text = dataGridView2.Rows[row].Cells[2].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            koneksi.Open();
            command = new MySqlCommand("update transaksi set nama='" + comboBox1.Text + "' where id='" + idterpilih + "'", koneksi);
            command.ExecuteNonQuery();
            loadData();
            koneksi.Close();
        }

        private void btntambah_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(this);
            f2.Show();
        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
