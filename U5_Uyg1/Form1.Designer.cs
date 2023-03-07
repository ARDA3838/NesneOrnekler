
namespace U5_Uyg1
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
            this.btn_Acept = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_CenterToScreen = new System.Windows.Forms.Button();
            this.btn_ControlBox = new System.Windows.Forms.Button();
            this.btn_ShowDialog = new System.Windows.Forms.Button();
            this.btn_Show = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Acept
            // 
            this.btn_Acept.Location = new System.Drawing.Point(28, 24);
            this.btn_Acept.Name = "btn_Acept";
            this.btn_Acept.Size = new System.Drawing.Size(98, 36);
            this.btn_Acept.TabIndex = 0;
            this.btn_Acept.Text = "Acept";
            this.btn_Acept.UseVisualStyleBackColor = true;
            this.btn_Acept.Click += new System.EventHandler(this.btn_Acept_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(28, 66);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(98, 39);
            this.btn_Cancel.TabIndex = 1;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_CenterToScreen
            // 
            this.btn_CenterToScreen.Location = new System.Drawing.Point(28, 156);
            this.btn_CenterToScreen.Name = "btn_CenterToScreen";
            this.btn_CenterToScreen.Size = new System.Drawing.Size(98, 39);
            this.btn_CenterToScreen.TabIndex = 3;
            this.btn_CenterToScreen.Text = "CenterToScreen";
            this.btn_CenterToScreen.UseVisualStyleBackColor = true;
            this.btn_CenterToScreen.Click += new System.EventHandler(this.btn_CenterToScreen_Click);
            // 
            // btn_ControlBox
            // 
            this.btn_ControlBox.Location = new System.Drawing.Point(28, 111);
            this.btn_ControlBox.Name = "btn_ControlBox";
            this.btn_ControlBox.Size = new System.Drawing.Size(98, 39);
            this.btn_ControlBox.TabIndex = 2;
            this.btn_ControlBox.Text = "ControlBox";
            this.btn_ControlBox.UseVisualStyleBackColor = true;
            this.btn_ControlBox.Click += new System.EventHandler(this.btn_ControlBox_Click);
            // 
            // btn_ShowDialog
            // 
            this.btn_ShowDialog.Location = new System.Drawing.Point(28, 242);
            this.btn_ShowDialog.Name = "btn_ShowDialog";
            this.btn_ShowDialog.Size = new System.Drawing.Size(98, 34);
            this.btn_ShowDialog.TabIndex = 5;
            this.btn_ShowDialog.Text = "ShowDialog";
            this.btn_ShowDialog.UseVisualStyleBackColor = true;
            this.btn_ShowDialog.Click += new System.EventHandler(this.btn_ShowDialog_Click);
            // 
            // btn_Show
            // 
            this.btn_Show.Location = new System.Drawing.Point(28, 202);
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.Size = new System.Drawing.Size(98, 34);
            this.btn_Show.TabIndex = 4;
            this.btn_Show.Text = "Show";
            this.btn_Show.UseVisualStyleBackColor = true;
            this.btn_Show.Click += new System.EventHandler(this.btn_Show_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(155, 300);
            this.Controls.Add(this.btn_ShowDialog);
            this.Controls.Add(this.btn_Show);
            this.Controls.Add(this.btn_CenterToScreen);
            this.Controls.Add(this.btn_ControlBox);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Acept);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Acept;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_CenterToScreen;
        private System.Windows.Forms.Button btn_ControlBox;
        private System.Windows.Forms.Button btn_ShowDialog;
        private System.Windows.Forms.Button btn_Show;
    }
}

