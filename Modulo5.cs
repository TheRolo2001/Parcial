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
    public partial class Modulo5 : Form
    {
        public Modulo5()
        {
            InitializeComponent();
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nh;
            nh = Convert.ToInt32(txto.TextLength);
            String exp;
            bool pangrama = true;
            for (int i = 0; i < nh; i++, pangrama = true)
            {
                exp = txto.Text;
                for (char ascii = 'A'; ascii <= 'Z'; ascii++)
                {
                    if (!exp.ToUpper().Contains("" + ascii))
                    {
                        pangrama = false;
                        break;
                    }
                }
                txta.Text = pangrama ? "SI ES UN PANGRAMA"  : "NO ES UN PANGRAMA"  ;
            }
        }
    }
}
