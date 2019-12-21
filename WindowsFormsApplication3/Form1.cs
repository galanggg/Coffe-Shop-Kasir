﻿using System;
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
        MySqlConnection koneksi = new MySqlConnection("SERVER=localhost;DATABASE=coffeshop;UID=root;PASSWORD=;");

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
            command.CommandText = "INSERT INTO transaksi (nama) VALUES(@nama);";
            
            //tambahkan parameter
            command.Parameters.AddWithValue("@nama", tbnama.Text);
            //Message box berhasil disimpan
            MessageBox.Show("data berhasil disimpan");

            //execute query
            command.ExecuteNonQuery();

            //kosongkan form
            tbnama.Text = "";

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
            
             
        }


        private void cblatte_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "cappucino") {
                pictureBox5.Image = Image.FromFile("C:\\Users\\user\\Music\\asset\\espresso.jpg");
             } else if(comboBox1.Text == "espresso") {
                 pictureBox5.Image = Image.FromFile("C:\\Users\\user\\Music\\asset\\caffelate.jfif");
             }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
