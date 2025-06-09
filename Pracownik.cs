using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etykiety
{
    public abstract class Pracownik: Osoba, Iocena
    {
        public bool Kierownik { get; }
        public string Dzial {  get; }
        public Pracownik(string imie, string nazwisko, string dzial, bool kierownik = false):base(imie, nazwisko)
        {
            Dzial = dzial;
            Kierownik = kierownik;
        }
        public abstract string OpisObowiazkow();
        public abstract string OcenaPracownika();
    }
}
