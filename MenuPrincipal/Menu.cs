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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void pesquisarWebAPIToolStripMenuItem_Click(object sender, EventArgs e)
        {
                MessageBox.Show("Solicitação Iniciada...",
                "API VoeAirlines",
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }

        private void calculadoraMODToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CalcMod().Show();
        }

        private void calculadora10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CalcDez().Show();
        }

        private void calcCategoriaIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CalcAssentos().Show();
        }

        private void calculadoraOrigemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CalcOrigemDestino().Show();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmAeronave().Show();
        }

        private void dirigívelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmDirigivel().Show();
        }
    }
}
