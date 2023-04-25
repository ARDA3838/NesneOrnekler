
namespace U5_Uyg_18
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.maskDoğumTarih = new System.Windows.Forms.MaskedTextBox();
            this.maskKart = new System.Windows.Forms.MaskedTextBox();
            this.maskIP = new System.Windows.Forms.MaskedTextBox();
            this.maskTC = new System.Windows.Forms.MaskedTextBox();
            this.maskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "DOĞUM TARİHİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "TEL NO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "TC NO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "IP ADRESİ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(12, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "KART NO";
            // 
            // maskDoğumTarih
            // 
            this.maskDoğumTarih.Location = new System.Drawing.Point(136, 116);
            this.maskDoğumTarih.Name = "maskDoğumTarih";
            this.maskDoğumTarih.Size = new System.Drawing.Size(100, 20);
            this.maskDoğumTarih.TabIndex = 24;
            // 
            // maskKart
            // 
            this.maskKart.Location = new System.Drawing.Point(136, 152);
            this.maskKart.Name = "maskKart";
            this.maskKart.Size = new System.Drawing.Size(100, 20);
            this.maskKart.TabIndex = 25;
            // 
            // maskIP
            // 
            this.maskIP.Location = new System.Drawing.Point(136, 196);
            this.maskIP.Name = "maskIP";
            this.maskIP.Size = new System.Drawing.Size(100, 20);
            this.maskIP.TabIndex = 26;
            // 
            // maskTC
            // 
            this.maskTC.Location = new System.Drawing.Point(136, 33);
            this.maskTC.Name = "maskTC";
            this.maskTC.Size = new System.Drawing.Size(100, 20);
            this.maskTC.TabIndex = 27;
            // 
            // maskTelefon
            // 
            this.maskTelefon.Location = new System.Drawing.Point(136, 72);
            this.maskTelefon.Name = "maskTelefon";
            this.maskTelefon.Size = new System.Drawing.Size(100, 20);
            this.maskTelefon.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 269);
            this.Controls.Add(this.maskTelefon);
            this.Controls.Add(this.maskTC);
            this.Controls.Add(this.maskIP);
            this.Controls.Add(this.maskKart);
            this.Controls.Add(this.maskDoğumTarih);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox maskDoğumTarih;
        private System.Windows.Forms.MaskedTextBox maskKart;
        private System.Windows.Forms.MaskedTextBox maskIP;
        private System.Windows.Forms.MaskedTextBox maskTC;
        private System.Windows.Forms.MaskedTextBox maskTelefon;
    }
}

