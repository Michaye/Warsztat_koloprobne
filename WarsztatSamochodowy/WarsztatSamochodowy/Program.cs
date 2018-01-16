using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarsztatSamochodowy
{
    enum Marka
    {
        Opel, Skoda, Ford, Fiat
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Samochod> list = new List<Samochod>();
            Marka marka;
            while (true)
            {
                startLabel:
                char klawisz = ' ';
                Console.WriteLine("Witaj w warsztacie!");
                Console.WriteLine("A-Dodaj samochód do naprawy");
                Console.WriteLine("B-Dodaj drugą usterke");
                Console.WriteLine("C-Wykonaj naprawe");
                Console.WriteLine("X-Wyjdź");
                klawisz = Convert.ToChar(Console.ReadLine());
                switch(klawisz)
                {
                    case 'A':
                        Console.Write("Podaj marke(Opel,Skoda,Ford,Fiat): ");
                        markaLabel:
                        string markastr = Console.ReadLine();
                        if(string.IsNullOrEmpty(markastr)==true)
                        {
                            Console.WriteLine("Nie wprowadzono marki! Wprowadź ponownie: ");
                            goto markaLabel;
                        }
                        switch(markastr)
                        {
                            case "Opel":
                                marka = Marka.Opel;
                                break;
                            case "Skoda":
                                marka = Marka.Skoda;
                                break;
                            case "Ford":
                                marka = Marka.Ford;
                                break;
                            case "Fiat":
                                marka = Marka.Fiat;
                                break;
                            default:
                                Console.WriteLine("Błąd!");
                                goto startLabel;
                        }
                        Console.WriteLine("Podaj nr rejestracji: ");
                        rejLabel:
                        string rej = Console.ReadLine();
                        if (string.IsNullOrEmpty(rej) == true)
                        {
                            Console.WriteLine("Nie wprowadzono rejestracji! Wprowadź ponownie: ");
                            goto rejLabel;
                        }
                        Console.WriteLine("Podaj usterke: ");
                        usterkaLabel:
                        string usterka = Console.ReadLine();
                        if (string.IsNullOrEmpty(usterka) == true)
                        {
                            Console.WriteLine("Nie wprowadzono usterki! Wprowadź ponownie: ");
                            goto usterkaLabel;
                        }
                        Warsztat.DodajDoListy(marka,rej,usterka);
                        break;
                    case 'B':
                        Console.WriteLine("Podaj rejestracje samochodu: ");
                        string rej2 = Console.ReadLine();
                        if (string.IsNullOrEmpty(rej2) == true)
                        {
                            Console.WriteLine("Nie wprowadzono rejestracji!");
                            goto case 'B';
                        }
                        Console.WriteLine("Podaj drugą usterke: ");
                        usterka2Label:
                        string usterka2 = Console.ReadLine();
                        if (string.IsNullOrEmpty(usterka2) == true)
                        {
                            Console.WriteLine("Nie wprowadzono usterki! Wprowadź ponownie: ");
                            goto usterka2Label;
                        }
                        Warsztat.DrugaUsterka(rej2,usterka2);
                        break;
                    case 'D':
                        Warsztat.Info();
                        break;
                    case 'C':
                        Console.WriteLine("Wykonać naprawe po rejestracji?(T/N)");
                        char kontrola = Convert.ToChar(Console.ReadLine());
                        if (kontrola == 'T')
                        {
                            Console.WriteLine("Podaj nr rejestracji: ");
                            rej = Console.ReadLine();
                            if (string.IsNullOrEmpty(rej) == true)
                            {
                                Console.WriteLine("Nie wprowadzono rejestracji! Wprowadź ponownie: ");
                                goto case 'C';
                            }
                            Warsztat.WykonajNaprawe(rej);
                        }
                        else
                        {
                            Console.WriteLine("Podaj ilosc aut do naprawy: ");
                            int liczbaAut = Convert.ToInt32(Console.ReadLine());
                            Warsztat.WykonajNaprawe(liczbaAut);
                        }
                        break;
                    case 'X':
                        Environment.Exit(1);
                        break;
                }
            }

        }
    }
}
