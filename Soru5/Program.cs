using System;

namespace Soru5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Birinci sayıyı giriniz.");
            int sayı1 = Convert.ToInt32(Console.ReadLine());
            tekrar:
            Console.WriteLine("İkinci sayıyı giriniz.");
            int sayı2 = Convert.ToInt32(Console.ReadLine());
            if (sayı2 == 0)
            {
                Console.WriteLine("Payda 0 olamaz.Lütfen farklı bir sayı giriniz.");
                goto tekrar;
            }
            else
            {
                if (sayı1 % sayı2 == 0) //sayının kalanı 0sa tam bölündüğü için kalanı burda kontrol edilmiştir.
                {
                    Console.WriteLine("Sayılar tam bölünür.");
                }
                else
                {
                    Console.WriteLine("Sayılar tam bölünmez.");
                }
            }
            Console.ReadKey();
        }
    }
}
