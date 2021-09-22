
namespace Parcial
{
    partial class Modulo3
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
            this.txt1 = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.txto = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(63, 72);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(660, 20);
            this.txt1.TabIndex = 0;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(339, 169);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 1;
            this.btn.Text = "button1";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // txto
            // 
            this.txto.Location = new System.Drawing.Point(207, 214);
            this.txto.Name = "txto";
            this.txto.Size = new System.Drawing.Size(347, 168);
            this.txto.TabIndex = 2;
            this.txto.Text = "";
            // 
            // Modulo3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txto);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.txt1);
            this.Name = "Modulo3";
            this.Text = "Modulo 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.RichTextBox txto;
    }
}