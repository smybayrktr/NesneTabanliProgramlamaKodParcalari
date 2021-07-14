using System;

namespace Soru11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kaç tane fibonacci sayı dizisini görmek istersiniz.");
            int sayı = Convert.ToInt32(Console.ReadLine());
            int sayı1 = 0;
            int sayı2 = 1;
            int toplam = 0;
            for (int i = 0; i < sayı; i++)
            {
                toplam = sayı1 + sayı2;
                sayı2 = sayı1;
                sayı1 = toplam;
                Console.Write(toplam + " , ");

            }
            Console.ReadKey();
        }
    }
}
