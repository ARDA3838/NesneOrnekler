﻿
namespace U4_Uyg11
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_SehirAdi = new System.Windows.Forms.TextBox();
            this.button_ekle = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button_listele = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "SEHİR ADİ";
            // 
            // txt_SehirAdi
            // 
            this.txt_SehirAdi.Location = new System.Drawing.Point(88, 21);
            this.txt_SehirAdi.Name = "txt_SehirAdi";
            this.txt_SehirAdi.Size = new System.Drawing.Size(100, 20);
            this.txt_SehirAdi.TabIndex = 4;
            // 
            // button_ekle
            // 
            this.button_ekle.Location = new System.Drawing.Point(211, 21);
            this.button_ekle.Name = "button_ekle";
            this.button_ekle.Size = new System.Drawing.Size(75, 23);
            this.button_ekle.TabIndex = 3;
            this.button_ekle.Text = "ekle";
            this.button_ekle.UseVisualStyleBackColor = true;
            this.button_ekle.Click += new System.EventHandler(this.button_ekle_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(313, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 160);
            this.listBox1.TabIndex = 6;
            // 
            // button_listele
            // 
            this.button_listele.Location = new System.Drawing.Point(211, 125);
            this.button_listele.Name = "button_listele";
            this.button_listele.Size = new System.Drawing.Size(75, 28);
            this.button_listele.TabIndex = 7;
            this.button_listele.Text = "listele";
            this.button_listele.UseVisualStyleBackColor = true;
            this.button_listele.Click += new System.EventHandler(this.button_listele_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 338);
            this.Controls.Add(this.button_listele);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_SehirAdi);
            this.Controls.Add(this.button_ekle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_SehirAdi;
        private System.Windows.Forms.Button button_ekle;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button_listele;
    }
}

