using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etykiety
{
    public class KirownikRegionu : Pracownik
    {

        public bool Kierownik { get; }

        public KirownikRegionu(string imie, string nazwisko, bool kierownik = false) : base(imie, nazwisko, "Sprzedarz")
        {
            Kierownik = kierownik;
        }
        public override string PrzedstawSie()
        {
            return $"Przedstawiciel handlowy {Imie} {Nazwisko} {(Kierownik ? "(Kierownik)" : "")}";
        }

        public override string OpisObowiazkow()
        {
            return "Zrządzanie zespołem sprzedarzowym w danym regionie";
        }
        public override string OcenaPracownika()
        {
            return "Ocena kierownika regionu: wyniki zespołu, jakość zarządzania oraz rozwój rynku lokalnego";
        }
    }
}
