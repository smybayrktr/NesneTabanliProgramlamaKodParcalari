using System;

namespace Soru7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a değerini giriniz");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b değerini giriniz");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("c değerini giriniz");
            int c = Convert.ToInt32(Console.ReadLine());
            double delta = b * b - 4 * a * c;
            if (delta < 0)
            {
                Console.WriteLine("Reel kök yoktur");
            }
            else if (delta == 0)
            {
                double kök = -b / 2 * a;
                Console.WriteLine("Tek kök vardır. Kök:" + kök);
            }
            else
            {
                double kök1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double kök2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("İki tane reel kök vardır. Kök 1: " + kök1 + "Kök 2:" + kök2);
            }
            Console.ReadKey();
        }
    }
}
