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
    public partial class Modulo2 : Form
    {
        
        public Modulo2()
        {
            InitializeComponent();
        }

        private void Resultado_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void CalculoA_Click(object sender, EventArgs e)
        {
            double altura;
            double bse;
            double Result;

            altura = Convert.ToDouble(PDigito.Text);
            bse = Convert.ToDouble(SDigito.Text);

            Result = (altura*bse)/2;
            Resultado.Text=Result.ToString();
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
