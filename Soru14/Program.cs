using System;

namespace Soru14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı giriniz.");
            int sayı = Convert.ToInt32(Console.ReadLine());
            int maxYıldız = sayı * 2 + 1;
            for (int satırS = 1; satırS <= sayı; satırS += 2)
            {
                for (int yıldızS = satırS; yıldızS <= sayı; yıldızS += 2)
                {
                    Console.Write(" ");

                }

                for (int i = 1; i <= satırS; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }



            Console.ReadKey();
        }
    }
}
