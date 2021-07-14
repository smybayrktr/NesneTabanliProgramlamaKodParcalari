using System;

namespace Soru2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Birinci sayıyı giriniz.");
            double sayı1 = Convert.ToDouble(Console.ReadLine());
            tekrar:
            Console.WriteLine("İkinci sayıyı giriniz.");
            double sayı2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Klavyeden girilen iki sayının toplamı:" + (sayı1 + sayı2));
            Console.WriteLine("Klavyeden girilen iki sayının farkı:" + (sayı1 - sayı2));
            Console.WriteLine("Klavyeden girilen iki sayının çarpımı:" + (sayı1 * sayı2));
            if (sayı2 == 0)
            {
                Console.WriteLine("Payda 0 olamaz lütfen farklı bir sayı giriniz.");
                goto tekrar;
            }
            else
            {
                Console.WriteLine("Klavyeden girilen iki sayının oranı(bölümü):" + (double)(sayı1 / sayı2));
            }
            Console.ReadKey();
        }
    }
}
