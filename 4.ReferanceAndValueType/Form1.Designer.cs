
namespace _4.ReferanceAndValueType
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
            this.btn_Reference = new System.Windows.Forms.Button();
            this.btnValue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Reference
            // 
            this.btn_Reference.Location = new System.Drawing.Point(478, 12);
            this.btn_Reference.Name = "btn_Reference";
            this.btn_Reference.Size = new System.Drawing.Size(259, 171);
            this.btn_Reference.TabIndex = 0;
            this.btn_Reference.Text = "ReferenceType";
            this.btn_Reference.UseVisualStyleBackColor = true;
            this.btn_Reference.Click += new System.EventHandler(this.btn_Reference_Click);
            // 
            // btnValue
            // 
            this.btnValue.Location = new System.Drawing.Point(0, 12);
            this.btnValue.Name = "btnValue";
            this.btnValue.Size = new System.Drawing.Size(472, 171);
            this.btnValue.TabIndex = 0;
            this.btnValue.Text = "ValueType";
            this.btnValue.UseVisualStyleBackColor = true;
            this.btnValue.Click += new System.EventHandler(this.btnValue_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 516);
            this.Controls.Add(this.btnValue);
            this.Controls.Add(this.btn_Reference);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Reference;
        private System.Windows.Forms.Button btnValue;
    }
}

