using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoParOuImpar
{
    public class ParOuImpar
    {
        
        private string escolha;
        //ou É PAR ou é IMPAR
        public string Escolha
        {
            get { return escolha; }
            set {
                string texto = value.ToUpper();
                if (texto=="PAR" || texto == "IMPAR")
                {
                    escolha = texto;
                }
                else
                {
                    escolha = "PAR";
                }
            }
        }

        public int Valor { get; set; }

        public void GerarValor()
        {
            Random rnd = new Random();
            Valor = rnd.Next(1,6);
        }

        public Boolean Ganhei(int ValorConcorrente)
        {
            Boolean retorno = false; //falando que não ganhei
            int resultado = this.Valor + ValorConcorrente;
            if (resultado % 2 == 0)
            {
                if (this.Escolha == "PAR")
                {
                    retorno = true;
                }
            }
            else
            {
                if (this.Escolha == "IMPAR")
                {
                    retorno = true;
                }
            }
            return retorno;
        }

    }
}
