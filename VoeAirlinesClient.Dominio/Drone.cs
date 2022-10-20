using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoeAirlinesClient.Dominio
{
    //drone
    public class Drone:Aeronave,IColecionavel
    {
        public bool PilhaOuBateria { get; set; }

        public void Colecionar()
        {
            Console.WriteLine("adicione a coleção");
        }





        //sobrescreve o método do pai
        /*
         * Polimorfismo: é a capacidade de um objeto assumir diferentes formas
         * de acordo com a necessidade.
         * Vimos na prática -Hands On
         * 
         */
        public override string ManterAeronave()
        {
            //implementando de outra forma
            //outra forma = várias formas = POLI(várias) MORIFSMO (forma)
            //POLIMORFISMO = várias formas.
            return $"{base.ManterAeronave()} e pilha {PilhaOuBateria}";
        }

    }
}
