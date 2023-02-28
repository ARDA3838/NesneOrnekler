
namespace U4_Uyg5
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
            this.dizioluştur_btn = new System.Windows.Forms.Button();
            this.listBox_dizioluştur = new System.Windows.Forms.ListBox();
            this.listBox_dizikopyala = new System.Windows.Forms.ListBox();
            this.dizikopyala_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dizioluştur_btn
            // 
            this.dizioluştur_btn.Location = new System.Drawing.Point(12, 90);
            this.dizioluştur_btn.Name = "dizioluştur_btn";
            this.dizioluştur_btn.Size = new System.Drawing.Size(86, 37);
            this.dizioluştur_btn.TabIndex = 0;
            this.dizioluştur_btn.Text = "dizi oluştur";
            this.dizioluştur_btn.UseVisualStyleBackColor = true;
            this.dizioluştur_btn.Click += new System.EventHandler(this.dizioluştur_btn_Click);
            // 
            // listBox_dizioluştur
            // 
            this.listBox_dizioluştur.FormattingEnabled = true;
            this.listBox_dizioluştur.Location = new System.Drawing.Point(120, 26);
            this.listBox_dizioluştur.Name = "listBox_dizioluştur";
            this.listBox_dizioluştur.Size = new System.Drawing.Size(120, 251);
            this.listBox_dizioluştur.TabIndex = 1;
            // 
            // listBox_dizikopyala
            // 
            this.listBox_dizikopyala.FormattingEnabled = true;
            this.listBox_dizikopyala.Location = new System.Drawing.Point(444, 26);
            this.listBox_dizikopyala.Name = "listBox_dizikopyala";
            this.listBox_dizikopyala.Size = new System.Drawing.Size(120, 251);
            this.listBox_dizikopyala.TabIndex = 2;
            // 
            // dizikopyala_btn
            // 
            this.dizikopyala_btn.Location = new System.Drawing.Point(333, 90);
            this.dizikopyala_btn.Name = "dizikopyala_btn";
            this.dizikopyala_btn.Size = new System.Drawing.Size(89, 37);
            this.dizikopyala_btn.TabIndex = 3;
            this.dizikopyala_btn.Text = "dizi kopyala";
            this.dizikopyala_btn.UseVisualStyleBackColor = true;
            this.dizikopyala_btn.Click += new System.EventHandler(this.dizikopyala_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 307);
            this.Controls.Add(this.dizikopyala_btn);
            this.Controls.Add(this.listBox_dizikopyala);
            this.Controls.Add(this.listBox_dizioluştur);
            this.Controls.Add(this.dizioluştur_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dizioluştur_btn;
        private System.Windows.Forms.ListBox listBox_dizioluştur;
        private System.Windows.Forms.ListBox listBox_dizikopyala;
        private System.Windows.Forms.Button dizikopyala_btn;
    }
}

