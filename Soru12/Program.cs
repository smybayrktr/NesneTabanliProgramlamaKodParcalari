using System;

namespace Soru12
{
    class Program
    {
        static void Main(string[] args)
        {
        tekrar:
            Console.WriteLine("Ay giriniz.");
            string ay = Console.ReadLine();
            switch (ay)
            {
                case "ocak":
                    Console.WriteLine("Ocak 1. aydır");
                    break;
                case "şubat":
                    Console.WriteLine("Şubat 2. aydır");
                    break;
                case "mart":
                    Console.WriteLine("Mart 3. aydır");
                    break;
                case "nisan":
                    Console.WriteLine("Nisan 4. aydır");
                    break;
                case "mayıs":
                    Console.WriteLine("Mayıs 5. aydır");
                    break;
                case "haziran":
                    Console.WriteLine("Haziran 6. aydır");
                    break;
                case "temmuz":
                    Console.WriteLine("Temmuz 7. aydır");
                    break;
                case "ağustos":
                    Console.WriteLine("Ağustos 8. aydır");
                    break;
                case "eylül":
                    Console.WriteLine("Eylül 9. aydır");
                    break;
                case "ekim":
                    Console.WriteLine("Ekim 10. aydır");
                    break;
                case "kasım":
                    Console.WriteLine("Kasım 11. aydır");
                    break;
                case "aralık":
                    Console.WriteLine("Aralık 12. aydır");
                    break;
                default:
                    Console.WriteLine("Geçersiz ay girdiniz. Lütfen tekrar deneyiniz.");
                    goto tekrar;

            }
            Console.ReadKey();
        }
    }
}
