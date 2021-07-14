using System;
using System.Collections.Generic;
using System.Text;

namespace Soru21
{
    class HesapMakinesi
    {

        public double topla(double sayı1, double sayı2)
        {
            return sayı1 + sayı2;
        }

        public double çıkar (double sayı1, double sayı2)
        {
            return sayı1 - sayı2;

        }

        public double çarp (double sayı1, double sayı2)
        {
            return sayı1 * sayı2;
        }

        public string böl (double sayı1, double sayı2)
        {
            if (sayı2==0)
            {
                return "Payda 0 olamaz.";
            }
            else
            {
                double sonuç = sayı1 / sayı2;
                return sonuç.ToString(
);
            }
        }

        public double çarpTopla(double sayı1, double sayı2)
        {
            double top = 0;
            for (int i = 1; i <=sayı2 ; i++)
            {
                top += sayı1;
            }
            return top;
        }

        public string bölÇıkar (double sayı1, double sayı2)
        {
            if (sayı2 !=0)
            {
                int sayaç = 0;
                double a = 0;
                for (; ; )
                {
                    if (sayı1 >= 0)
                    {
                        a = sayı1 - sayı2;
                        sayaç++;
                        sayı1 = a;
                    }
                    else
                    {
                        break;
                    }
                }
                var sonuç = sayaç - 1;
                return sonuç.ToString();
            }
            else
            {
                return "Payda 0 olamaz.";
            }
            
        }

    }
}
