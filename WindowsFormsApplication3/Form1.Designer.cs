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
            this.tbnama = new System.Windows.Forms.TextBox();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.datagridkontak = new System.Windows.Forms.DataGridView();
            this.pmenu = new System.Windows.Forms.Panel();
            this.ptransaksi = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbjumlah = new System.Windows.Forms.TextBox();
            this.tbharga = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btntotal = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.plogin = new System.Windows.Forms.Panel();
            this.lblogin = new System.Windows.Forms.Label();
            this.tbuser = new System.Windows.Forms.TextBox();
            this.tbpass = new System.Windows.Forms.TextBox();
            this.lbuser = new System.Windows.Forms.Label();
            this.lbpass = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.pbeli = new System.Windows.Forms.Panel();
            this.btntambah = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnupdate = new System.Windows.Forms.Button();
            this.Label = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnlogout = new System.Windows.Forms.Button();
            this.btnlogout2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridkontak)).BeginInit();
            this.ptransaksi.SuspendLayout();
            this.plogin.SuspendLayout();
            this.pbeli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(627, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbnama
            // 
            this.tbnama.Location = new System.Drawing.Point(673, 96);
            this.tbnama.Multiline = true;
            this.tbnama.Name = "tbnama";
            this.tbnama.Size = new System.Drawing.Size(199, 28);
            this.tbnama.TabIndex = 5;
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(491, 190);
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
            this.datagridkontak.Location = new System.Drawing.Point(491, 219);
            this.datagridkontak.Name = "datagridkontak";
            this.datagridkontak.Size = new System.Drawing.Size(393, 173);
            this.datagridkontak.TabIndex = 9;
            this.datagridkontak.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridkontak_CellContentClick);
            // 
            // pmenu
            // 
            this.pmenu.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pmenu.Location = new System.Drawing.Point(0, -1);
            this.pmenu.Name = "pmenu";
            this.pmenu.Size = new System.Drawing.Size(897, 81);
            this.pmenu.TabIndex = 10;
            // 
            // ptransaksi
            // 
            this.ptransaksi.Controls.Add(this.btnlogout2);
            this.ptransaksi.Controls.Add(this.label4);
            this.ptransaksi.Controls.Add(this.label2);
            this.ptransaksi.Controls.Add(this.label1);
            this.ptransaksi.Controls.Add(this.tbjumlah);
            this.ptransaksi.Controls.Add(this.tbharga);
            this.ptransaksi.Controls.Add(this.pictureBox5);
            this.ptransaksi.Controls.Add(this.comboBox1);
            this.ptransaksi.Controls.Add(this.button1);
            this.ptransaksi.Controls.Add(this.btntotal);
            this.ptransaksi.Controls.Add(this.dateTimePicker1);
            this.ptransaksi.Controls.Add(this.btnsubmit);
            this.ptransaksi.Controls.Add(this.label3);
            this.ptransaksi.Controls.Add(this.tbnama);
            this.ptransaksi.Controls.Add(this.datagridkontak);
            this.ptransaksi.Location = new System.Drawing.Point(0, 81);
            this.ptransaksi.Name = "ptransaksi";
            this.ptransaksi.Size = new System.Drawing.Size(897, 403);
            this.ptransaksi.TabIndex = 11;
            this.ptransaksi.Visible = false;
            this.ptransaksi.Paint += new System.Windows.Forms.PaintEventHandler(this.ptransaksi_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Menu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Jumlah";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Harga";
            // 
            // tbjumlah
            // 
            this.tbjumlah.Location = new System.Drawing.Point(99, 144);
            this.tbjumlah.Multiline = true;
            this.tbjumlah.Name = "tbjumlah";
            this.tbjumlah.Size = new System.Drawing.Size(133, 28);
            this.tbjumlah.TabIndex = 32;
            // 
            // tbharga
            // 
            this.tbharga.Location = new System.Drawing.Point(99, 92);
            this.tbharga.Multiline = true;
            this.tbharga.Name = "tbharga";
            this.tbharga.Size = new System.Drawing.Size(133, 28);
            this.tbharga.TabIndex = 31;
            this.tbharga.TextChanged += new System.EventHandler(this.tbharga_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "cappucino",
            "espresso",
            "affogato",
            "latte"});
            this.comboBox1.Location = new System.Drawing.Point(99, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(133, 21);
            this.comboBox1.TabIndex = 29;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(572, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Cetak";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btntotal
            // 
            this.btntotal.Location = new System.Drawing.Point(797, 130);
            this.btntotal.Name = "btntotal";
            this.btntotal.Size = new System.Drawing.Size(75, 37);
            this.btntotal.TabIndex = 19;
            this.btntotal.Text = "total";
            this.btntotal.UseVisualStyleBackColor = true;
            this.btntotal.Click += new System.EventHandler(this.btntotal_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(672, 28);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // plogin
            // 
            this.plogin.Controls.Add(this.btnlogin);
            this.plogin.Controls.Add(this.lbpass);
            this.plogin.Controls.Add(this.lbuser);
            this.plogin.Controls.Add(this.tbpass);
            this.plogin.Controls.Add(this.tbuser);
            this.plogin.Controls.Add(this.lblogin);
            this.plogin.Location = new System.Drawing.Point(0, 81);
            this.plogin.Name = "plogin";
            this.plogin.Size = new System.Drawing.Size(894, 400);
            this.plogin.TabIndex = 0;
            // 
            // lblogin
            // 
            this.lblogin.AutoSize = true;
            this.lblogin.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblogin.Location = new System.Drawing.Point(409, 66);
            this.lblogin.Name = "lblogin";
            this.lblogin.Size = new System.Drawing.Size(115, 33);
            this.lblogin.TabIndex = 0;
            this.lblogin.Text = "Janji Jiwa";
            // 
            // tbuser
            // 
            this.tbuser.Location = new System.Drawing.Point(395, 152);
            this.tbuser.Name = "tbuser";
            this.tbuser.Size = new System.Drawing.Size(150, 20);
            this.tbuser.TabIndex = 1;
            // 
            // tbpass
            // 
            this.tbpass.Location = new System.Drawing.Point(395, 202);
            this.tbpass.Name = "tbpass";
            this.tbpass.PasswordChar = '*';
            this.tbpass.Size = new System.Drawing.Size(150, 20);
            this.tbpass.TabIndex = 2;
            // 
            // lbuser
            // 
            this.lbuser.AutoSize = true;
            this.lbuser.Location = new System.Drawing.Point(319, 155);
            this.lbuser.Name = "lbuser";
            this.lbuser.Size = new System.Drawing.Size(55, 13);
            this.lbuser.TabIndex = 3;
            this.lbuser.Text = "Username";
            this.lbuser.Click += new System.EventHandler(this.label6_Click);
            // 
            // lbpass
            // 
            this.lbpass.AutoSize = true;
            this.lbpass.Location = new System.Drawing.Point(319, 205);
            this.lbpass.Name = "lbpass";
            this.lbpass.Size = new System.Drawing.Size(53, 13);
            this.lbpass.TabIndex = 4;
            this.lbpass.Text = "Password";
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(470, 249);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(75, 23);
            this.btnlogin.TabIndex = 5;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // pbeli
            // 
            this.pbeli.Controls.Add(this.btnlogout);
            this.pbeli.Controls.Add(this.Label);
            this.pbeli.Controls.Add(this.btnupdate);
            this.pbeli.Controls.Add(this.dataGridView1);
            this.pbeli.Controls.Add(this.btntambah);
            this.pbeli.Location = new System.Drawing.Point(0, 81);
            this.pbeli.Name = "pbeli";
            this.pbeli.Size = new System.Drawing.Size(894, 403);
            this.pbeli.TabIndex = 0;
            this.pbeli.Visible = false;
            // 
            // btntambah
            // 
            this.btntambah.Location = new System.Drawing.Point(75, 249);
            this.btntambah.Name = "btntambah";
            this.btntambah.Size = new System.Drawing.Size(117, 65);
            this.btntambah.TabIndex = 0;
            this.btntambah.Text = "Tambah Barang";
            this.btntambah.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(522, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(333, 299);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(286, 249);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(117, 65);
            this.btnupdate.TabIndex = 2;
            this.btnupdate.Text = "Update Barang";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.button3_Click);
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.Location = new System.Drawing.Point(69, 55);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(150, 31);
            this.Label.TabIndex = 3;
            this.Label.Text = "Pembelian";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(125, 205);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(249, 173);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 30;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.Location = new System.Drawing.Point(780, 352);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(75, 23);
            this.btnlogout.TabIndex = 4;
            this.btnlogout.Text = "Logout";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btnlogout2
            // 
            this.btnlogout2.Location = new System.Drawing.Point(395, 66);
            this.btnlogout2.Name = "btnlogout2";
            this.btnlogout2.Size = new System.Drawing.Size(72, 61);
            this.btnlogout2.TabIndex = 36;
            this.btnlogout2.Text = "Logout";
            this.btnlogout2.UseVisualStyleBackColor = true;
            this.btnlogout2.Click += new System.EventHandler(this.btnlogout2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 485);
            this.Controls.Add(this.pmenu);
            this.Controls.Add(this.plogin);
            this.Controls.Add(this.pbeli);
            this.Controls.Add(this.ptransaksi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridkontak)).EndInit();
            this.ptransaksi.ResumeLayout(false);
            this.ptransaksi.PerformLayout();
            this.plogin.ResumeLayout(false);
            this.plogin.PerformLayout();
            this.pbeli.ResumeLayout(false);
            this.pbeli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbnama;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.DataGridView datagridkontak;
        private System.Windows.Forms.Panel pmenu;
        private System.Windows.Forms.Panel ptransaksi;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btntotal;
        private System.Windows.Forms.Button button1;
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
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Button btnlogout2;
        private System.Windows.Forms.Button btnlogout;

    }
}

