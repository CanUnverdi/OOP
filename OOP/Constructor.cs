using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP
{
    public class Constructor

    {
        int yasi;
        string adi;
        string soyadi;
        string kullandigiDil;

        //Hiç parametre almayan constructur
        public Programci()
        {
            this.adi = null;
            this.yasi = 0;
            this.soyadi = null;
            this.kullandigiDil = null;
        }


        //İsmi ve yaşi alan constructor
        public Programci(int yasi, string adi)
        {
            this.adi = adi;
            this.yasi = yasi;
            this.soyadi = null;
            this.kullandigiDil = null;
        }

        //İsmini, soyismini kullandığı dili yaşı parametre alan constructor
        public Programci(int yasi, string adi, string soyadi, string kullandigiDil)
        {
            this.adi = adi;
            this.soyadi = soyadi;
            this.yasi = yasi;
            this.kullandigiDil = kullandigiDil;
        }
