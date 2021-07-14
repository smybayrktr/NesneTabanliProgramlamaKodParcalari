using System;

namespace Soru6
{
    class Program
    {
        static void Main(string[] args)
        {
        tekrar:
            Console.WriteLine("Gün.Ay.Yıl formatında tarih giriniz.");
            DateTime tarih;
            tarih = Convert.ToDateTime(Console.ReadLine());
            int ay = tarih.Month;
            switch (ay)
            {
                case 01:
                    Console.WriteLine("Aylardan ocak");
                    break;
                case 02:
                    Console.WriteLine("Aylardan şubat");
                    break;
                case 03:
                    Console.WriteLine("Aylardan mart");
                    break;
                case 04:
                    Console.WriteLine("Aylardan nisan");
                    break;
                case 05:
                    Console.WriteLine("Aylardan mayıs");
                    break;
                case 06:
                    Console.WriteLine("Aylardan haziran");
                    break;
                case 07:
                    Console.WriteLine("Aylardan temmuz");
                    break;
                case 08:
                    Console.WriteLine("Aylardan ağustos");
                    break;
                case 09:
                    Console.WriteLine("Aylardan eylül");
                    break;
                case 10:
                    Console.WriteLine("Aylardan ekim");
                    break;
                case 11:
                    Console.WriteLine("Aylardan kasım");
                    break;
                case 12:
                    Console.WriteLine("Aylardan aralık");
                    break;
                default:
                    Console.WriteLine("Hatalı tarih girdiniz. Lütfen tekrar deneyiniz");
                    goto tekrar;
            }

            Console.ReadKey();
        }
    }
}
