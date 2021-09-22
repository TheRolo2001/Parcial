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
    public partial class Modulo1 : Form
    {
        public Modulo1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2;
           
            num1 = Convert.ToInt32(n1.Text);
            num2 = Convert.ToInt32(n2.Text);

            if ((num1 > num2))
            {

                txto.Text = num2 + "  ES MENOR QUE  " + num1;
            }
            else
            {
                if ((num1 < num2))
                {
                    txto.Text = num1 + "  ES MENOR QUE  " + num2;

                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
    
