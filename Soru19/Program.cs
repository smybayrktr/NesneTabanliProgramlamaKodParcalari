using System;

namespace Soru19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hacmi hesaplanacak küpün kenar uzunluğunu giriniz.");
            int kenar = Convert.ToInt32(Console.ReadLine());
            int sonuç = hacimHesapla(kenar);
            Console.WriteLine("Hacim: " + sonuç);
            Console.ReadKey();
        }
        static int hacimHesapla(int kenar)
        {
            return kenar * kenar * kenar;
        }

    }
}
