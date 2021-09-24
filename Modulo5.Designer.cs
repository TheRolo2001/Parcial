
namespace Parcial
{
    partial class Modulo5
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
            this.Cerrar = new System.Windows.Forms.Button();
            this.txto = new System.Windows.Forms.RichTextBox();
            this.txta = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Cerrar
            // 
            this.Cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cerrar.Location = new System.Drawing.Point(124, 186);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(75, 23);
            this.Cerrar.TabIndex = 0;
            this.Cerrar.Text = "Cerrar";
            this.Cerrar.UseVisualStyleBackColor = true;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // txto
            // 
            this.txto.Location = new System.Drawing.Point(12, 12);
            this.txto.Name = "txto";
            this.txto.Size = new System.Drawing.Size(301, 96);
            this.txto.TabIndex = 1;
            this.txto.Text = "";
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(59, 154);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(209, 26);
            this.txta.TabIndex = 2;
            this.txta.Text = "";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(92, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "¿sera pangrama?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Modulo5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 217);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.txto);
            this.Controls.Add(this.Cerrar);
            this.Name = "Modulo5";
            this.Text = "Modulo5";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Cerrar;
        private System.Windows.Forms.RichTextBox txto;
        private System.Windows.Forms.RichTextBox txta;
        private System.Windows.Forms.Button button1;
    }
}