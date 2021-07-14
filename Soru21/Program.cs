using System;

namespace ntp7Odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İşlem yapılacak ilk sayıyı giriniz.");
            double sayı1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("İşlem yapılacak ikinci sayıyı giriniz.");
            double sayı2 = Convert.ToDouble(Console.ReadLine());
        tekrar:
            menüGöster();
            int seçim = Convert.ToInt32(Console.ReadLine());
            HesapMakinesi hm = new HesapMakinesi();
            switch (seçim)
            {
                case 1:
                    Console.WriteLine("Seçiminiz: Toplama");
                    Console.WriteLine("Toplam:" + hm.topla(sayı1, sayı2));
                    break;
                case 2:
                    Console.WriteLine("Seçiminiz: Çıkarma");
                    Console.WriteLine("Farkı: " + hm.çıkar(sayı1, sayı2));
                    break;
                case 3:
                    Console.WriteLine("Seçiminiz: Çarpma");
                    Console.WriteLine("Çarpımı: " + hm.çarp(sayı1, sayı2));
                    break;
                case 4:
                    Console.WriteLine("Seçiminiz: Bölme");
                    Console.WriteLine("Bölümü: " + hm.böl(sayı1, sayı2));
                    break;
                case 5:
                    Console.WriteLine("Seçiminiz: Çarpma işlemini toplama ile yapma");
                    Console.WriteLine("Sonuç: " + hm.çarpTopla(sayı1, sayı2));
                    break;
                case 6:
                    Console.WriteLine("Seçiminiz : Bölme işlemini çıkarma ile yapma ");
                    Console.WriteLine("Sonuç: " + hm.bölÇıkar(sayı1, sayı2));
                    break;
                default:
                    Console.WriteLine("Hatalı sayı tuşladınız. Lütfen tekrar seçim yapınız.");
                    goto tekrar;
            }

            Console.ReadKey();
        }
        static void menüGöster()
        {
            Console.WriteLine("Hangi aritmetik işlemi yapmak istersiniz?");
            Console.WriteLine("1:Toplama \n" +
                "2: Çıkarma \n" +
                "3-Çarpma \n" +
                "4-Bölme \n" +
                "5-Çarpma işlemini toplama ile yapma \n" +
                "6-Bölme işlemini çıkarma ile yapma \n ");

        }

    }
}
