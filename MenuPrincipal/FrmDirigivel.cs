using System;
using System.Windows.Forms;
using VoeAirlinesClient.Dominio;
using System.Reflection; //espelhos para as classes, assemblies

namespace MenuPrincipal
{
    public partial class FrmDirigivel : Form
    {
        public FrmDirigivel()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Dirigivel dirigivel = new Dirigivel();

            //***********SET AUTOMÁTICO******************
            //herança - generalização (do pai)
            dirigivel.Fabricante = "Airship do Brasil";
            dirigivel.Codigo = "ADB-1";
            //herança - especialização (do filho)
            dirigivel.RemotamenteControlado = true;

            //***********GET AUTOMÁTICO******************
            MessageBox.Show($"Fabricante: {dirigivel.Fabricante} Codigo:{dirigivel.Codigo} Remotamente Controlado:{dirigivel.RemotamenteControlado}" );

            MessageBox.Show("***************Espelho*******************");
            MessageBox.Show("Reflection: Reflexão");
            //Asssembly - .exe  .dll próprio software
            //Como que um software vai ter informação do software?
            AssemblyName meuAssembly = Assembly.GetExecutingAssembly().GetName();
            MessageBox.Show($"Nome:{meuAssembly.Name}");
            MessageBox.Show($"Versão:{meuAssembly.Version}");
            
            /*
             * A Versão do Software tem 4 partes:
             * <maior versão> <menor versão> <build number> <revisão)
             */
            


        }
    }
}
