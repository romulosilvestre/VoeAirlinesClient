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
    public partial class CalcDez : Form
    {
        public CalcDez()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtTotal.Text = (Convert.ToDouble(txtValor.Text) * 1.10).ToString("N");
        }

        private void CalcDez_Load(object sender, EventArgs e)
        {

        }
    }
}
