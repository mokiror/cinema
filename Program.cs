using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\tКИНОТЕАТР");

            Random rnd = new Random();
            

            Console.WriteLine("СХЕМА ЗАЛА:");
            Console.WriteLine("1 - занято, 0 - нет\n");
            Console.WriteLine("\t\t\t\t\t---------------------------\n\n");

            for (int i = 1; i <= 6; i++)
            {
                Console.Write($"                  ");
                for (int j = 0; j < 8; j++)
                {
                    int num1 = rnd.Next(0, 2);
                    Console.Write($"\t{num1}");
                   
                }
                Console.Write($"\n"); 
            }
            Console.WriteLine();
            for (int i = 1; i <= 6; i++)
            {
                Console.Write($"          ");
                for (int j = 0; j < 10; j++)
                {
                    int num1 = rnd.Next(0, 2);
                    Console.Write($"\t{num1}");

                }
                Console.Write($"\n");
            }
            Console.WriteLine();
            for (int i = 1; i <= 6; i++)
            {

                for (int j = 0; j < 12; j++)
                {
                    int num1 = rnd.Next(0, 2);
                    Console.Write($"\t{num1}");

                }
                Console.Write($"\n");
            }


            Console.ReadKey();
        }
    }
}
