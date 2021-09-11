using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcerteONumero
{
    class Program
    {
        static void Main(string[] args)
        {
            const int countMax = 3; //numero máximo de tentativas
            int count = 0; //tentativas executadas pelo usuário
            int numero = 0; // numero que o usuário irá identificar
            int entradaDados = 0; //numero infomado pelo usuário
            string resp = "";
            Random rnd = new Random(); // número aleatório

            resp = "sim";
            while (resp == "sim") //repente enquanto o jogador quiser jogar o jogo
            {
                //menu principal
                Console.Clear();
                Console.WriteLine("Jogo da adivinhação ");
                Console.WriteLine("Tente adivinar em três tentativas o número que o computador esta pensando");
                Console.WriteLine("O computador irá escolher um número aleatório entre 1 e 10");
                Console.Write("Quer jogar (sim ou não)?:");
                resp = Console.ReadLine(); //lê do teclado
                resp = resp.ToLower(); // converte o texto para minusculo
                //começa a partida
                if (resp == "sim")
                {
                    Console.Clear();
                    count = 0; //jogadas executas
                    numero = rnd.Next(1,10); //numero que deve adivinhar
                    entradaDados = -1;
                    while(count < countMax && numero!=entradaDados)
                    {
                        Console.Write("Que numéro estou pensando!!!!!: ");
                        entradaDados = Convert.ToInt32(Console.ReadLine());
                        if (entradaDados != numero)
                        { 
                            //dica para o jogador
                            if(entradaDados < numero)
                            {
                                Console.WriteLine("Quase... Pensei um número maior");
                            }
                            else
                            {
                                Console.WriteLine("Quase... Pensei um número menor");
                            }
                        }
                        count++;
                    }
                    //falo com o jogador se ele ganhou ou perdeu!!!!!
                    Console.Clear();
                    if (numero == entradaDados)
                    {
                        Console.WriteLine("Parabéns!!!! Você acertou");
                        Console.WriteLine($"Você acertou em {count} tentativas");
                    }
                    else
                    {
                        Console.WriteLine("Que pena!!!! Você errou.");
                        Console.WriteLine("Tente novamente.");
                    }
                    Console.ReadKey();
                }
            }
            
        }
    }
}
