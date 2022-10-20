using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuPrincipal
{
    public partial class CalcAssentos : Form
    {
        public CalcAssentos()
        {
            InitializeComponent();
        }

        private void btnCalcularCat_Click(object sender, EventArgs e)
        {
            int qtdeAssentos = Convert.ToInt32(txtQtdeAssentos.Text);
            switch (qtdeAssentos)
            {
                case 1: 
                    lblResultAssento.Text = "Monoplace";break;
                case 2: 
                    lblResultAssento.Text = "Biplace"; break;
                case 3: 
                    lblResultAssento.Text = "Triplace"; break;
                case 4: 
                    lblResultAssento.Text = "Quadriplace"; break;
                default: 
                    lblResultAssento.Text = "Poliplace ou Multiplace";break;
            }
        }
    }
}
