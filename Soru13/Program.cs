using System;

namespace Soru13
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bir kelime giriniz.");
            string kelime = Console.ReadLine();
            char[] dizi = new char[kelime.Length + 1];
            for (int i = 0; i < kelime.Length; i++)
            {
                dizi[i] = kelime[i];
                if (dizi[i] == dizi[i + 1])
                {
                    dizi[i + 1] = 'x';
                }
            }
            Array.Sort(dizi);
            foreach (char sıralıDizi in dizi)
            {
                Console.WriteLine("Harflerin sıralanmış hali :" + sıralıDizi + " , ");
            }

            Console.ReadKey();
        }
    }
}
