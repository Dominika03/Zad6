using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etykiety
{
    public class Rejestr
    {
        private List<Pracownik> pracownicy = new();
        public void Dodaj(Pracownik pracownik) => pracownicy.Add(pracownik);
        public List<Pracownik> Szukajpodziale(string dzial)
        {
            return pracownicy.Where(pracownik => pracownik.Dzial == dzial).ToList();
        }
        public List<Pracownik> Szukajponazwisku(string nazwisko)
        {
            return pracownicy.Where(pracownik => pracownik.Nazwisko.Contains(nazwisko)).ToList();
        }
        public void Wszyscy()
        {
            foreach (var pracownik in pracownicy)
            {
                Console.WriteLine(pracownik.PrzedstawSie());
                Console.WriteLine($"Obowiązki: {pracownik.OpisObowiazkow()}");
                Console.WriteLine(pracownik.OcenaPracownika());
                Console.WriteLine();
            }
        }
    }

}