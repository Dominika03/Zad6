using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etykiety
{
    public class OperatorMaszyn : Pracownik
    {
        public bool Kierownik { get; }

        public OperatorMaszyn(string imie, string nazwisko, bool kierownik = false) : base(imie, nazwisko, "Produkcja")
        {
            Kierownik = kierownik;
        }
        public override string PrzedstawSie()
        {
            return $"Operator maszyn {Imie} {Nazwisko} {(Kierownik ? "(Kierownik)" : "")}";
        }

        public override string OpisObowiazkow()
        {
            return "Obsługa maszyn";
        }
        public override string OcenaPracownika()
        {
            return "Ocena operatora maszyn: bezawaryjność pracy, przestrzeganie procedur i jakość wykonania";
        }
    }
}
