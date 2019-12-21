namespace WindowsFormsApplication3
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
            this.button1 = new System.Windows.Forms.Button();
            this.btntotal = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagridkontak)).BeginInit();
            this.ptransaksi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(624, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbnama
            // 
            this.tbnama.Location = new System.Drawing.Point(675, 77);
            this.tbnama.Multiline = true;
            this.tbnama.Name = "tbnama";
            this.tbnama.Size = new System.Drawing.Size(199, 28);
            this.tbnama.TabIndex = 5;
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(501, 190);
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
            this.datagridkontak.Location = new System.Drawing.Point(501, 219);
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
            this.ptransaksi.Paint += new System.Windows.Forms.PaintEventHandler(this.ptransaksi_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(582, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Cetak";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btntotal
            // 
            this.btntotal.Location = new System.Drawing.Point(799, 111);
            this.btntotal.Name = "btntotal";
            this.btntotal.Size = new System.Drawing.Size(75, 37);
            this.btntotal.TabIndex = 19;
            this.btntotal.Text = "total";
            this.btntotal.UseVisualStyleBackColor = true;
            this.btntotal.Click += new System.EventHandler(this.btntotal_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(674, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "cappucino",
            "espresso"});
            this.comboBox1.Location = new System.Drawing.Point(99, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(133, 21);
            this.comboBox1.TabIndex = 29;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(173, 219);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(249, 173);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 30;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 485);
            this.Controls.Add(this.ptransaksi);
            this.Controls.Add(this.pmenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridkontak)).EndInit();
            this.ptransaksi.ResumeLayout(false);
            this.ptransaksi.PerformLayout();
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

    }
}

