using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etykiety
{
    public class Projekty
    {
        public string NazwaProjektu { get; }
        public Pracownik Kierownik { get; }
        public List<Pracownik> Zespol { get; } = new List<Pracownik>();
        public Projekty(string nazwaprojektu, Pracownik kierownik)
        {
            NazwaProjektu = nazwaprojektu;
            Kierownik = kierownik;
        }
        public void Dodaj(Pracownik pracownik)
        {
            Zespol.Add(pracownik);
        }
        public void Opis()
        {
            Console.WriteLine($"Projekt: {NazwaProjektu}, Kierownik: {Kierownik.PrzedstawSie()}");
            foreach (var czlonek in Zespol)
            {
                Console.WriteLine($" - {czlonek.PrzedstawSie()}");
            }
        }
    }
}
