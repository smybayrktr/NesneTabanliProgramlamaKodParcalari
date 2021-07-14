using System;

namespace Soru17
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.Write("Matris boyutunu giriniz: ");
            int boyut = Convert.ToInt32(Console.ReadLine());

            int[,] matrisA = new int[boyut, boyut];
            int[,] matrisB = new int[boyut, boyut];
            int[,] matrisC = new int[boyut, boyut];

            for (int i = 0; i < boyut; i++)
            {
                for (int j = 0; j < boyut; j++)
                {
                    matrisA[i, j] = rnd.Next(1, 10);
                    matrisB[i, j] = rnd.Next(1, 10);
                    matrisC[i, j] = 0;
                }
            }

            for (int i = 0; i < boyut; i++)
            {
                for (int j = 0; j < boyut; j++)
                {
                    for (int k = 0; k < boyut; k++)
                    {
                        matrisC[i, j] += matrisA[i, k] * matrisB[k, j];
                        Console.WriteLine(matrisC[i, j]);
                    }
                }
            }
            Console.ReadKey();

        }
    }
}
