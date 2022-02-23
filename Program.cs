using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGremio
{
    internal class Program
    {

        static string Menu(string op)
        {
            Console.Write("Deseja continuar com a análise? (S/N): ");
            op = Console.ReadLine();
            op = op.ToUpper();
            Console.WriteLine("");
            return op;
        }

        static void Main(string[] args)
        {
            Console.Title = "ANÁLISE DE AFETAÇÃO DO GRÊMIO";

            string op = "S";

            while (op == "S")
            {

                Console.Write("ISSO AFETA O GRÊMIO? ");
                Console.Write("DIGITE: ");
                string entry = Console.ReadLine();

                Console.WriteLine();


                Random rnd = new Random();
                int i = rnd.Next(0, 11);


                if (i == 0 || i == 2 || i == 4 || i == 6 || i == 8 || i == 10)
                {
                    Console.Write("NÃO AFETA O GRÊMIO!");
                }
                
                else
                {
                    Console.Write("AFETA O GRÊMIO!");
                }


                Console.WriteLine("");


                op = Menu(op);
                Console.WriteLine(op);
                
                if (op == "S")
                {
                }

                else if (op == "N")
                {
                    break;
                }

                else
                {
                    Console.WriteLine("DIGITE UMA OPÇÃO VÁLIDA!");
                    op = Menu(op);
                }
            }
           
            Console.ReadKey();
        }
    }
}
