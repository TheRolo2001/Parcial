
namespace Parcial
{
    partial class Modulo2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PDigito = new System.Windows.Forms.TextBox();
            this.SDigito = new System.Windows.Forms.TextBox();
            this.Resultado = new System.Windows.Forms.TextBox();
            this.CalculoA = new System.Windows.Forms.Button();
            this.Btn_Cerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese Primer Digito:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese Segundo Digito:";
            // 
            // PDigito
            // 
            this.PDigito.Location = new System.Drawing.Point(407, 80);
            this.PDigito.Name = "PDigito";
            this.PDigito.Size = new System.Drawing.Size(100, 20);
            this.PDigito.TabIndex = 2;
            // 
            // SDigito
            // 
            this.SDigito.Location = new System.Drawing.Point(407, 127);
            this.SDigito.Name = "SDigito";
            this.SDigito.Size = new System.Drawing.Size(100, 20);
            this.SDigito.TabIndex = 3;
            // 
            // Resultado
            // 
            this.Resultado.Location = new System.Drawing.Point(306, 217);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(123, 20);
            this.Resultado.TabIndex = 4;
            this.Resultado.TextChanged += new System.EventHandler(this.Resultado_TextChanged);
            // 
            // CalculoA
            // 
            this.CalculoA.Location = new System.Drawing.Point(330, 175);
            this.CalculoA.Name = "CalculoA";
            this.CalculoA.Size = new System.Drawing.Size(75, 23);
            this.CalculoA.TabIndex = 6;
            this.CalculoA.Text = "CalcularArea:";
            this.CalculoA.UseVisualStyleBackColor = true;
            this.CalculoA.Click += new System.EventHandler(this.CalculoA_Click);
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.Location = new System.Drawing.Point(330, 259);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cerrar.TabIndex = 7;
            this.Btn_Cerrar.Text = "Cerrar";
            this.Btn_Cerrar.UseVisualStyleBackColor = true;
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            // 
            // Modulo2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Cerrar);
            this.Controls.Add(this.CalculoA);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.SDigito);
            this.Controls.Add(this.PDigito);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Modulo2";
            this.Text = "Modulo2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PDigito;
        private System.Windows.Forms.TextBox SDigito;
        private System.Windows.Forms.TextBox Resultado;
        private System.Windows.Forms.Button CalculoA;
        private System.Windows.Forms.Button Btn_Cerrar;
    }
}