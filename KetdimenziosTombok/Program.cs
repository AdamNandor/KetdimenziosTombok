using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetdimenziosTombok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //ha az elem egyetlen sorszámmal azonosítható a tömbben, akkor az egydimenziós tömb (tulajdonképp elemek egyszerű sora)
            // ha az azonosytáshoz két indeet használunk, akkor kétdimenziós a tömb (olyan, mint egy táblázat)
            int[,] tablazat = new int[2, 3];
            //adjuk meg egyesével az elemeket
            tablazat[0, 0] = 1;
            tablazat[0, 1] = 2;
            tablazat[0, 2] = 3;
            tablazat[1, 0] = 4;
            tablazat[1, 1] = 5;
            tablazat[1, 2] = 6;
            //kiírás
            for (int i = 0; i < tablazat.GetLength(0); i++)
            {
                //belső for ciklus lépteti az oszlopokat
                for (int j = 0; j < tablazat.GetLength(1); j++)
                {
                    Console.Write($"{tablazat[i, j]}");
                }
                Console.WriteLine();
            }
            */
            //feladat
            int n = 0;
            int m = 0;

            Console.WriteLine("Adjon meg egy 2 és 10 közé eső számot:");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Adjon meg egy 2 és 10 közé eső számot:");
            m = int.Parse(Console.ReadLine());

            int[,] tablazat = new int[n, m];
            Random rnd = new Random();

            for (int i = 0; i < tablazat.GetLength(0); i++)
            {
                for (int j = 0; j < tablazat.GetLength(1); j++)
                {
                    tablazat[i, j] = rnd.Next(1, 10);
                    Console.Write(tablazat[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
