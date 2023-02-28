
namespace WindowsFormsApp1
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
            this.textBox_sözlü2 = new System.Windows.Forms.TextBox();
            this.textBox_sözlü1 = new System.Windows.Forms.TextBox();
            this.textBox_yazılı2 = new System.Windows.Forms.TextBox();
            this.textBox_yazılı1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_adSoy = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox_not = new System.Windows.Forms.ListBox();
            this.button_listele = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_ekle
            // 
            this.button_ekle.Location = new System.Drawing.Point(276, 25);
            this.button_ekle.Name = "button_ekle";
            this.button_ekle.Size = new System.Drawing.Size(62, 61);
            this.button_ekle.TabIndex = 21;
            this.button_ekle.Text = "EKLE";
            this.button_ekle.UseVisualStyleBackColor = true;
            this.button_ekle.Click += new System.EventHandler(this.button_ekle_Click);
            // 
            // textBox_sözlü2
            // 
            this.textBox_sözlü2.Location = new System.Drawing.Point(289, 140);
            this.textBox_sözlü2.Name = "textBox_sözlü2";
            this.textBox_sözlü2.Size = new System.Drawing.Size(49, 20);
            this.textBox_sözlü2.TabIndex = 20;
            // 
            // textBox_sözlü1
            // 
            this.textBox_sözlü1.Location = new System.Drawing.Point(203, 140);
            this.textBox_sözlü1.Name = "textBox_sözlü1";
            this.textBox_sözlü1.Size = new System.Drawing.Size(49, 20);
            this.textBox_sözlü1.TabIndex = 19;
            // 
            // textBox_yazılı2
            // 
            this.textBox_yazılı2.Location = new System.Drawing.Point(114, 140);
            this.textBox_yazılı2.Name = "textBox_yazılı2";
            this.textBox_yazılı2.Size = new System.Drawing.Size(49, 20);
            this.textBox_yazılı2.TabIndex = 18;
            // 
            // textBox_yazılı1
            // 
            this.textBox_yazılı1.Location = new System.Drawing.Point(28, 140);
            this.textBox_yazılı1.Name = "textBox_yazılı1";
            this.textBox_yazılı1.Size = new System.Drawing.Size(49, 20);
            this.textBox_yazılı1.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(286, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "SÖZLÜ 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "SÖZLÜ 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "YAZILI 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "YAZILI 1";
            // 
            // textBox_adSoy
            // 
            this.textBox_adSoy.Location = new System.Drawing.Point(93, 28);
            this.textBox_adSoy.Name = "textBox_adSoy";
            this.textBox_adSoy.Size = new System.Drawing.Size(148, 20);
            this.textBox_adSoy.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "AD SOYAD";
            // 
            // listBox_not
            // 
            this.listBox_not.FormattingEnabled = true;
            this.listBox_not.Location = new System.Drawing.Point(407, 25);
            this.listBox_not.Name = "listBox_not";
            this.listBox_not.Size = new System.Drawing.Size(120, 134);
            this.listBox_not.TabIndex = 22;
            // 
            // button_listele
            // 
            this.button_listele.Location = new System.Drawing.Point(556, 25);
            this.button_listele.Name = "button_listele";
            this.button_listele.Size = new System.Drawing.Size(61, 61);
            this.button_listele.TabIndex = 23;
            this.button_listele.Text = "LİSTELE";
            this.button_listele.UseVisualStyleBackColor = true;
            this.button_listele.Click += new System.EventHandler(this.button_listele_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 190);
            this.Controls.Add(this.button_listele);
            this.Controls.Add(this.listBox_not);
            this.Controls.Add(this.button_ekle);
            this.Controls.Add(this.textBox_sözlü2);
            this.Controls.Add(this.textBox_sözlü1);
            this.Controls.Add(this.textBox_yazılı2);
            this.Controls.Add(this.textBox_yazılı1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_adSoy);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_ekle;
        private System.Windows.Forms.TextBox textBox_sözlü2;
        private System.Windows.Forms.TextBox textBox_sözlü1;
        private System.Windows.Forms.TextBox textBox_yazılı2;
        private System.Windows.Forms.TextBox textBox_yazılı1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_adSoy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_not;
        private System.Windows.Forms.Button button_listele;
    }
}

