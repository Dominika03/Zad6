using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etykiety
{
    public class KontrolerJakości : Pracownik
    {
        public bool Kierownik { get; }

        public KontrolerJakości(string imie, string nazwisko, bool kierownik = false) : base(imie, nazwisko, "Produkcja")
        {
            Kierownik = kierownik;
        }

        public override string PrzedstawSie()
        {
            return $"Inżynier {Imie} {Nazwisko} {(Kierownik ? "(Kierownik)" : "")}";
        }

        public override string OpisObowiazkow()
        {
            return "Dopilnowanie przestrzegania norm i standardów oraz dbanie o jakość produktów";
        }
        public override string OcenaPracownika()
        {
            return "Ocena kontrolera jakości: skuteczność wykrywania błędów i zgodność z procedurami";
        }

    }
}
