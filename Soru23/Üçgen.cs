using System;
using System.Collections.Generic;
using System.Text;

namespace Soru23
{
    class Üçgen : Geometri
    {
        public int taban;
        public int yükseklik;
        public const int kenarSayısı = 3;

        public Üçgen (int taban, int yükseklik)
        {
            this.taban = taban;
            this.yükseklik = yükseklik;
        }
        

        public override double alanHesapla()
        {
            double alan = taban * yükseklik / 2;
            return alan;
        }

        public override int enBüyükKenarıBul()
        {
            if (taban>=yükseklik) {
                return taban;
            }
            else {
                return yükseklik;
            }
            
            
        }
    }
}
