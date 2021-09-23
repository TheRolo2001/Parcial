using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial
{
    public partial class Modulo6 : Form
    {
        char[] Palabras1; int intentos;
        char[] Palabras2;
        char[] Letras;
        String Palabras3;
        public Modulo6()
        {
            InitializeComponent();
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Inicio(){
            Abecedario.Controls.Clear();
            Abecedario.Enabled = true;
            intentos = 0;
            Palabras3 = Frase_In.Text;

            Letras = "ABCDEFGHIJKLMNOPQRSTUVWXYZ ".ToCharArray();
            Random random = new Random();
            int Arreglo = random.Next(0, Palabras3.Length);
            Palabras2 = Palabras3.ToUpper().ToCharArray();
            Palabras1 = Palabras2;

            foreach(char LetraA in Letras)
            {
                Button btnLetra = new Button();
                btnLetra.Tag = " ";
                btnLetra.Text = LetraA.ToString();
                btnLetra.Width = 50;
                btnLetra.Height = 40;
                btnLetra.Click += Compara;
                btnLetra.ForeColor = Color.White;
                btnLetra.BackColor = Color.Black;
                btnLetra.Name = LetraA.ToString();
                Abecedario.Controls.Add(btnLetra);
            }
            Palabra.Controls.Clear();
            
            
            for (int Arreglo2=0; Arreglo2<Palabras2.Length; Arreglo2++)
            {
                Button Letra = new Button();
                Letra.Tag = Palabras2[Arreglo2].ToString();
                Letra.Text = "_";
                Letra.Width = 50;
                Letra.Height = 40;
                Letra.ForeColor = Color.White;
                Letra.BackColor = Color.Black;
                Letra.Name = "Adivinado" + Arreglo2.ToString();
                Palabra.Controls.Add(Letra);
            }  
        }
        void Compara(object sender, EventArgs e)
        {
            bool encontrado = false;
            Button btn = (Button)sender;
            btn.BackColor = Color.White;
            btn.ForeColor = Color.Black;
            btn.Enabled = false;

            for (int Arreglo3 = 0; Arreglo3<Palabras1.Length; Arreglo3++)
            {
                if (Palabras1[Arreglo3] == char.Parse(btn.Text))
                {
                    Button BtnS = this.Controls.Find("Adivinado" + Arreglo3, true).FirstOrDefault() as Button;
                    BtnS.Text = Palabras1[Arreglo3].ToString();
                    Palabras1[Arreglo3]='-';
                    encontrado = true;

                }
            }
            bool Ganaste = true;

            for (int Arreglo4 = 0; Arreglo4<Palabras1.Length; Arreglo4++)
            {
                if (Palabras1[Arreglo4] != '-')
                {
                    Ganaste = false;
                }
            }
            if (Ganaste) { MessageBox.Show("Ganaste");
                Abecedario.Enabled = false;
            }

            if (!encontrado)
            {
                intentos = intentos + 1;
                if (intentos == 7)
                {
                    for (int Arreglo5 = 0; Arreglo5 < Palabras2.Length; Arreglo5++)
                    {
                        Abecedario.Enabled = false;
                        Button BtnL = this.Controls.Find("Adivinado" + Arreglo5, true).FirstOrDefault() as Button;
                        
                        BtnL.Text = BtnL.Tag.ToString();
                        
                    }
                    MessageBox.Show("PERDISTES VUELVE A INTENTARLO");
                } 
            }
        }

        private void Modulo6_Load(object sender, EventArgs e)
        {
        }

        private void BtnIni_Click(object sender, EventArgs e)
        {
            Inicio();
        }
    }
}
