
namespace U5_Uyg24
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
            this.OgrenciBilgileri = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDersNotu = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtNumara = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.gridListe = new System.Windows.Forms.DataGridView();
            this.OgrenciBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridListe)).BeginInit();
            this.SuspendLayout();
            // 
            // OgrenciBilgileri
            // 
            this.OgrenciBilgileri.Controls.Add(this.label3);
            this.OgrenciBilgileri.Controls.Add(this.label2);
            this.OgrenciBilgileri.Controls.Add(this.label1);
            this.OgrenciBilgileri.Controls.Add(this.txtDersNotu);
            this.OgrenciBilgileri.Controls.Add(this.txtAdSoyad);
            this.OgrenciBilgileri.Controls.Add(this.txtNumara);
            this.OgrenciBilgileri.Controls.Add(this.btnEkle);
            this.OgrenciBilgileri.Location = new System.Drawing.Point(25, 27);
            this.OgrenciBilgileri.Name = "OgrenciBilgileri";
            this.OgrenciBilgileri.Size = new System.Drawing.Size(256, 215);
            this.OgrenciBilgileri.TabIndex = 0;
            this.OgrenciBilgileri.TabStop = false;
            this.OgrenciBilgileri.Text = "Ogrenci Bilgileri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ders Notu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ad Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Numara";
            // 
            // txtDersNotu
            // 
            this.txtDersNotu.Location = new System.Drawing.Point(84, 112);
            this.txtDersNotu.Name = "txtDersNotu";
            this.txtDersNotu.Size = new System.Drawing.Size(147, 20);
            this.txtDersNotu.TabIndex = 3;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(84, 71);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(147, 20);
            this.txtAdSoyad.TabIndex = 2;
            // 
            // txtNumara
            // 
            this.txtNumara.Location = new System.Drawing.Point(84, 34);
            this.txtNumara.Name = "txtNumara";
            this.txtNumara.Size = new System.Drawing.Size(147, 20);
            this.txtNumara.TabIndex = 1;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(49, 164);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(104, 38);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // gridListe
            // 
            this.gridListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridListe.Location = new System.Drawing.Point(304, 27);
            this.gridListe.Name = "gridListe";
            this.gridListe.Size = new System.Drawing.Size(376, 215);
            this.gridListe.TabIndex = 1;
            this.gridListe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridListe_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 301);
            this.Controls.Add(this.gridListe);
            this.Controls.Add(this.OgrenciBilgileri);
            this.Name = "Form1";
            this.Text = "Form1";
            this.OgrenciBilgileri.ResumeLayout(false);
            this.OgrenciBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridListe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox OgrenciBilgileri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDersNotu;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtNumara;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DataGridView gridListe;
    }
}

