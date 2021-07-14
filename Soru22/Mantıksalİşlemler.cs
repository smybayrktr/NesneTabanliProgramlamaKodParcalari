using System;
using System.Collections.Generic;
using System.Text;

namespace Soru22
{
    class Mantıksalİşlemler
    {

        public byte bitselVe(int sayı1, int sayı2)
        {
            byte sonuç = (byte)(sayı1 & sayı2);
            return sonuç;
        }

        public byte bitselVeya (int sayı1, int sayı2)
        {
            byte sonuç = (byte)(sayı1 | sayı2);
            return sonuç;
        }

        public byte bitselXOR (int sayı1, int sayı2)
        {
            byte sonuç = (byte)(sayı1 ^ sayı2);
            return sonuç;
        }

    }
}
