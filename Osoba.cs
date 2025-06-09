using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etykiety
{
    public abstract class Osoba
    {
        public string Imie { get; }
        public string Nazwisko { get; }
        public Osoba(string imie, string nazwisko) 
        {
            Imie = imie;
            Nazwisko = nazwisko;
        }
        public abstract string PrzedstawSie();
    }
}
