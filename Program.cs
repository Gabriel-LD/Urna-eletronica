using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Urna_eletronica
{
    internal class Program
    {


        public static void Main(string[] args)
        {
            int n, opcao, conta = 0, conta1 = 0, conta2 = 0, conta3 = 0, conta4 = 0;
            string resposta = "sim";
            for (n = 0; n < 1000000; n++)
            {
                Console.WriteLine("\nopçao 1, candidato um \nopçao 2, candidato dois \nopçao 3, voto em branco \nopçao 4, voto nulo");
                opcao = int.Parse(Console.ReadLine());
                if (opcao == 1)
                {
                    Console.WriteLine("voto concluido");
                    conta1++;
                }
                if (opcao == 2)
                {
                    Console.WriteLine("voto concluido");
                    conta2++;
                }
                if (opcao == 3)
                {
                    Console.WriteLine("voto concluido");
                    conta3++;
                }
                if (opcao == 4)
                {
                    Console.WriteLine("voto concluido");
                    conta4++;
                }
                if (opcao > 4)
                {
                    Console.WriteLine("comando invalido\ndigite outro");
                }
                Console.Write("\nDeseja continuar?, digite \"Sim\" para prosseguir : ");
                resposta = Console.ReadLine();
                if (resposta == "NÃO" || resposta == "Não" || resposta == "não" || resposta == "nao" || resposta == "n") ;
                {
                    Console.Write("numero de votos do primeiro candidato: " + conta1);
                    Console.Write("\nnumero de votos do segundo candidato: " + conta2);
                    Console.Write("\nnumero de votos em branco: " + conta3);
                    Console.Write("\nnumero de votos nulo: " + conta4);
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            }
        }
    }
}
