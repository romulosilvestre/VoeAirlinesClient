using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoeAirlinesClient.Dominio
{
    internal class Piloto
    {
        //Cite 3 caracteristicas do Piloto
        public string NumeroCertificado { get; set; }
        public string Nome { get; set; }
        public string TipoAeronave { get; set; }


        //Cite 3 funcionalidades do Piloto
        public string VerificaNome()
        {
            if (Nome.Equals("Rômulo"))
            {
                return "acessou!";
            }
            else
            {
                return "não acessou!";
            }
        }
        public void ValidarCertificado()
        {

        }
        /*
         *  @#$%&&*()()()()()()()(__________@@@@@#$$$$$$%%%%%%&&&&&%¨¨%&&&||||||||/////////????~][=-0987654321'0123,6.+985478/*->>>>>>><<<<<<:::::::?????????^^^^^^^^^^<<<<<<>>>>>>>>"!@#$%¨&*()_+§§§§§§§§§§§§§§§§§§§§§§§§§§§§
         */
        //Banco de Dados
        //Quais funcionalidades o piloto fará com o banco
        public string Conectar()
        {
            return null;
        }
        public string Cadastrar()
        {
            return null;
        }
        public string  Exibir()
        {
            return null;
        }
        public string Alterar()
        {
            //executa a tarefa e volta..
            //Flavio terminou o relacionou e voltou...
            return null;
        }
        public void PesquisarPorCertificado()
        {
           //executa a tarefa e tchau!!!!!!!
           //Flavio terminou e não voltou...
        }

    
    }
}
