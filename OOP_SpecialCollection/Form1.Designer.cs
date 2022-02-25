
namespace OOP_SpecialCollection
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
            this.btnHashTable = new System.Windows.Forms.Button();
            this.btnHybridDictionry = new System.Windows.Forms.Button();
            this.btn_listDicttionary = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnHashTable
            // 
            this.btnHashTable.Location = new System.Drawing.Point(13, 3);
            this.btnHashTable.Name = "btnHashTable";
            this.btnHashTable.Size = new System.Drawing.Size(836, 23);
            this.btnHashTable.TabIndex = 0;
            this.btnHashTable.Text = "HashTable";
            this.btnHashTable.UseVisualStyleBackColor = true;
            this.btnHashTable.Click += new System.EventHandler(this.btnHashTable_Click);
            // 
            // btnHybridDictionry
            // 
            this.btnHybridDictionry.Location = new System.Drawing.Point(12, 61);
            this.btnHybridDictionry.Name = "btnHybridDictionry";
            this.btnHybridDictionry.Size = new System.Drawing.Size(836, 26);
            this.btnHybridDictionry.TabIndex = 0;
            this.btnHybridDictionry.Text = "HybridDictionary";
            this.btnHybridDictionry.UseVisualStyleBackColor = true;
            this.btnHybridDictionry.Click += new System.EventHandler(this.btnHybridDictionry_Click);
            // 
            // btn_listDicttionary
            // 
            this.btn_listDicttionary.Location = new System.Drawing.Point(13, 32);
            this.btn_listDicttionary.Name = "btn_listDicttionary";
            this.btn_listDicttionary.Size = new System.Drawing.Size(836, 23);
            this.btn_listDicttionary.TabIndex = 0;
            this.btn_listDicttionary.Text = "listDicttionary";
            this.btn_listDicttionary.UseVisualStyleBackColor = true;
            this.btn_listDicttionary.Click += new System.EventHandler(this.btn_listDicttionary_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(13, 93);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(835, 356);
            this.listBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 488);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_listDicttionary);
            this.Controls.Add(this.btnHybridDictionry);
            this.Controls.Add(this.btnHashTable);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHashTable;
        private System.Windows.Forms.Button btnHybridDictionry;
        private System.Windows.Forms.Button btn_listDicttionary;
        private System.Windows.Forms.ListBox listBox1;
    }
}

