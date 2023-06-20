using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correcao21
{
    class Program
    {
        static void Main(string[] args)
        {

            int pontos = 0;




            Console.WriteLine("Bem-Vindo ao jogo 21");
            Console.WriteLine("Faça 21 pontos para vencer");

            while (true)
            {
                

                Console.WriteLine("Digite 1 para continuar ou 2 para parar:");
                int opcao = Int32.Parse(Console.ReadLine());
                
                if  (opcao == 2)
                {
                    Console.WriteLine("Fim de Jogo");
                    break;
                }
                Random sorteador = new Random();
                int numero = sorteador.Next(1, 11);
                Console.WriteLine($"Você tirou o número {numero}");

                pontos = numero + numero;

                if (pontos >= 21)
                {
                    Console.WriteLine("FIM DE JOGO");
                    break;
                }
            }

           

            











        }
    }
}