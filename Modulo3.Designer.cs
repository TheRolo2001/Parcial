
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.fra = new System.Windows.Forms.RichTextBox();
            this.res = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(303, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(303, 141);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Pangrama";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // fra
            // 
            this.fra.Location = new System.Drawing.Point(195, 28);
            this.fra.Name = "fra";
            this.fra.Size = new System.Drawing.Size(300, 96);
            this.fra.TabIndex = 11;
            this.fra.Text = "";
            // 
            // res
            // 
            this.res.Location = new System.Drawing.Point(182, 184);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(334, 168);
            this.res.TabIndex = 12;
            this.res.Text = "";
            // 
            // Modulo3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 521);
            this.Controls.Add(this.res);
            this.Controls.Add(this.fra);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Modulo3";
            this.Text = "Modulo 3";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox fra;
        private System.Windows.Forms.RichTextBox res;
    }
}