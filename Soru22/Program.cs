using System;

namespace Soru22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Birinci sayıyı giriniz.");
            int sayı1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci sayıyı giriniz.");
            int sayı2 = Convert.ToInt32(Console.ReadLine());
            tekrar:
            Console.WriteLine("Hangi işlemi yapmak istersiniz.\n" +
                "1-Bitsel ve \n" +
                "2-Bitsel veya \n" +
                "3-Bitsel XOR \n");
            int seçim = Convert.ToInt32(Console.ReadLine());
            Mantıksalİşlemler mantıksalİşlemler = new Mantıksalİşlemler();
            switch (seçim)
            {
                case 1:
                    Console.WriteLine("Seçiminiz bitsel ve");
                    Console.WriteLine("Sonuç: " + mantıksalİşlemler.bitselVe(sayı1, sayı2));
                    break;
                case 2:
                    Console.WriteLine("Seçiminiz bitsel veya");
                    Console.WriteLine("Sonuç: " + mantıksalİşlemler.bitselVeya(sayı1, sayı2));
                    break;
                case 3:
                    Console.WriteLine("Seçiniz bitsel XOR");
                    Console.WriteLine("Sonuç: " + mantıksalİşlemler.bitselXOR(sayı1, sayı2));
                    break;
                default:
                    Console.WriteLine("Hatalı seçim yaptınız.Lütfen 1-3 arası bir rakam giriniz.");
                    goto tekrar;
            }
            Console.ReadKey();
        }
    }
}
