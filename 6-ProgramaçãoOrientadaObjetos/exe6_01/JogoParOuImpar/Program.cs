using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoParOuImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            ParOuImpar j1 = new ParOuImpar();
            ParOuImpar pc = new ParOuImpar();
            Console.WriteLine("jogo par ou impar");
            Console.Write("Você quer ser par ou impar: ");
            j1.Escolha = Console.ReadLine();
            Console.Write("Informe um valor entre 1 e 5: ");
            j1.Valor = Convert.ToInt32(Console.ReadLine());
            //definir o pc
            if (j1.Escolha == "PAR")
            {
                pc.Escolha = "IMPAR";
            }
            else
            {
                pc.Escolha = "PAR";
            }
            pc.GerarValor();
            Console.WriteLine($"Eu escolhi {pc.Escolha} e informei o valor valor {pc.Valor}");
            if (j1.Ganhei(pc.Valor) == true)
            {
                Console.WriteLine("Parabens!!!!! Você venceu.");
            }
            else
            {
                Console.WriteLine("Que Pena!!!!! Você perdeu.");
            }
            Console.ReadKey();
            //definir se o resultado é par ou impar
            //int resultado = j1.Valor + pc.Valor;
            //if (resultado % 2 == 0)
            //{
            //    if (j1.Escolha == "PAR")
            //    {
            //        Console.WriteLine("Parabens!!!!! Você venceu.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Que Pena!!!!! Você perdeu.");
            //    }
            //}
            //else
            //{
            //    if (j1.Escolha == "IMPAR")
            //    {
            //        Console.WriteLine("Parabens!!!!! Você venceu.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Que Pena!!!!! Você perdeu.");
            //    }
            //}

        }
    }
}
