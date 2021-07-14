using System;
using System.Collections.Generic;
using System.Text;

namespace Soru23
{
    abstract class Geometri
    {
        public string tür;
        public int kenarSayisi;
        int içAcilarToplami;
        public int _içAcilarToplami
        {
            set {
                if (içAcilarToplami<0) {
                    içAcilarToplami = 0;
                }
                else {
                    içAcilarToplami = içAcilarToplami;
                }
            }
            get {
                return içAcilarToplami;
            }
        }

        int disAcilarToplami;
        public int _disAcilarToplami {
            set {
                if (disAcilarToplami < 0) {
                    disAcilarToplami = 0;
                }
                else {
                    disAcilarToplami = disAcilarToplami;
                }
            }
        }
         
        abstract public double alanHesapla();

        abstract public int enBüyükKenarıBul();




    }
}
