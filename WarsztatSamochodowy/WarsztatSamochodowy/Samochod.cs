using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarsztatSamochodowy
{
    class Samochod
    {
        private Marka marka;
        private string rejestracja;
        private string usterka;

        public string PobierzRejestracje()
        {
            return rejestracja;
        }
        private Samochod(Marka marka,string rejestracja,string usterka)
        {
            this.marka = marka;
            this.rejestracja = rejestracja;
            this.usterka = usterka;
        }
        public Samochod SkopiujSamochod()
        {
            Samochod samochodClone = new Samochod(this.marka,this.rejestracja,this.usterka);
            return samochodClone;
        }
        public static Samochod StworzSamochod(Marka marka, string rejestracja, string usterka)
        {
            Samochod nowysamochod = new Samochod(marka,rejestracja,usterka);
            return nowysamochod;
        }
        public void ZmienUsterke(string usterka)
        {
            this.usterka = usterka;
        }
        public string Info()
        {
            return marka + " " + rejestracja + " " + usterka;
        }
        public string PobierzMarke()
        {
            return marka.ToString();
        }
    }
}
