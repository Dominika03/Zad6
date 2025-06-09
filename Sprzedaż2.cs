using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etykiety
{
    public class AnalitykRegionu : Pracownik
    {

        public bool Kierownik { get; }

        public AnalitykRegionu(string imie, string nazwisko, bool kierownik = false) : base(imie, nazwisko, "Sprzedarz")
        {
            Kierownik = kierownik;
        }
        public override string PrzedstawSie()
        {
            return $"Przedstawiciel handlowy {Imie} {Nazwisko} {(Kierownik ? "(Kierownik)" : "")}";
        }

        public override string OpisObowiazkow()
        {
            return "Analiza danych sprzedarzy z poszczególnych regionów";
        }
        public override string OcenaPracownika()
        {
            return "Ocena analityka: trafność analiz, skuteczność rekomendacji i wsparcie decyzyjne";
        }
    }
}