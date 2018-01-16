using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarsztatSamochodowy
{
    static class Warsztat
    {
        private static List<Samochod> lista = new List<Samochod>();

        public static void DodajDoListy(Marka marka, string rejestracja, string usterka)
        {
            int temp = 0;
            lista.Add(Samochod.StworzSamochod(marka, rejestracja, usterka));
            for (int i = 0; i < lista.Count-1; i++)
            {
                for (int j = 0; j < lista.Count-1; j++)
                {
                    temp = 0;
                    if ((lista[i].PobierzRejestracje() == lista[j].PobierzRejestracje()) && (lista[i].PobierzMarke() != lista[j].PobierzMarke()))
                    {
                        temp = 2;
                    }
                }
            }
            if (temp == 2)
                Console.WriteLine("KRYMINAŁ!!! NA LISCIE ZNAJDUJE SIE SAMOCHOD O TYCH SAMYCH TABLICAch a kurwa marka TO juz inna pany! Juz dzwonimy do płokułatuły!");

        }
        public static void DrugaUsterka(string rejestracja, string nowaUsterka)
        {
            foreach (Samochod t in lista)
            {
                if (t.PobierzRejestracje() == rejestracja)
                {
                    Samochod auto = t.SkopiujSamochod();
                    auto.ZmienUsterke(nowaUsterka);
                    lista.Add(auto);
                    break;
                }
            }
        }
        public static void WykonajNaprawe(int ile)
        {
            if (ile <= lista.Count)
            {
                for (int i = 0; i < ile; i++)
                    lista.RemoveAt(lista.Count - 1);
            }
            else
                Console.WriteLine("Wiecej Samochodów niż rozumu masz kurwa!");
        }
        public static void WykonajNaprawe(string rejestracja)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].PobierzRejestracje() == rejestracja)
                    lista.RemoveAt(i);
            }
        }
        public static void Info()
        {
            foreach (Samochod t in lista)
                Console.WriteLine(t.Info());
        }
    }
}
