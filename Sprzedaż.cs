using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etykiety
{
    public class PrzedstawicielHandlowy: Pracownik
    {

        public bool Kierownik { get; }

        public PrzedstawicielHandlowy(string imie, string nazwisko, bool kierownik = false) : base(imie, nazwisko, "Sprzedarz")
        {
            Kierownik = kierownik;
        }
        public override string PrzedstawSie()
        {
            return $"Przedstawiciel handlowy {Imie} {Nazwisko} {(Kierownik ? "(Kierownik)" : "")}";
        }

        public override string OpisObowiazkow()
        {
            return "Promowanie i sprzedaż produktów lub usług firmy";
        }
        public override string OcenaPracownika()
        {
            return "Ocena przedstawiciela handlowego: wyniki sprzedaży i relacje z klientami";
        }
    }
}
