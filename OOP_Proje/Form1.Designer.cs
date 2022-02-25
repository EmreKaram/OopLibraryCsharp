
namespace OOP_Proje
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTel = new System.Windows.Forms.MaskedTextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnResimSec = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbUnvan = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtisegiristarihi = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtDogumTarih = new System.Windows.Forms.DateTimePicker();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.txtTcKimlikNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTel);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.btnResimSec);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.cmbUnvan);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dtisegiristarihi);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dtDogumTarih);
            this.groupBox1.Controls.Add(this.txtAdres);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.TxtAd);
            this.groupBox1.Controls.Add(this.txtTcKimlikNo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1256, 416);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Bilgileri";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(105, 228);
            this.txtTel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTel.Mask = "(999) 000-0000";
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(226, 26);
            this.txtTel.TabIndex = 14;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(709, 309);
            this.btnSil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(187, 41);
            this.btnSil.TabIndex = 13;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(709, 250);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(187, 41);
            this.btnGuncelle.TabIndex = 12;
            this.btnGuncelle.Text = "Guncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(709, 199);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(187, 44);
            this.btnEkle.TabIndex = 11;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnResimSec
            // 
            this.btnResimSec.Location = new System.Drawing.Point(709, 136);
            this.btnResimSec.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnResimSec.Name = "btnResimSec";
            this.btnResimSec.Size = new System.Drawing.Size(187, 44);
            this.btnResimSec.TabIndex = 10;
            this.btnResimSec.Text = "ResimSec";
            this.btnResimSec.UseVisualStyleBackColor = true;
            this.btnResimSec.Click += new System.EventHandler(this.btnResimSec_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(466, 136);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 204);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // cmbUnvan
            // 
            this.cmbUnvan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnvan.FormattingEnabled = true;
            this.cmbUnvan.Location = new System.Drawing.Point(742, 81);
            this.cmbUnvan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbUnvan.Name = "cmbUnvan";
            this.cmbUnvan.Size = new System.Drawing.Size(224, 28);
            this.cmbUnvan.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(657, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Unvan";
            // 
            // dtisegiristarihi
            // 
            this.dtisegiristarihi.Location = new System.Drawing.Point(742, 41);
            this.dtisegiristarihi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtisegiristarihi.Name = "dtisegiristarihi";
            this.dtisegiristarihi.Size = new System.Drawing.Size(224, 26);
            this.dtisegiristarihi.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(603, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "İşe Giriş Tarihi";
            // 
            // dtDogumTarih
            // 
            this.dtDogumTarih.Location = new System.Drawing.Point(107, 166);
            this.dtDogumTarih.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtDogumTarih.Name = "dtDogumTarih";
            this.dtDogumTarih.Size = new System.Drawing.Size(224, 26);
            this.dtDogumTarih.TabIndex = 4;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(112, 350);
            this.txtAdres.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(226, 26);
            this.txtAdres.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(112, 312);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(226, 26);
            this.txtEmail.TabIndex = 6;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(106, 114);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(226, 26);
            this.txtSoyad.TabIndex = 3;
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(106, 79);
            this.TxtAd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(226, 26);
            this.TxtAd.TabIndex = 2;
            // 
            // txtTcKimlikNo
            // 
            this.txtTcKimlikNo.Location = new System.Drawing.Point(106, 44);
            this.txtTcKimlikNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTcKimlikNo.Name = "txtTcKimlikNo";
            this.txtTcKimlikNo.Size = new System.Drawing.Size(226, 26);
            this.txtTcKimlikNo.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 356);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Adres";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Telefon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Dogum Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Soyad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tc KimlikNo";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(15, 441);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1255, 265);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tc KimlikNo";
            this.columnHeader1.Width = 119;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ad";
            this.columnHeader2.Width = 155;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Soyad";
            this.columnHeader3.Width = 152;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "İse Giris";
            this.columnHeader4.Width = 177;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Telefon";
            this.columnHeader5.Width = 216;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Email";
            this.columnHeader6.Width = 255;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 722);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnResimSec;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbUnvan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtisegiristarihi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtDogumTarih;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.TextBox txtTcKimlikNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.MaskedTextBox txtTel;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

