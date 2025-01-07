namespace _231116021_Mehmet_Selim_Erikli
{
    partial class frmSifreGuncelle
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtparolaguncelle = new System.Windows.Forms.TextBox();
            this.txtkullaniciadiguncelle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnguncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_231116021_Mehmet_Selim_Erikli.Properties.Resources.Ekran_görüntüsü_2024_12_07_173330;
            this.pictureBox1.Location = new System.Drawing.Point(187, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(443, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // txtparolaguncelle
            // 
            this.txtparolaguncelle.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtparolaguncelle.Font = new System.Drawing.Font("Century", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtparolaguncelle.Location = new System.Drawing.Point(369, 354);
            this.txtparolaguncelle.Multiline = true;
            this.txtparolaguncelle.Name = "txtparolaguncelle";
            this.txtparolaguncelle.Size = new System.Drawing.Size(261, 33);
            this.txtparolaguncelle.TabIndex = 6;
            this.txtparolaguncelle.Text = "parolanızı girin";
            this.txtparolaguncelle.UseSystemPasswordChar = true;
            // 
            // txtkullaniciadiguncelle
            // 
            this.txtkullaniciadiguncelle.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtkullaniciadiguncelle.Font = new System.Drawing.Font("Century", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkullaniciadiguncelle.Location = new System.Drawing.Point(369, 295);
            this.txtkullaniciadiguncelle.Multiline = true;
            this.txtkullaniciadiguncelle.Name = "txtkullaniciadiguncelle";
            this.txtkullaniciadiguncelle.Size = new System.Drawing.Size(261, 33);
            this.txtkullaniciadiguncelle.TabIndex = 7;
            this.txtkullaniciadiguncelle.Text = "kullanıcı adı girin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Castellar", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(171, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Parola";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Castellar", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // btnguncelle
            // 
            this.btnguncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(139)))));
            this.btnguncelle.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguncelle.ForeColor = System.Drawing.Color.Gold;
            this.btnguncelle.Location = new System.Drawing.Point(369, 421);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(246, 40);
            this.btnguncelle.TabIndex = 10;
            this.btnguncelle.Text = "Günclle";
            this.btnguncelle.UseVisualStyleBackColor = false;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // frmSifreGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 545);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtparolaguncelle);
            this.Controls.Add(this.txtkullaniciadiguncelle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSifreGuncelle";
            this.Text = "frmSifreGuncelle";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtparolaguncelle;
        private System.Windows.Forms.TextBox txtkullaniciadiguncelle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnguncelle;
    }
}