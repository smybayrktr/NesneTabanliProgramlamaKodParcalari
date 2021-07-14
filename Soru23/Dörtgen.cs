using System;
using System.Collections.Generic;
using System.Text;

namespace Soru23
{
       class Dörtgen : Geometri {

        public int birinciKenar ;
        public int ikinciKenar;
        public int üçüncüKenar;
        public const int kenarSayısı = 4;
        public Kare kare;
        public Yamuk yamuk;
        public Dörtgen dörtgen;
        public Dikdörtgen dikdörtgen;

        public Dörtgen ()
        {

        }
        public Dörtgen(Dörtgen dörtgen, int birinciKenar, int ikinciKenar)
        {
            dikdörtgen = new Dikdörtgen();
            kare = new Kare();
            yamuk = new Yamuk(); 
            this.dörtgen = dörtgen;
            this.birinciKenar = birinciKenar;
            this.ikinciKenar = ikinciKenar;

        }
        public Dörtgen (Dörtgen dörtgen,int birinciKenar)
        {
            dikdörtgen = new Dikdörtgen();
            kare = new Kare();
            yamuk = new Yamuk();
            this.dörtgen = dörtgen;
            this.birinciKenar = birinciKenar;
        }
        
        public Dörtgen (Dörtgen dörtgen, int birinciKenar, int ikinciKenar, int üçüncüKenar)
        {
            yamuk = new Yamuk();
            dikdörtgen = new Dikdörtgen();
            kare = new Kare();
            this.dörtgen = dörtgen;
            this.birinciKenar = birinciKenar;
            this.ikinciKenar = ikinciKenar;
            this.üçüncüKenar = üçüncüKenar;

        }


        public override double alanHesapla()
        {
            if (dörtgen.GetType()==kare.GetType())
            {
                double alan = birinciKenar * birinciKenar;
                return alan;
            }
            else if ((dörtgen.GetType()==yamuk.GetType())) {
                double alan = (birinciKenar + üçüncüKenar) * ikinciKenar / 2;
                return alan;
            }
            else
            {
                double alan = birinciKenar * ikinciKenar;
                return alan;
            }
            
        }


        public override int enBüyükKenarıBul()
        {
            if (dörtgen.GetType()==kare.GetType()) {
                return birinciKenar;
            }
            else if (dörtgen.GetType()==yamuk.GetType()) {
                if (birinciKenar>=ikinciKenar && birinciKenar>=üçüncüKenar) {
                    return birinciKenar;
                }
                else if (ikinciKenar>= birinciKenar && ikinciKenar>=üçüncüKenar) {
                    return ikinciKenar;
                }
                else {
                    return üçüncüKenar;
                }
                }
            else {
                if (birinciKenar>ikinciKenar)
                {
                    return birinciKenar;
                }
                else
                {
                    return ikinciKenar;
                }
            }

        }

        public double hacimHesapla (Kare k)
        {
            return birinciKenar * birinciKenar * birinciKenar;
        }

        public double hacimHesapla (Dikdörtgen d)
        {
            return birinciKenar * ikinciKenar * birinciKenar;
        }

        public double hacimHesapla (Yamuk y)
        {
            return (birinciKenar * ikinciKenar * üçüncüKenar) / 2;
        }


        
    }
}
