using System;

namespace Soru4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 24;
            int y = 11;
            int z = 34;
            bool işlem1 = 23 == 55 && 76 > 45 && 5 < 12; // 23 55 e eşit olmadığı için devamına bakılmaz. False
            Console.WriteLine(işlem1);
            bool işlem2 = 23 >= 23 && 45 != 18; //23 23 e eşit olduğu için ilk kısım doğrudur. 45de 18 e eşit olmadığı için doğrudur. True çıktı verir
            Console.WriteLine(işlem2);
            bool işlem3 = x > y && z == y && z < x; //24 11den büyük olduğu için ilk kısım doğrudur. fakat 34 11 e eşit olmadığı için yanlıştır. 
            //Biri doğru biri yanlış olduğu için sonuç yanlıştır devamına bakılmaz.False
            Console.WriteLine(işlem3);
            bool işlem4 = z > x && y < x; //34 24 ten büyük olduğu için ilk kısım doğrudur. 11 24ten küçük olduğu için ikinci kısımda doğrudur.
            //o yüzden true çıkış verir.
            Console.WriteLine(işlem4);
            Console.ReadKey();
        }
    }
}
