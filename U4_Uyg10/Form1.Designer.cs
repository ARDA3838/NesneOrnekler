﻿
namespace U4_Uyg10
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
            this.button_ekle = new System.Windows.Forms.Button();
            this.txt_SehirAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_ekle
            // 
            this.button_ekle.Location = new System.Drawing.Point(213, 31);
            this.button_ekle.Name = "button_ekle";
            this.button_ekle.Size = new System.Drawing.Size(75, 23);
            this.button_ekle.TabIndex = 0;
            this.button_ekle.Text = "ekle";
            this.button_ekle.UseVisualStyleBackColor = true;
            this.button_ekle.Click += new System.EventHandler(this.button_ekle_Click);
            // 
            // txt_SehirAdi
            // 
            this.txt_SehirAdi.Location = new System.Drawing.Point(90, 31);
            this.txt_SehirAdi.Name = "txt_SehirAdi";
            this.txt_SehirAdi.Size = new System.Drawing.Size(100, 20);
            this.txt_SehirAdi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "SEHİR ADİ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 86);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_SehirAdi);
            this.Controls.Add(this.button_ekle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_ekle;
        private System.Windows.Forms.TextBox txt_SehirAdi;
        private System.Windows.Forms.Label label1;
    }
}

