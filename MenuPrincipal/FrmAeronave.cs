using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VoeAirlinesClient.Dominio;

namespace MenuPrincipal
{
    public partial class FrmAeronave : Form
    {
        public FrmAeronave()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //Construtor vazio ele cria uma instância do objeto            
           /* Aeronave aeronave1 = new Aeronave();//construtor vazio.?
            aeronave1.AtribuirFabricante(txtFabricante.Text);//atribuo
            MessageBox.Show(aeronave1.RetornaFabricante());//recuperar*/
            
            //cria o objeto com construtor vazio
            Aeronave aeronave = new Aeronave();//não iniciar
            //Objeto é uma instância de uma classe
            //Minas Gerais - é uma classe (não consegue pegar)
            //Pão de Queijo - é o objeto (pegar, comer ...etc...)

            //Abstração

            //Embraer - classe
            //Legacy - objeto


            //aeronave é objeto
            //Quais as caractertísticas desse objeto
            //Fabricante
            //Modelo
            //Codigo


            //PROPRIEDADES AUTOMÁTICAS

            //set
            aeronave.Fabricante = txtFabricante.Text; //atribuindo o que o cara digitou dentro do fabricante
            aeronave.Codigo = txtCodigo.Text; //set
            aeronave.Modelo = txtModelo.Text;                
            
            //get
            lblResultadoFabricante.Text = aeronave.Fabricante; //GET pegando o valor e colocando no lbl
            lblResultadoCodigo.Text = aeronave.Codigo;
            lblResultadoModelo.Text = aeronave.Modelo;

            //aeronave2.Fabricante = "Embraer"; //set



        }
    }
}
