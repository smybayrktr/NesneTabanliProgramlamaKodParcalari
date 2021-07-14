using System;

namespace Soru20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******SİTEMİZE HOŞGELDİNİZ**********");
            Console.WriteLine("10 haneli cep telefonunuzu giriniz.");
            long cepTelNo = Convert.ToInt64(Console.ReadLine());
            int basamakToplamı = 0;
            int fibonacciDeğeri;
            int s;
            numaraDoğruMu();
            numaraRakamlarToplamı();
            fibonacciGöster();
            asal();

            Console.WriteLine("Şifreniz: " + s + "" + fibonacciDeğeri);

            void numaraDoğruMu()
            {
                int beşMi = (int)(cepTelNo / 1000000000);
                int basamakSayısı = 1;
                for (long i = 10; i <= 1000000000; i *= 10)
                {
                    int değer = (int)(cepTelNo / i);
                    basamakSayısı++;
                }
                if (beşMi == 5 && basamakSayısı == 10)
                {
                    Console.WriteLine("Telefon numarası doğru girilmiştir...");
                }
                else
                {
                    Console.WriteLine("Hatalı cep telefonu girdiniz.Lütfen tekrar deneyiniz.");
                }

            }

            void numaraRakamlarToplamı()
            {

                while (cepTelNo > 0)
                {
                    basamakToplamı = basamakToplamı + (int)(cepTelNo % 10);
                    cepTelNo /= 10;
                }
                Console.WriteLine(basamakToplamı);

            }

            void fibonacciGöster()
            {
                fibonacciDeğeri = 0;
                int birinci = 0;
                int ikinci = 1;
                int toplam = 0;
                for (int i = 0; i <= basamakToplamı; i++)
                {
                    toplam = birinci + ikinci;
                    ikinci = birinci;
                    birinci = toplam;
                    while (i == basamakToplamı)
                    {
                        fibonacciDeğeri = toplam;
                        Console.WriteLine("Fibonnaci değeri : " + fibonacciDeğeri);
                        break;
                    }

                }
            }

            void asal()
            {
                int girilenSayi = 1;
                int kacinci = 0;
                for (s = 1; s <= girilenSayi; s++)
                {
                    int sayac = 0;
                    for (int y = 1; y <= girilenSayi; y++)
                    {
                        if (s % y == 0) sayac += 1;
                    }
                    if (sayac == 2)
                    {
                        kacinci++;
                        if (kacinci == basamakToplamı)
                        {
                            Console.WriteLine("{0} sıradaki asal Sayı={1}", kacinci, s);
                            break;
                        }
                    }
                    girilenSayi++;

                }
            }

            Console.ReadKey();

        }
    }
}
