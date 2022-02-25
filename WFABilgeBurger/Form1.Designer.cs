
namespace WFABilgeBurger
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lstSiparisler = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMenuler = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbOrta = new System.Windows.Forms.RadioButton();
            this.rbBuyuk = new System.Windows.Forms.RadioButton();
            this.rbKucuk = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.flpExtraMalzemeler = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.nmrAdet = new System.Windows.Forms.NumericUpDown();
            this.btnSiparisEkle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.btnSiparisTamamla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WFABilgeBurger.Properties.Resources.indir;
            this.pictureBox1.Location = new System.Drawing.Point(34, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 182);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lstSiparisler
            // 
            this.lstSiparisler.FormattingEnabled = true;
            this.lstSiparisler.ItemHeight = 16;
            this.lstSiparisler.Location = new System.Drawing.Point(321, 0);
            this.lstSiparisler.Name = "lstSiparisler";
            this.lstSiparisler.Size = new System.Drawing.Size(811, 436);
            this.lstSiparisler.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Menü Seciniz";
            // 
            // cbMenuler
            // 
            this.cbMenuler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMenuler.FormattingEnabled = true;
            this.cbMenuler.Location = new System.Drawing.Point(9, 217);
            this.cbMenuler.Name = "cbMenuler";
            this.cbMenuler.Size = new System.Drawing.Size(273, 24);
            this.cbMenuler.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbOrta);
            this.groupBox1.Controls.Add(this.rbBuyuk);
            this.groupBox1.Controls.Add(this.rbKucuk);
            this.groupBox1.Location = new System.Drawing.Point(9, 264);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 58);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Boyut Seçiniz";
            // 
            // rbOrta
            // 
            this.rbOrta.AutoSize = true;
            this.rbOrta.Location = new System.Drawing.Point(98, 21);
            this.rbOrta.Name = "rbOrta";
            this.rbOrta.Size = new System.Drawing.Size(57, 21);
            this.rbOrta.TabIndex = 0;
            this.rbOrta.TabStop = true;
            this.rbOrta.Text = "Orta";
            this.rbOrta.UseVisualStyleBackColor = true;
            // 
            // rbBuyuk
            // 
            this.rbBuyuk.AutoSize = true;
            this.rbBuyuk.Location = new System.Drawing.Point(198, 21);
            this.rbBuyuk.Name = "rbBuyuk";
            this.rbBuyuk.Size = new System.Drawing.Size(68, 21);
            this.rbBuyuk.TabIndex = 0;
            this.rbBuyuk.TabStop = true;
            this.rbBuyuk.Text = "Büyük";
            this.rbBuyuk.UseVisualStyleBackColor = true;
            // 
            // rbKucuk
            // 
            this.rbKucuk.AutoSize = true;
            this.rbKucuk.Location = new System.Drawing.Point(6, 22);
            this.rbKucuk.Name = "rbKucuk";
            this.rbKucuk.Size = new System.Drawing.Size(68, 21);
            this.rbKucuk.TabIndex = 0;
            this.rbKucuk.TabStop = true;
            this.rbKucuk.Text = "Küçük";
            this.rbKucuk.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Extra Malzemeler";
            // 
            // flpExtraMalzemeler
            // 
            this.flpExtraMalzemeler.Location = new System.Drawing.Point(9, 346);
            this.flpExtraMalzemeler.Name = "flpExtraMalzemeler";
            this.flpExtraMalzemeler.Size = new System.Drawing.Size(303, 126);
            this.flpExtraMalzemeler.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 479);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Adet:";
            // 
            // nmrAdet
            // 
            this.nmrAdet.Location = new System.Drawing.Point(56, 479);
            this.nmrAdet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrAdet.Name = "nmrAdet";
            this.nmrAdet.Size = new System.Drawing.Size(256, 22);
            this.nmrAdet.TabIndex = 8;
            this.nmrAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnSiparisEkle
            // 
            this.btnSiparisEkle.Location = new System.Drawing.Point(9, 518);
            this.btnSiparisEkle.Name = "btnSiparisEkle";
            this.btnSiparisEkle.Size = new System.Drawing.Size(303, 37);
            this.btnSiparisEkle.TabIndex = 9;
            this.btnSiparisEkle.Text = "Sipariş Ekle";
            this.btnSiparisEkle.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(368, 455);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "ToplamTutar";
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Location = new System.Drawing.Point(463, 455);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(37, 17);
            this.lblToplamTutar.TabIndex = 11;
            this.lblToplamTutar.Text = "0 TL";
            // 
            // btnSiparisTamamla
            // 
            this.btnSiparisTamamla.Location = new System.Drawing.Point(833, 518);
            this.btnSiparisTamamla.Name = "btnSiparisTamamla";
            this.btnSiparisTamamla.Size = new System.Drawing.Size(252, 37);
            this.btnSiparisTamamla.TabIndex = 12;
            this.btnSiparisTamamla.Text = "Siparis Tamamla";
            this.btnSiparisTamamla.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 615);
            this.Controls.Add(this.btnSiparisTamamla);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSiparisEkle);
            this.Controls.Add(this.nmrAdet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.flpExtraMalzemeler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbMenuler);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstSiparisler);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox lstSiparisler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMenuler;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbOrta;
        private System.Windows.Forms.RadioButton rbBuyuk;
        private System.Windows.Forms.RadioButton rbKucuk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flpExtraMalzemeler;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nmrAdet;
        private System.Windows.Forms.Button btnSiparisEkle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Button btnSiparisTamamla;
    }
}

