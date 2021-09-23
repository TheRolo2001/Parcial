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
    public partial class Modulo3 : Form
    {
        public Modulo3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<String> frase = new List<string>();
            string cadena = " ";
            int contador = 0;
            char[] arrcadena;
            string quit = string.Empty;
            cadena = fra.Text.Replace(" ","");
            arrcadena = cadena.ToCharArray();
            for (int i = 0; i < arrcadena.Length; i++)
            {
                for (int j = 0; j < arrcadena.Length; j++)
                {

                    if (arrcadena[i] == arrcadena[j])
                    {
                        contador++;
                    }
                }
                frase.Add(arrcadena[i] + " " + contador + "\n");
                Console.WriteLine(quit);
                contador = 0;
            }
            HashSet<string> Sinfrase = new HashSet<string>(frase);
            foreach (String var in Sinfrase)
            {
                quit = quit + var.ToString();
                res.Text = (quit);
            }
        }
    }
    }

