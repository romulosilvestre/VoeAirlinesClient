using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoeAirlinesClient.Dominio
{
    public class Aeronave //PascalCasing
    {

        //private - apenas a classe acessa
        //public  - todo mundo acessa
        //protected - apenas os autorizados podem acessar.

        //Atributos - dados da Aeronave
        /*private string _fabricante;
        private string _modelo;
        private string _codigo;  */
        //Opção de não iniciar valores.

        //Propriedades Automáticas - manipular os dados individualmente
        public string Fabricante { get; set; } //PascalCasing
        public string Modelo { get; set; }
        public string Codigo { get; set; }

        //Construir o objeto em inicializa-lo
        public Aeronave()
        {
        }
        //Contruir o objeto com inicialização
        public Aeronave(string fabricante, string modelo, string codigo) //camelCasel
        {
            Fabricante = fabricante;
            Modelo = modelo;
            Codigo = codigo;
        }

        //Polimorfismo-várias formas
       //Virtual  - coloque o virtual no Pai
        public virtual string ManterAeronave()
        {
            return "A aeronave teve uma Manutenção Geral";
        }

    }
}

