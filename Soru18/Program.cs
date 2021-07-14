using System;

namespace Soru18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Üçgenin tabanını giriniz.");
            double taban = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Üçgenin yüksekliğini giriniz.");
            double yükseklik = Convert.ToDouble(Console.ReadLine());
            double sonuç = alanHesapla(taban, yükseklik);
            Console.WriteLine("Üçgenin alanı:" + sonuç);
            Console.ReadKey();
        }
        static double alanHesapla(double taban, double yükseklik)
        {
            return taban * yükseklik / 2;
        }

    }
}

