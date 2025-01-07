namespace _231116021_Mehmet_Selim_Erikli
{
    partial class frmMüsteriler
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnverilerigoster = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btnara = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.comboBoxCinsiyet = new System.Windows.Forms.ComboBox();
            this.btnkayıt = new System.Windows.Forms.Button();
            this.datecikisMusteriler = new System.Windows.Forms.DateTimePicker();
            this.dategirisMusteriler = new System.Windows.Forms.DateTimePicker();
            this.mskdtxttelefon = new System.Windows.Forms.MaskedTextBox();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.txttckimlik = new System.Windows.Forms.TextBox();
            this.txtücretMusteriler = new System.Windows.Forms.TextBox();
            this.txtodaNo = new System.Windows.Forms.TextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.ücretlabel = new System.Windows.Forms.Label();
            this.txtara = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 399);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1126, 217);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Adı";
            this.columnHeader2.Width = 113;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Soyadı";
            this.columnHeader3.Width = 110;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Cinsiyet";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Telefon";
            this.columnHeader5.Width = 118;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Mail";
            this.columnHeader6.Width = 181;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "TC";
            this.columnHeader7.Width = 110;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Oda No";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Ücret";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Giriş Tarihi";
            this.columnHeader10.Width = 122;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Çıkış Tarihi";
            this.columnHeader11.Width = 118;
            // 
            // btnverilerigoster
            // 
            this.btnverilerigoster.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnverilerigoster.Location = new System.Drawing.Point(936, 55);
            this.btnverilerigoster.Name = "btnverilerigoster";
            this.btnverilerigoster.Size = new System.Drawing.Size(152, 49);
            this.btnverilerigoster.TabIndex = 1;
            this.btnverilerigoster.Text = "Verileri Göster";
            this.btnverilerigoster.UseVisualStyleBackColor = true;
            this.btnverilerigoster.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguncelle.Location = new System.Drawing.Point(936, 128);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(152, 49);
            this.btnguncelle.TabIndex = 2;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btnara
            // 
            this.btnara.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnara.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnara.Location = new System.Drawing.Point(974, 340);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(114, 37);
            this.btnara.TabIndex = 2;
            this.btnara.Text = "Ara";
            this.btnara.UseVisualStyleBackColor = false;
            this.btnara.Click += new System.EventHandler(this.btnara_Click);
            // 
            // btnsil
            // 
            this.btnsil.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsil.Location = new System.Drawing.Point(936, 197);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(152, 49);
            this.btnsil.TabIndex = 2;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // comboBoxCinsiyet
            // 
            this.comboBoxCinsiyet.FormattingEnabled = true;
            this.comboBoxCinsiyet.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBoxCinsiyet.Location = new System.Drawing.Point(223, 142);
            this.comboBoxCinsiyet.Name = "comboBoxCinsiyet";
            this.comboBoxCinsiyet.Size = new System.Drawing.Size(137, 24);
            this.comboBoxCinsiyet.TabIndex = 43;
            // 
            // btnkayıt
            // 
            this.btnkayıt.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkayıt.Location = new System.Drawing.Point(715, 212);
            this.btnkayıt.Name = "btnkayıt";
            this.btnkayıt.Size = new System.Drawing.Size(127, 34);
            this.btnkayıt.TabIndex = 42;
            this.btnkayıt.Text = "Kayıt Yap";
            this.btnkayıt.UseVisualStyleBackColor = true;
            // 
            // datecikisMusteriler
            // 
            this.datecikisMusteriler.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datecikisMusteriler.Location = new System.Drawing.Point(673, 166);
            this.datecikisMusteriler.Name = "datecikisMusteriler";
            this.datecikisMusteriler.Size = new System.Drawing.Size(227, 28);
            this.datecikisMusteriler.TabIndex = 41;
            // 
            // dategirisMusteriler
            // 
            this.dategirisMusteriler.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dategirisMusteriler.Location = new System.Drawing.Point(673, 113);
            this.dategirisMusteriler.Name = "dategirisMusteriler";
            this.dategirisMusteriler.Size = new System.Drawing.Size(227, 28);
            this.dategirisMusteriler.TabIndex = 40;
            // 
            // mskdtxttelefon
            // 
            this.mskdtxttelefon.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskdtxttelefon.Location = new System.Drawing.Point(223, 178);
            this.mskdtxttelefon.Mask = "(999) 000-0000";
            this.mskdtxttelefon.Name = "mskdtxttelefon";
            this.mskdtxttelefon.Size = new System.Drawing.Size(227, 28);
            this.mskdtxttelefon.TabIndex = 39;
            // 
            // txtmail
            // 
            this.txtmail.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmail.Location = new System.Drawing.Point(223, 221);
            this.txtmail.Multiline = true;
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(227, 31);
            this.txtmail.TabIndex = 37;
            // 
            // txttckimlik
            // 
            this.txttckimlik.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttckimlik.Location = new System.Drawing.Point(223, 269);
            this.txttckimlik.MaxLength = 11;
            this.txttckimlik.Multiline = true;
            this.txttckimlik.Name = "txttckimlik";
            this.txttckimlik.Size = new System.Drawing.Size(227, 28);
            this.txttckimlik.TabIndex = 36;
            // 
            // txtücretMusteriler
            // 
            this.txtücretMusteriler.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtücretMusteriler.Location = new System.Drawing.Point(673, 58);
            this.txtücretMusteriler.Multiline = true;
            this.txtücretMusteriler.Name = "txtücretMusteriler";
            this.txtücretMusteriler.Size = new System.Drawing.Size(227, 31);
            this.txtücretMusteriler.TabIndex = 35;
            // 
            // txtodaNo
            // 
            this.txtodaNo.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtodaNo.Location = new System.Drawing.Point(223, 318);
            this.txtodaNo.Multiline = true;
            this.txtodaNo.Name = "txtodaNo";
            this.txtodaNo.ReadOnly = true;
            this.txtodaNo.Size = new System.Drawing.Size(227, 31);
            this.txtodaNo.TabIndex = 34;
            // 
            // txtsoyad
            // 
            this.txtsoyad.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsoyad.Location = new System.Drawing.Point(223, 98);
            this.txtsoyad.Multiline = true;
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(227, 30);
            this.txtsoyad.TabIndex = 38;
            // 
            // txtad
            // 
            this.txtad.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtad.Location = new System.Drawing.Point(223, 55);
            this.txtad.Multiline = true;
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(227, 27);
            this.txtad.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(489, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 20);
            this.label9.TabIndex = 31;
            this.label9.Text = "Toplam ücret";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(39, 321);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "Oda Numarası";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(489, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "Çıkış Tarihi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(489, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Giriş Tarihi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(39, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "TC Kimlik No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(39, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Mail";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Location = new System.Drawing.Point(39, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "Cinsiyet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(39, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Telefon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(39, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(39, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Ad";
            // 
            // btnTemizle
            // 
            this.btnTemizle.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemizle.Location = new System.Drawing.Point(936, 269);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(152, 46);
            this.btnTemizle.TabIndex = 44;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // ücretlabel
            // 
            this.ücretlabel.AutoSize = true;
            this.ücretlabel.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ücretlabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ücretlabel.Location = new System.Drawing.Point(670, 92);
            this.ücretlabel.Name = "ücretlabel";
            this.ücretlabel.Size = new System.Drawing.Size(18, 17);
            this.ücretlabel.TabIndex = 45;
            this.ücretlabel.Text = "0";
            this.ücretlabel.Visible = false;
            // 
            // txtara
            // 
            this.txtara.Location = new System.Drawing.Point(728, 346);
            this.txtara.Multiline = true;
            this.txtara.Name = "txtara";
            this.txtara.Size = new System.Drawing.Size(227, 31);
            this.txtara.TabIndex = 46;
            // 
            // frmMüsteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(1150, 640);
            this.Controls.Add(this.txtara);
            this.Controls.Add(this.ücretlabel);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.comboBoxCinsiyet);
            this.Controls.Add(this.btnkayıt);
            this.Controls.Add(this.datecikisMusteriler);
            this.Controls.Add(this.dategirisMusteriler);
            this.Controls.Add(this.mskdtxttelefon);
            this.Controls.Add(this.txtmail);
            this.Controls.Add(this.txttckimlik);
            this.Controls.Add(this.txtücretMusteriler);
            this.Controls.Add(this.txtodaNo);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnara);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.btnverilerigoster);
            this.Controls.Add(this.listView1);
            this.Name = "frmMüsteriler";
            this.Text = "Müşteri Bilgileri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Button btnverilerigoster;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btnara;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.ComboBox comboBoxCinsiyet;
        private System.Windows.Forms.Button btnkayıt;
        private System.Windows.Forms.DateTimePicker datecikisMusteriler;
        private System.Windows.Forms.DateTimePicker dategirisMusteriler;
        private System.Windows.Forms.MaskedTextBox mskdtxttelefon;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.TextBox txttckimlik;
        private System.Windows.Forms.TextBox txtücretMusteriler;
        private System.Windows.Forms.TextBox txtodaNo;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Label ücretlabel;
        private System.Windows.Forms.TextBox txtara;
    }
}