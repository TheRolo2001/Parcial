
namespace Parcial
{
    partial class Modulo6
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
            this.BtnIni = new System.Windows.Forms.Button();
            this.Abecedario = new System.Windows.Forms.FlowLayoutPanel();
            this.Palabra = new System.Windows.Forms.FlowLayoutPanel();
            this.Frase_In = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cerrar
            // 
            this.Cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cerrar.Location = new System.Drawing.Point(325, 415);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(75, 23);
            this.Cerrar.TabIndex = 0;
            this.Cerrar.Text = "Cerrar";
            this.Cerrar.UseVisualStyleBackColor = true;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // BtnIni
            // 
            this.BtnIni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIni.Location = new System.Drawing.Point(12, 12);
            this.BtnIni.Name = "BtnIni";
            this.BtnIni.Size = new System.Drawing.Size(164, 23);
            this.BtnIni.TabIndex = 1;
            this.BtnIni.Text = "Iniciar Juego";
            this.BtnIni.UseVisualStyleBackColor = true;
            this.BtnIni.Click += new System.EventHandler(this.BtnIni_Click);
            // 
            // Abecedario
            // 
            this.Abecedario.Location = new System.Drawing.Point(12, 53);
            this.Abecedario.Name = "Abecedario";
            this.Abecedario.Size = new System.Drawing.Size(561, 180);
            this.Abecedario.TabIndex = 2;
            // 
            // Palabra
            // 
            this.Palabra.Location = new System.Drawing.Point(12, 257);
            this.Palabra.Name = "Palabra";
            this.Palabra.Size = new System.Drawing.Size(561, 137);
            this.Palabra.TabIndex = 3;
            // 
            // Frase_In
            // 
            this.Frase_In.Location = new System.Drawing.Point(609, 15);
            this.Frase_In.Name = "Frase_In";
            this.Frase_In.Size = new System.Drawing.Size(100, 20);
            this.Frase_In.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(529, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ingrese Frase:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "SOLO TIENE 7 INTENTOS";
            // 
            // Modulo6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Frase_In);
            this.Controls.Add(this.Palabra);
            this.Controls.Add(this.Abecedario);
            this.Controls.Add(this.BtnIni);
            this.Controls.Add(this.Cerrar);
            this.Name = "Modulo6";
            this.Text = "Modulo6";
            this.Load += new System.EventHandler(this.Modulo6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cerrar;
        private System.Windows.Forms.Button BtnIni;
        private System.Windows.Forms.FlowLayoutPanel Abecedario;
        private System.Windows.Forms.FlowLayoutPanel Palabra;
        private System.Windows.Forms.TextBox Frase_In;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}