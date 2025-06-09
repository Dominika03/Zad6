using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etykiety
{
    public class Rekruter : Pracownik
    {
        public bool Kierownik { get; }

        public Rekruter(string imie, string nazwisko, bool kierownik = false) : base(imie, nazwisko, "HR")
        {
            Kierownik = kierownik;
        }
        public override string PrzedstawSie()
        {
            return $"Rekruter {Imie} {Nazwisko} {(Kierownik ? "(Kierownik)" : "")}";
        }

        public override string OpisObowiazkow()
        {
            return "Rekrutowanie nowych pracowników";
        }
        public override string OcenaPracownika()
        {
            return "Ocena rekrutera: liczba udanych zatrudnień, jakość dopasowania kandydatów i efektywność procesu rekrutacji";
        }

    }
}
