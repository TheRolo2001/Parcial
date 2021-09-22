
namespace Parcial
{
    partial class Modulo4
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
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Frase = new System.Windows.Forms.TextBox();
            this.Btn_Inver = new System.Windows.Forms.Button();
            this.Resultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Location = new System.Drawing.Point(46, 161);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(93, 23);
            this.BtnCerrar.TabIndex = 0;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "INGRESE FRASE:";
            // 
            // Frase
            // 
            this.Frase.Location = new System.Drawing.Point(46, 46);
            this.Frase.Name = "Frase";
            this.Frase.Size = new System.Drawing.Size(93, 20);
            this.Frase.TabIndex = 2;
            // 
            // Btn_Inver
            // 
            this.Btn_Inver.Location = new System.Drawing.Point(46, 82);
            this.Btn_Inver.Name = "Btn_Inver";
            this.Btn_Inver.Size = new System.Drawing.Size(93, 23);
            this.Btn_Inver.TabIndex = 3;
            this.Btn_Inver.Text = "Invertir";
            this.Btn_Inver.UseVisualStyleBackColor = true;
            this.Btn_Inver.Click += new System.EventHandler(this.Btn_Inver_Click);
            // 
            // Resultado
            // 
            this.Resultado.Location = new System.Drawing.Point(46, 123);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(93, 20);
            this.Resultado.TabIndex = 4;
            this.Resultado.TextChanged += new System.EventHandler(this.Resultado_TextChanged);
            // 
            // Modulo4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(181, 206);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.Btn_Inver);
            this.Controls.Add(this.Frase);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCerrar);
            this.Name = "Modulo4";
            this.Text = "Modulo4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Frase;
        private System.Windows.Forms.Button Btn_Inver;
        private System.Windows.Forms.TextBox Resultado;
    }
}