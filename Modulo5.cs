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
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txt1.Text);
            String exp;
            bool pangrama = true;
            for (int i = 0; i < n; i++, pangrama = true)
            {
                exp = Console.ReadLine();
                for (char ascii = 'A'; ascii <= 'Z'; ascii++)
                {
                    if (!exp.ToUpper().Contains("" + ascii))
                    {
                        pangrama = false;
                        break;
                    }
                }
                Console.WriteLine((pangrama ? "SI" : "NO"));
            }
        }
    }
}
