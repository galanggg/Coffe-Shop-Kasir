﻿namespace WindowsFormsApplication3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.datagridkontak = new System.Windows.Forms.DataGridView();
            this.ptransaksi = new System.Windows.Forms.Panel();
            this.btnlogout2 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tbtotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbjumlah = new System.Windows.Forms.TextBox();
            this.tbharga = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btntotal = new System.Windows.Forms.Button();
            this.plogin = new System.Windows.Forms.Panel();
            this.btnlogin = new System.Windows.Forms.Button();
            this.lbpass = new System.Windows.Forms.Label();
            this.lbuser = new System.Windows.Forms.Label();
            this.tbpass = new System.Windows.Forms.TextBox();
            this.tbuser = new System.Windows.Forms.TextBox();
            this.lblogin = new System.Windows.Forms.Label();
            this.pbeli = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.Label = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btntambah = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.tbnamaupdate = new System.Windows.Forms.TextBox();
            this.tbjumlahupdate = new System.Windows.Forms.TextBox();
            this.tbhargaupdate = new System.Windows.Forms.TextBox();
            this.tbtotalupdate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            ((System.ComponentModel.ISupportInitialize)(this.datagridkontak)).BeginInit();
            this.ptransaksi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.plogin.SuspendLayout();
            this.pbeli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(495, 384);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(75, 23);
            this.btnsubmit.TabIndex = 8;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // datagridkontak
            // 
            this.datagridkontak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridkontak.Location = new System.Drawing.Point(492, 42);
            this.datagridkontak.Name = "datagridkontak";
            this.datagridkontak.Size = new System.Drawing.Size(393, 336);
            this.datagridkontak.TabIndex = 9;
            this.datagridkontak.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridkontak_CellContentClick);
            // 
            // ptransaksi
            // 
            this.ptransaksi.Controls.Add(this.btnlogout2);
            this.ptransaksi.Controls.Add(this.dateTimePicker1);
            this.ptransaksi.Controls.Add(this.tbtotal);
            this.ptransaksi.Controls.Add(this.label4);
            this.ptransaksi.Controls.Add(this.label2);
            this.ptransaksi.Controls.Add(this.label1);
            this.ptransaksi.Controls.Add(this.tbjumlah);
            this.ptransaksi.Controls.Add(this.tbharga);
            this.ptransaksi.Controls.Add(this.pictureBox5);
            this.ptransaksi.Controls.Add(this.comboBox1);
            this.ptransaksi.Controls.Add(this.btntotal);
            this.ptransaksi.Controls.Add(this.btnsubmit);
            this.ptransaksi.Controls.Add(this.label3);
            this.ptransaksi.Controls.Add(this.datagridkontak);
            this.ptransaksi.Location = new System.Drawing.Point(0, 1);
            this.ptransaksi.Name = "ptransaksi";
            this.ptransaksi.Size = new System.Drawing.Size(897, 483);
            this.ptransaksi.TabIndex = 11;
            this.ptransaksi.Visible = false;
            this.ptransaksi.Paint += new System.Windows.Forms.PaintEventHandler(this.ptransaksi_Paint);
            // 
            // btnlogout2
            // 
            this.btnlogout2.Location = new System.Drawing.Point(789, 395);
            this.btnlogout2.Name = "btnlogout2";
            this.btnlogout2.Size = new System.Drawing.Size(95, 34);
            this.btnlogout2.TabIndex = 38;
            this.btnlogout2.Text = "Logout";
            this.btnlogout2.UseVisualStyleBackColor = true;
            this.btnlogout2.Click += new System.EventHandler(this.btnlogout2_Click_1);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(672, 11);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 37;
            // 
            // tbtotal
            // 
            this.tbtotal.Location = new System.Drawing.Point(35, 318);
            this.tbtotal.Multiline = true;
            this.tbtotal.Name = "tbtotal";
            this.tbtotal.Size = new System.Drawing.Size(206, 28);
            this.tbtotal.TabIndex = 36;
            this.tbtotal.TextChanged += new System.EventHandler(this.tbtotal_TextChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 25);
            this.label4.TabIndex = 35;
            this.label4.Text = "Menu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Jumlah";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Harga";
            // 
            // tbjumlah
            // 
            this.tbjumlah.Location = new System.Drawing.Point(35, 197);
            this.tbjumlah.Multiline = true;
            this.tbjumlah.Name = "tbjumlah";
            this.tbjumlah.Size = new System.Drawing.Size(138, 25);
            this.tbjumlah.TabIndex = 32;
            // 
            // tbharga
            // 
            this.tbharga.Location = new System.Drawing.Point(35, 131);
            this.tbharga.Multiline = true;
            this.tbharga.Name = "tbharga";
            this.tbharga.Size = new System.Drawing.Size(138, 25);
            this.tbharga.TabIndex = 31;
            this.tbharga.TextChanged += new System.EventHandler(this.tbharga_TextChanged);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(202, 54);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(249, 173);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 30;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Cappucino",
            "Espresso",
            "Affogato",
            "Latte"});
            this.comboBox1.Location = new System.Drawing.Point(35, 61);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(133, 21);
            this.comboBox1.TabIndex = 29;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btntotal
            // 
            this.btntotal.Location = new System.Drawing.Point(166, 352);
            this.btntotal.Name = "btntotal";
            this.btntotal.Size = new System.Drawing.Size(75, 31);
            this.btntotal.TabIndex = 19;
            this.btntotal.Text = "Total";
            this.btntotal.UseVisualStyleBackColor = true;
            this.btntotal.Click += new System.EventHandler(this.btntotal_Click);
            // 
            // plogin
            // 
            this.plogin.Controls.Add(this.btnlogin);
            this.plogin.Controls.Add(this.lbpass);
            this.plogin.Controls.Add(this.lbuser);
            this.plogin.Controls.Add(this.tbpass);
            this.plogin.Controls.Add(this.tbuser);
            this.plogin.Controls.Add(this.lblogin);
            this.plogin.Location = new System.Drawing.Point(0, 1);
            this.plogin.Name = "plogin";
            this.plogin.Size = new System.Drawing.Size(894, 480);
            this.plogin.TabIndex = 0;
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(479, 289);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(75, 23);
            this.btnlogin.TabIndex = 5;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // lbpass
            // 
            this.lbpass.AutoSize = true;
            this.lbpass.Location = new System.Drawing.Point(328, 245);
            this.lbpass.Name = "lbpass";
            this.lbpass.Size = new System.Drawing.Size(53, 13);
            this.lbpass.TabIndex = 4;
            this.lbpass.Text = "Password";
            // 
            // lbuser
            // 
            this.lbuser.AutoSize = true;
            this.lbuser.Location = new System.Drawing.Point(328, 195);
            this.lbuser.Name = "lbuser";
            this.lbuser.Size = new System.Drawing.Size(55, 13);
            this.lbuser.TabIndex = 3;
            this.lbuser.Text = "Username";
            this.lbuser.Click += new System.EventHandler(this.label6_Click);
            // 
            // tbpass
            // 
            this.tbpass.Location = new System.Drawing.Point(404, 242);
            this.tbpass.Name = "tbpass";
            this.tbpass.PasswordChar = '*';
            this.tbpass.Size = new System.Drawing.Size(150, 20);
            this.tbpass.TabIndex = 2;
            // 
            // tbuser
            // 
            this.tbuser.Location = new System.Drawing.Point(404, 192);
            this.tbuser.Name = "tbuser";
            this.tbuser.Size = new System.Drawing.Size(150, 20);
            this.tbuser.TabIndex = 1;
            // 
            // lblogin
            // 
            this.lblogin.AutoSize = true;
            this.lblogin.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblogin.Location = new System.Drawing.Point(386, 101);
            this.lblogin.Name = "lblogin";
            this.lblogin.Size = new System.Drawing.Size(168, 33);
            this.lblogin.TabIndex = 0;
            this.lblogin.Text = "Janjiku Jiwamu";
            // 
            // pbeli
            // 
            this.pbeli.Controls.Add(this.label9);
            this.pbeli.Controls.Add(this.label8);
            this.pbeli.Controls.Add(this.label7);
            this.pbeli.Controls.Add(this.label6);
            this.pbeli.Controls.Add(this.tbtotalupdate);
            this.pbeli.Controls.Add(this.tbhargaupdate);
            this.pbeli.Controls.Add(this.tbjumlahupdate);
            this.pbeli.Controls.Add(this.tbnamaupdate);
            this.pbeli.Controls.Add(this.button1);
            this.pbeli.Controls.Add(this.button4);
            this.pbeli.Controls.Add(this.button3);
            this.pbeli.Controls.Add(this.btnlogout);
            this.pbeli.Controls.Add(this.button2);
            this.pbeli.Controls.Add(this.btndelete);
            this.pbeli.Controls.Add(this.Label);
            this.pbeli.Controls.Add(this.dataGridView1);
            this.pbeli.Controls.Add(this.btntambah);
            this.pbeli.Controls.Add(this.dataGridView2);
            this.pbeli.Controls.Add(this.label5);
            this.pbeli.Location = new System.Drawing.Point(0, 1);
            this.pbeli.Name = "pbeli";
            this.pbeli.Size = new System.Drawing.Size(894, 483);
            this.pbeli.TabIndex = 0;
            this.pbeli.Visible = false;
            this.pbeli.Paint += new System.Windows.Forms.PaintEventHandler(this.pbeli_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(781, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 44);
            this.button1.TabIndex = 41;
            this.button1.Text = "Cetak";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(328, 373);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 44);
            this.button4.TabIndex = 40;
            this.button4.Text = "Cetak";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(603, 271);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 53);
            this.button3.TabIndex = 39;
            this.button3.Text = "Refresh";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_3);
            // 
            // btnlogout
            // 
            this.btnlogout.Location = new System.Drawing.Point(789, 395);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(95, 34);
            this.btnlogout.TabIndex = 37;
            this.btnlogout.Text = "Logout";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(133, 373);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 44);
            this.button2.TabIndex = 12;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Transparent;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btndelete.Location = new System.Drawing.Point(26, 373);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(91, 44);
            this.btndelete.TabIndex = 11;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.Location = new System.Drawing.Point(468, 42);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(150, 31);
            this.Label.TabIndex = 3;
            this.Label.Text = "Pembelian";
            this.Label.Click += new System.EventHandler(this.Label_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(474, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(410, 173);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btntambah
            // 
            this.btntambah.Location = new System.Drawing.Point(474, 271);
            this.btntambah.Name = "btntambah";
            this.btntambah.Size = new System.Drawing.Size(108, 53);
            this.btntambah.TabIndex = 0;
            this.btntambah.Text = "Data Pembelian";
            this.btntambah.UseVisualStyleBackColor = true;
            this.btntambah.Click += new System.EventHandler(this.btntambah_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 92);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(419, 178);
            this.dataGridView2.TabIndex = 10;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 31);
            this.label5.TabIndex = 38;
            this.label5.Text = "Data Transaksi";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tbnamaupdate
            // 
            this.tbnamaupdate.Location = new System.Drawing.Point(18, 309);
            this.tbnamaupdate.Multiline = true;
            this.tbnamaupdate.Name = "tbnamaupdate";
            this.tbnamaupdate.Size = new System.Drawing.Size(91, 37);
            this.tbnamaupdate.TabIndex = 42;
            // 
            // tbjumlahupdate
            // 
            this.tbjumlahupdate.Location = new System.Drawing.Point(125, 309);
            this.tbjumlahupdate.Multiline = true;
            this.tbjumlahupdate.Name = "tbjumlahupdate";
            this.tbjumlahupdate.Size = new System.Drawing.Size(91, 37);
            this.tbjumlahupdate.TabIndex = 43;
            // 
            // tbhargaupdate
            // 
            this.tbhargaupdate.Location = new System.Drawing.Point(235, 309);
            this.tbhargaupdate.Multiline = true;
            this.tbhargaupdate.Name = "tbhargaupdate";
            this.tbhargaupdate.Size = new System.Drawing.Size(91, 37);
            this.tbhargaupdate.TabIndex = 44;
            // 
            // tbtotalupdate
            // 
            this.tbtotalupdate.Location = new System.Drawing.Point(346, 309);
            this.tbtotalupdate.Multiline = true;
            this.tbtotalupdate.Name = "tbtotalupdate";
            this.tbtotalupdate.Size = new System.Drawing.Size(91, 37);
            this.tbtotalupdate.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 46;
            this.label6.Text = "Nama";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(136, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 47;
            this.label7.Text = "Jumlah";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(251, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 20);
            this.label8.TabIndex = 48;
            this.label8.Text = "Harga";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(365, 286);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 20);
            this.label9.TabIndex = 49;
            this.label9.Text = "Total";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(896, 442);
            this.shapeContainer1.TabIndex = 12;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 438;
            this.lineShape1.X2 = 453;
            this.lineShape1.Y1 = 1;
            this.lineShape1.Y2 = 443;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 442);
            this.Controls.Add(this.pbeli);
            this.Controls.Add(this.ptransaksi);
            this.Controls.Add(this.plogin);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridkontak)).EndInit();
            this.ptransaksi.ResumeLayout(false);
            this.ptransaksi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.plogin.ResumeLayout(false);
            this.plogin.PerformLayout();
            this.pbeli.ResumeLayout(false);
            this.pbeli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.DataGridView datagridkontak;
        private System.Windows.Forms.Panel ptransaksi;
        private System.Windows.Forms.Button btntotal;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbjumlah;
        private System.Windows.Forms.TextBox tbharga;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel plogin;
        private System.Windows.Forms.Label lbuser;
        private System.Windows.Forms.TextBox tbpass;
        private System.Windows.Forms.TextBox tbuser;
        private System.Windows.Forms.Label lblogin;
        private System.Windows.Forms.Label lbpass;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Panel pbeli;
        private System.Windows.Forms.Button btntambah;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.TextBox tbtotal;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnlogout2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbnamaupdate;
        private System.Windows.Forms.TextBox tbtotalupdate;
        private System.Windows.Forms.TextBox tbhargaupdate;
        private System.Windows.Forms.TextBox tbjumlahupdate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;

    }
}

