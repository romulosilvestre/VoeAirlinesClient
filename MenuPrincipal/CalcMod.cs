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
    public partial class CalcMod : Form
    {
        public CalcMod()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ENTRADA DE DADOS
            int dividendo = Convert.ToInt32(txtDividendo.Text);
            int divisor = Convert.ToInt32(txtDivisor.Text);
            //PROCESSAMENTO DE DADOS
            int resto = dividendo % divisor;
            //RESULTADO OU SAÍDA DOS DADOS
            txtResto.Text = resto.ToString();

        }
    }
}
