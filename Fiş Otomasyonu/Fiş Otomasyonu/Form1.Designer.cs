
namespace Fiş_Otomasyonu
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
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lbl_shopping_name = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_depart_no = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.txtBox_shopping_name = new System.Windows.Forms.TextBox();
            this.txtBox_total = new System.Windows.Forms.TextBox();
            this.txtBox_depart_no = new System.Windows.Forms.TextBox();
            this.txtBox_Date = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(435, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = "convert to text";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(3, 75);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(435, 449);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lbl_shopping_name
            // 
            this.lbl_shopping_name.AutoSize = true;
            this.lbl_shopping_name.Location = new System.Drawing.Point(444, 96);
            this.lbl_shopping_name.Name = "lbl_shopping_name";
            this.lbl_shopping_name.Size = new System.Drawing.Size(63, 13);
            this.lbl_shopping_name.TabIndex = 2;
            this.lbl_shopping_name.Text = "Mağaza Adı";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(444, 167);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(66, 13);
            this.lbl_total.TabIndex = 3;
            this.lbl_total.Text = "Toplam tutar";
            // 
            // lbl_depart_no
            // 
            this.lbl_depart_no.AutoSize = true;
            this.lbl_depart_no.Location = new System.Drawing.Point(444, 235);
            this.lbl_depart_no.Name = "lbl_depart_no";
            this.lbl_depart_no.Size = new System.Drawing.Size(78, 13);
            this.lbl_depart_no.TabIndex = 4;
            this.lbl_depart_no.Text = "Vergi Numarası";
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Location = new System.Drawing.Point(444, 284);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(31, 13);
            this.lbl_Date.TabIndex = 5;
            this.lbl_Date.Text = "Tarih";
            // 
            // txtBox_shopping_name
            // 
            this.txtBox_shopping_name.Location = new System.Drawing.Point(444, 112);
            this.txtBox_shopping_name.Name = "txtBox_shopping_name";
            this.txtBox_shopping_name.Size = new System.Drawing.Size(100, 20);
            this.txtBox_shopping_name.TabIndex = 6;
            // 
            // txtBox_total
            // 
            this.txtBox_total.Location = new System.Drawing.Point(447, 183);
            this.txtBox_total.Name = "txtBox_total";
            this.txtBox_total.Size = new System.Drawing.Size(100, 20);
            this.txtBox_total.TabIndex = 6;
            // 
            // txtBox_depart_no
            // 
            this.txtBox_depart_no.Location = new System.Drawing.Point(447, 251);
            this.txtBox_depart_no.Name = "txtBox_depart_no";
            this.txtBox_depart_no.Size = new System.Drawing.Size(100, 20);
            this.txtBox_depart_no.TabIndex = 6;
            // 
            // txtBox_Date
            // 
            this.txtBox_Date.Location = new System.Drawing.Point(447, 300);
            this.txtBox_Date.Name = "txtBox_Date";
            this.txtBox_Date.Size = new System.Drawing.Size(100, 20);
            this.txtBox_Date.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 527);
            this.Controls.Add(this.txtBox_Date);
            this.Controls.Add(this.txtBox_depart_no);
            this.Controls.Add(this.txtBox_total);
            this.Controls.Add(this.txtBox_shopping_name);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.lbl_depart_no);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.lbl_shopping_name);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lbl_shopping_name;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_depart_no;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.TextBox txtBox_shopping_name;
        private System.Windows.Forms.TextBox txtBox_total;
        private System.Windows.Forms.TextBox txtBox_depart_no;
        private System.Windows.Forms.TextBox txtBox_Date;
    }
}

