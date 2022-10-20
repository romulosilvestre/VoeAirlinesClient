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
    public partial class CalcOrigemDestino : Form
    {
        public CalcOrigemDestino()
        {
            InitializeComponent();
        }

        private void CalcOrigemDestino_Load(object sender, EventArgs e)
        {
            ///Trabalhar com Data Curta
            lblDataHoje.Text = $"Hoje é {DateTime.Now.ToShortDateString()}";

            //DateTime
            /*
             * As Datas e Horas
             * Que estejam no intervalo de 00h:00m de 1 de jan de 1601 até 31 de dezembro de 9999
             * Calendário é conhecido como Anno Domini (AD).
             * 
             */

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
             * TimeSpan
             *    Day
             *    
             */
            //Estrutura - Struct
            /*
             * O que é Struct?
             * 
             * Linguagem C
             * 
             * 
             */
            string descricao = txtDescricao.Text;
            TimeSpan qtdeDias = DateTime.Now.Date - dtpDataFabricacao.Value;         
            int idadeAeronave = qtdeDias.Days / 365;
            //Lógica do lblQtdeAnos
            if (idadeAeronave > 0)
            {
                lblQtdeAnos.Text = idadeAeronave.ToString();
            }
            else
            {
                lblQtdeAnos.Text = "Aeronave não completou 1 ano";
            }
            
            //Lógica do Destino Aposentadoria.
            if(idadeAeronave >= 20)
            {
                lblDestinoAposentadoria.Text = "A Aeronave deve ser aposentada";
            }
            else
            {
                lblDestinoAposentadoria.Text = "Aeronave na Ativa";
            }

            //ADO.NET - Banco de Dados sem Framework (homosapiens)
            /*
             * Pesquise sobre as seguintes classes:
             * Connection
             * Command
             * DataAdapter
             * DataSet
             * ConnectionString
             * www.connectionstrings.com
             * 
             * 
             */
        }
    }
}
