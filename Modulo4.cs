﻿using System;
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
    public partial class Modulo4 : Form
    {
        public Modulo4()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Resultado_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void Btn_Inver_Click(object sender, EventArgs e)
        {
            String Texto = Frase.Text;
            String Resul = String.Join(" ", Texto.Split(' ').Select(x => new String(x.Reverse().ToArray())));
            Resultado.Text = Resul;
        }
    }
}
