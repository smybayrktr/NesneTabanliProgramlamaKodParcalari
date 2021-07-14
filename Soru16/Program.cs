using System;

namespace Soru16
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] genelDizi = new int[10];
            int[] pozitifDizi = new int[10];
            int[] negatifDizi = new int[10];
            int pozitifSayaç = 0;
            int negatifSayaç = 0;
            for (int i = 0; i < 10; i++)
            {
            tekrar:
                genelDizi[i] = rnd.Next(-100, 100);
                if (genelDizi[i] == 0)
                {
                    goto tekrar;
                }
                else if (genelDizi[i] < 0)
                {
                    negatifDizi[i] = genelDizi[i];
                    negatifSayaç++;
                }
                else
                {
                    pozitifDizi[i] = genelDizi[i];
                    pozitifSayaç++;
                }
            }
            Array.Resize(ref pozitifDizi, pozitifSayaç);
            Array.Resize(ref negatifDizi, negatifSayaç);
            for (int i = 1; i < negatifSayaç; i++)
            {
                Console.WriteLine("Negatif dizi elemanları: " + negatifDizi[i]);
            }
            Console.WriteLine("******************************************");
            for (int i = 1; i < pozitifSayaç; i++)
            {
                Console.WriteLine("Pozitif dizi elemanları: " + pozitifDizi[i]);
            }
            Console.ReadKey();
        }
    }
}
