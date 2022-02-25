
namespace IEnumerable__IEnumerator_Kullanimlari
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
            this.btnGetir = new System.Windows.Forms.Button();
            this.lstTopcular = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnGetir
            // 
            this.btnGetir.Location = new System.Drawing.Point(13, 13);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(775, 37);
            this.btnGetir.TabIndex = 0;
            this.btnGetir.Text = "Takım Oyuncularini Getir";
            this.btnGetir.UseVisualStyleBackColor = true;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // lstTopcular
            // 
            this.lstTopcular.FormattingEnabled = true;
            this.lstTopcular.ItemHeight = 16;
            this.lstTopcular.Location = new System.Drawing.Point(13, 57);
            this.lstTopcular.Name = "lstTopcular";
            this.lstTopcular.Size = new System.Drawing.Size(775, 356);
            this.lstTopcular.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstTopcular);
            this.Controls.Add(this.btnGetir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.ListBox lstTopcular;
    }
}

