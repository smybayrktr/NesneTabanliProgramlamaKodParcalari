using System;

namespace Soru23
{
    class Program
    {
        static void Main(string[] args)
        {
            etiket:
            Console.WriteLine("Hangi geometrik şekili seçmek istersiniz?");
            Console.WriteLine("1-üçgen \n" +
                              "2-kare \n " +
                              "3-dikdörtgen \n " +
                              "4-yamuk \n");
            int seçim = Convert.ToInt32(Console.ReadLine());
            switch(seçim) {
                case 1:
                    üçgenİşlemleri();
                    break;
                case 2:
                    kareİşlemleri();
                    break;
                case 3:
                    dikdörtgenİşlemleri();
                    break;
                case 4:
                    yamukİşlemleri();
                    break;
                default:
                    Console.WriteLine("Hatalı seçim yaptınız.1-4 arası seçim yapınız.");
                    goto etiket;
            }


            Console.ReadKey();


        }
        public static void üçgenİşlemleri ()  {
            Console.WriteLine("Üçgen seçimini yaptınız.");
            Console.WriteLine("Üçgenin yüksekliğini giriniz.");
            int yükseklik = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Üçgenin taban uzunluğunu giriniz.");
            int taban = Convert.ToInt32(Console.ReadLine());
            Üçgen üçgen = new Üçgen(taban, yükseklik);
            Console.WriteLine("Üçgenin alanı :" + üçgen.alanHesapla());
            Console.WriteLine("Üçgenin kenar sayısı : " + Üçgen.kenarSayısı);
            Console.WriteLine("Girdiğiniz en büyük kenar uzunluğu : " + üçgen.enBüyükKenarıBul());
        }

        public static void kareİşlemleri()
        {
            Console.WriteLine("Kare seçini yaptınız.");
            Console.WriteLine("Karenin kenarını giriniz.");
            int kenar1 = Convert.ToInt32(Console.ReadLine());
            Kare kare = new Kare();
            Dörtgen dörtgen = new Dörtgen(kare, kenar1);
            Console.WriteLine("Alan:" + dörtgen.alanHesapla());
            Console.WriteLine("Karenin tüm kenarları eşit uzunluktadır. Kenar : " + dörtgen.enBüyükKenarıBul());
            Console.WriteLine("Karenin kenar sayısı : " + Dörtgen.kenarSayısı);
            Console.WriteLine("Karenin hacmi : " + dörtgen.hacimHesapla(kare));

        }

        public static void dikdörtgenİşlemleri () {
            Console.WriteLine("Dikdörtgen seçini yaptınız.");
            Console.WriteLine("Birinci kenarını giriniz.");
            int kenar1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci kenarını giriniz.");
            int kenar2 = Convert.ToInt32(Console.ReadLine());
            Dikdörtgen dikdörtgen = new Dikdörtgen();
            Dörtgen dörtgen = new Dörtgen(dikdörtgen, kenar1,kenar2);
            Console.WriteLine("Alan:" + dörtgen.alanHesapla());
            Console.WriteLine("En büyük kenar: " + dörtgen.enBüyükKenarıBul());
            Console.WriteLine("Dikdörtgenin kenar sayısı : " + Dörtgen.kenarSayısı);
            Console.WriteLine("Dikdörtgenin hacmi : " + dörtgen.hacimHesapla(dikdörtgen));
        }

        public static void yamukİşlemleri ()
        {
            Console.WriteLine("Yamuk seçini yaptınız.");
            Console.WriteLine("Birinci kenarını giriniz.");
            int kenar1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci kenarını giriniz.");
            int kenar2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Üçüncü kenarını giriniz.");
            int kenar3 = Convert.ToInt32(Console.ReadLine());
            Yamuk yamuk = new Yamuk();
            Dörtgen dörtgen = new Dörtgen(yamuk, kenar1, kenar2,kenar3);
            Console.WriteLine("Alan:" + dörtgen.alanHesapla());
            Console.WriteLine("En büyük kenar: " + dörtgen.enBüyükKenarıBul());
            Console.WriteLine("Yamuğun kenar sayısı : " + Dörtgen.kenarSayısı);
            Console.WriteLine("Yamuğun hacmi : " + dörtgen.hacimHesapla(yamuk));

        }
    }
}
