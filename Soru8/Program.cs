using System;

namespace Soru8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Derece giriniz.");
            double derece = Convert.ToDouble(Console.ReadLine());
            double radyan = derece * (Math.PI / 180);
            double gradyan = (derece * 200) / 180;
            Console.WriteLine(derece + " derece : " + radyan + " radyandır.");
            Console.WriteLine(derece + " derece : " + gradyan + " gradyandır.");
            Console.ReadKey();
        }
    }
}
