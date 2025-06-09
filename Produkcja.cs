using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etykiety
{
    public class InzynierProdukcji : Pracownik
    {
        public bool Kierownik {  get; }
        
        public InzynierProdukcji(string imie, string nazwisko, bool kierownik = false) : base(imie, nazwisko, "Produkcja")
        {
           Kierownik = kierownik;
        }

        public override string PrzedstawSie()
        {
            return $"Inżynier {Imie} {Nazwisko} {(Kierownik ? "(Kierownik)" : "")}";
        }

        public override string OpisObowiazkow()
        {
            return "Dopilnowanie produkcji";
        }
        public override string OcenaPracownika()
        {
            return "Ocena inżyniera produkcji: efektywność projektów i innowacyjność";
        }

    }
}
