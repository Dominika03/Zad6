using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etykiety
{
    public class SpecjalistaHR : Pracownik
    {
        public bool Kierownik { get; }

        public SpecjalistaHR(string imie, string nazwisko, bool kierownik = false) : base(imie, nazwisko, "HR")
        {
             Kierownik = kierownik;
        }
        public override string PrzedstawSie()
        {
           return $"Specjalista {Imie} {Nazwisko} {(Kierownik ? "(Kierownik)" : "")}";
        }

        public override string OpisObowiazkow()
        {
            return "Dbanie o zasoby ludzkie";
        }
        public override string OcenaPracownika()
        {
            return "Ocena specjalisty HR: skuteczność rekrutacji i rozwój pracowników";
        }

    }
}
     

     

