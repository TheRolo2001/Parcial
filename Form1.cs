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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Modulo1_Click(object sender, EventArgs e)
        {
            Modulo2 Formulario2 = new Modulo2();
            Formulario2.Show();
        }

        private void Modulo2_Click(object sender, EventArgs e)
        {
            Form3 Formulario3 = new Form3();
            Formulario3.Show();
        }

        private void Modulo4_Click(object sender, EventArgs e)
        {
            Modulo4 Modulo = new Modulo4();
            Modulo.Show();
        }

        private void Modulo6_Click(object sender, EventArgs e)
        {
            Modulo6 Modulo = new Modulo6();
            Modulo.Show();
        }
    }
}
