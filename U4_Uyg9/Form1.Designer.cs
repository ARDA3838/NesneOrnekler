
namespace U4_Uyg9
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
            this.textBox_diziSayisi = new System.Windows.Forms.TextBox();
            this.textBox_sutunSayisi = new System.Windows.Forms.TextBox();
            this.textBox_enDusuk = new System.Windows.Forms.TextBox();
            this.textBox_enBuyuk = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_DiziOlustur = new System.Windows.Forms.Button();
            this.button_DiziGoster = new System.Windows.Forms.Button();
            this.listBox_DiziGöster = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBox_diziSayisi
            // 
            this.textBox_diziSayisi.Location = new System.Drawing.Point(139, 15);
            this.textBox_diziSayisi.Name = "textBox_diziSayisi";
            this.textBox_diziSayisi.Size = new System.Drawing.Size(59, 20);
            this.textBox_diziSayisi.TabIndex = 0;
            // 
            // textBox_sutunSayisi
            // 
            this.textBox_sutunSayisi.Location = new System.Drawing.Point(139, 42);
            this.textBox_sutunSayisi.Name = "textBox_sutunSayisi";
            this.textBox_sutunSayisi.Size = new System.Drawing.Size(59, 20);
            this.textBox_sutunSayisi.TabIndex = 1;
            // 
            // textBox_enDusuk
            // 
            this.textBox_enDusuk.Location = new System.Drawing.Point(139, 68);
            this.textBox_enDusuk.Name = "textBox_enDusuk";
            this.textBox_enDusuk.Size = new System.Drawing.Size(59, 20);
            this.textBox_enDusuk.TabIndex = 2;
            // 
            // textBox_enBuyuk
            // 
            this.textBox_enBuyuk.Location = new System.Drawing.Point(139, 95);
            this.textBox_enBuyuk.Name = "textBox_enBuyuk";
            this.textBox_enBuyuk.Size = new System.Drawing.Size(59, 20);
            this.textBox_enBuyuk.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dizi Sayısı Satırı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Dizi Sütun Sayısı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Rastgeke En Düşük Sayı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Rasggele En Büyük Sayı";
            // 
            // button_DiziOlustur
            // 
            this.button_DiziOlustur.Location = new System.Drawing.Point(47, 131);
            this.button_DiziOlustur.Name = "button_DiziOlustur";
            this.button_DiziOlustur.Size = new System.Drawing.Size(100, 29);
            this.button_DiziOlustur.TabIndex = 8;
            this.button_DiziOlustur.Text = "Dizi Oluştur";
            this.button_DiziOlustur.UseVisualStyleBackColor = true;
            this.button_DiziOlustur.Click += new System.EventHandler(this.button_DiziOlustur_Click);
            // 
            // button_DiziGoster
            // 
            this.button_DiziGoster.Location = new System.Drawing.Point(270, 7);
            this.button_DiziGoster.Name = "button_DiziGoster";
            this.button_DiziGoster.Size = new System.Drawing.Size(88, 28);
            this.button_DiziGoster.TabIndex = 9;
            this.button_DiziGoster.Text = "Dizi Göster";
            this.button_DiziGoster.UseVisualStyleBackColor = true;
            this.button_DiziGoster.Click += new System.EventHandler(this.button_DiziGoster_Click);
            // 
            // listBox_DiziGöster
            // 
            this.listBox_DiziGöster.FormattingEnabled = true;
            this.listBox_DiziGöster.Location = new System.Drawing.Point(250, 45);
            this.listBox_DiziGöster.Name = "listBox_DiziGöster";
            this.listBox_DiziGöster.Size = new System.Drawing.Size(128, 121);
            this.listBox_DiziGöster.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 198);
            this.Controls.Add(this.listBox_DiziGöster);
            this.Controls.Add(this.button_DiziGoster);
            this.Controls.Add(this.button_DiziOlustur);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_enBuyuk);
            this.Controls.Add(this.textBox_enDusuk);
            this.Controls.Add(this.textBox_sutunSayisi);
            this.Controls.Add(this.textBox_diziSayisi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_diziSayisi;
        private System.Windows.Forms.TextBox textBox_sutunSayisi;
        private System.Windows.Forms.TextBox textBox_enDusuk;
        private System.Windows.Forms.TextBox textBox_enBuyuk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_DiziOlustur;
        private System.Windows.Forms.Button button_DiziGoster;
        private System.Windows.Forms.ListBox listBox_DiziGöster;
    }
}

