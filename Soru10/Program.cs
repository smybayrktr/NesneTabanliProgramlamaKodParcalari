using System;

namespace Soru10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı giriniz.");
            int sayı = Convert.ToInt32(Console.ReadLine());
            int top = 0;
            int top2 = 0;
            for (int i = 1; i <= sayı; i++)
            {
                for (int j = 1; j <= sayı; j++)
                {
                    Console.Write(i + " " + j);
                    Console.WriteLine();
                    top += j;
                }
                Console.WriteLine();
                top2 += i;
            }
            top2 = sayı * top2;
            top += top2;
            Console.WriteLine("Toplam:" + top);
            Console.ReadKey();
        }
    }
}
