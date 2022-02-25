
namespace oop_Enum
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Enum = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnEnumDeger = new System.Windows.Forms.Button();
            this.btnKontrolluEnum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sayı Gİriniz.";
            // 
            // txt_Enum
            // 
            this.txt_Enum.Location = new System.Drawing.Point(101, 6);
            this.txt_Enum.Name = "txt_Enum";
            this.txt_Enum.Size = new System.Drawing.Size(163, 22);
            this.txt_Enum.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(270, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(148, 228);
            this.listBox1.TabIndex = 2;
            // 
            // btnEnumDeger
            // 
            this.btnEnumDeger.Location = new System.Drawing.Point(101, 35);
            this.btnEnumDeger.Name = "btnEnumDeger";
            this.btnEnumDeger.Size = new System.Drawing.Size(163, 43);
            this.btnEnumDeger.TabIndex = 3;
            this.btnEnumDeger.Text = "EnumDeğeri";
            this.btnEnumDeger.UseVisualStyleBackColor = true;
            this.btnEnumDeger.Click += new System.EventHandler(this.btnEnumDeger_Click);
            // 
            // btnKontrolluEnum
            // 
            this.btnKontrolluEnum.Location = new System.Drawing.Point(101, 84);
            this.btnKontrolluEnum.Name = "btnKontrolluEnum";
            this.btnKontrolluEnum.Size = new System.Drawing.Size(163, 53);
            this.btnKontrolluEnum.TabIndex = 3;
            this.btnKontrolluEnum.Text = "KontrolluEnum";
            this.btnKontrolluEnum.UseVisualStyleBackColor = true;
            this.btnKontrolluEnum.Click += new System.EventHandler(this.btnKontrolluEnum_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKontrolluEnum);
            this.Controls.Add(this.btnEnumDeger);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txt_Enum);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Enum;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnEnumDeger;
        private System.Windows.Forms.Button btnKontrolluEnum;
    }
}