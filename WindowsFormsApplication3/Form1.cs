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
            MySqlCommand command1;
            command = koneksi.CreateCommand();
            command1 = koneksi.CreateCommand();

            command.CommandText = "SELECT * FROM transaksi";
            command1.CommandText = "SELECT * FROM barang";

            //Menampilkan data ke data GRID
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            MySqlDataAdapter adapter1 = new MySqlDataAdapter(command1);
            DataSet dataset = new DataSet();
            DataSet dataset1 = new DataSet();
            adapter.Fill(dataset);
            adapter1.Fill(dataset1);
            //menampilkan data ke datagridkontak "KASIR"
            datagridkontak.DataSource = dataset.Tables[0].DefaultView;
            //menampilkan data ke datagridview "ADMIN"
            dataGridView2.DataSource = dataset.Tables[0].DefaultView;
            //menampilkan data ke datagridview pembelian "ADMIN"
            dataGridView1.DataSource = dataset1.Tables[0].DefaultView;
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
            //double total2 = 0.0;
            double total1 = 0.0;

            harga = int.Parse(tbharga.Text);
            jumlah = int.Parse(tbjumlah.Text);

            tmp = harga * jumlah;

            total1 = tmp;

            tbtotal.Text = total1.ToString();
           
        }


        private void cblatte_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
             if (comboBox1.Text == "Cappucino") {
                pictureBox5.Image = Image.FromFile("C:\\Users\\User\\Documents\\Visual Studio 2010\\Projects\\Coffe-Shop-Kasir\\asset\\cappucino.jpg");
                tbharga.Text = "15000";
             } else if(comboBox1.Text == "Espresso") {
                 pictureBox5.Image = Image.FromFile("C:\\Users\\User\\Documents\\Visual Studio 2010\\Projects\\Coffe-Shop-Kasir\\asset\\espresso.jpg");
                 tbharga.Text = "20000";
             } else if (comboBox1.Text == "Affogato"){
                 pictureBox5.Image = Image.FromFile("C:\\Users\\User\\Documents\\Visual Studio 2010\\Projects\\Coffe-Shop-Kasir\\asset\\affogato.jpeg");
                tbharga.Text = "23000";
             }else if (comboBox1.Text == "Latte"){
                pictureBox5.Image = Image.FromFile("C:\\Users\\User\\Documents\\Visual Studio 2010\\Projects\\Coffe-Shop-Kasir\\asset\\latte.jpg");
                tbharga.Text = "25000";
             } 

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
                btnlogout.Visible = true;
            }
            else if (tbuser.Text == "kasir" && tbpass.Text == "000")
            {
                ptransaksi.Visible = true;
                pbeli.Visible = false;
                plogin.Visible = false;

            }
            else
            {
                MessageBox.Show("Yang bener dong bos!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

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

        public void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridView2.CurrentCell.RowIndex;
            idterpilih = dataGridView2.Rows[row].Cells[0].Value.ToString();
            tbnamaupdate.Text= dataGridView2.Rows[row].Cells[1].Value.ToString();
            tbjumlahupdate.Text = dataGridView2.Rows[row].Cells[2].Value.ToString();
            tbhargaupdate.Text = dataGridView2.Rows[row].Cells[3].Value.ToString();
            tbtotalupdate.Text = dataGridView2.Rows[row].Cells[4].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            koneksi.Open();
            command = new MySqlCommand("update transaksi set nama='" + tbnamaupdate.Text + "', jumlah='" + tbjumlahupdate.Text + "',harga='" + tbhargaupdate.Text + "',total='" + tbtotalupdate.Text + "' where id='" + idterpilih + "'", koneksi);
            command.ExecuteNonQuery();
            loadData();
            koneksi.Close();
        }

        private void btntambah_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            
        }

        private void btnlogout2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnlogout2_Click_1(object sender, EventArgs e)
        {
            plogin.Visible = true;
            ptransaksi.Visible = false;
        }

        private void btnlogout_Click_1(object sender, EventArgs e)
        {
            plogin.Visible = true;
            pbeli.Visible = false;
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /* Form2 f2 = new Form2(this);
            int row = dataGridView1.CurrentCell.RowIndex;
            f2.idterpilih1 = dataGridView1.Rows[row].Cells[0].Value.ToString();
            f2.tbbarang.Text = dataGridView1.Rows[row].Cells[1].Value.ToString();
            f2.tbharga.Text = dataGridView1.Rows[row].Cells[2].Value.ToString();
            f2.tbjumlah.Text = dataGridView1.Rows[row].Cells[3].Value.ToString(); */
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_2(object sender, EventArgs e)
        {
           
        }

        private void button3_Click_3(object sender, EventArgs e)
        {
            loadData();
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void Label_Click(object sender, EventArgs e)
        {

        }
        
    }
}