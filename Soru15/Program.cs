using System;

namespace Soru15
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Dizinin " + i + " . indisine eleman ekleyin.");
                dizi[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("***** Dizi tersine çevriliyor ******");
            Array.Reverse(dizi);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(dizi[i]);
            }
        tekrar:
            Console.WriteLine("Kaçıncı indisteki elemanı görmek istersiniz.0-9 arası bir sayı giriniz.");
            int indis = Convert.ToInt32(Console.ReadLine());
            if (indis < 0 && indis >= 10)
            {
                Console.WriteLine("Hatalı indis girdiniz. Böyle bir indis yok. Tekrar deneyin.");
                goto tekrar;
            }
            else
            {
                Console.WriteLine("***********************");
                Array.Reverse(dizi);
                Console.WriteLine(dizi[indis]);
            }

            Console.ReadKey();

        }
    }
}
