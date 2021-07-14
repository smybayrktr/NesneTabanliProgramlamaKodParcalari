using System;

namespace Soru3
{
    class Program
    {
        static void Main(string[] args)
        {
            double işlem1 = 36 / 6 / 3;
            double işlem2 = 8 / 4 * 2;
            double işlem3 = 4 * 4 + 6 - 1 + 3;
            double işlem4 = (3 + 2) * 4 - 1 + 6 / 2;
            double işlem5 = (5 - 2) * 2 - 1 + 8 * 8 / 2;
            Console.WriteLine("36 / 6 / 3 in cevabı: " + işlem1 + " dir. Aynı işlem önceliğinde soldan sağa doğru işlemler yapılır.");
            Console.WriteLine("8 / 4 * 2 in cevabı: " + işlem2 + " dir. Aynı işlem önceliğinde soldan sağa doğru işlemler yapılır.");
            Console.WriteLine("4 * 4 + 6 - 1 + 3 in cevabı: " + işlem3 + " dir. İlk çarpma işlemi yapılır daha sonra soldan sağa işlemler yapılır.");
            Console.WriteLine("(3 + 2) * 4 - 1 + 6 / 2 in cevabı: " + işlem4 + " dir. İlk parantez içi hesaplanır solda olduğu için çarpma daha sonra bölme yapılır. ");
            Console.WriteLine("(5 - 2) * 2 - 1 + 8 * 8 / 2 in cevabı: " + işlem5 + "dir. İlk parantez içi sonra soldan sağa doğru çarpma bölmeler en sonda yine soldan sağa toplama çıkarma yapılır");
            Console.ReadKey();
        }
    }
}
