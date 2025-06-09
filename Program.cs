using System;
using System.Data.SQLite;
namespace Etykiety
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Baza danych
            using (var conn = new SQLiteConnection("Data Source=complinex.db"))
            {
                conn.Open();
                var cmd = new SQLiteCommand("CREATE TABLE IF NOT EXISTS Pracownicy (Imie TEXT, Nazwisko TEXT, Dzial TEXT)", conn);
                cmd.ExecuteNonQuery();
            }
            Console.WriteLine("Baza danych została utworzona");
            //Produkcja
            Random random = new Random();
            var I1 = new InzynierProdukcji("Beata", "Paździedż", random.Next(2) == 0);
            var I2 = new InzynierProdukcji("Karolina", "Jurecki", random.Next(2) == 0);
            var O1 = new OperatorMaszyn("Anton", "Smith", false);
            var O2 = new OperatorMaszyn("Karol", "Karolczyk", false);
            var O3 = new OperatorMaszyn("Jakub", "Andrzej", false);
            var O4 = new OperatorMaszyn("Martyna", "Stepczyk", false);
            var K1 = new KontrolerJakości("Andrew", "Johnny", random.Next(2) == 0);
            var K2 = new KontrolerJakości("Pamela", "Johanson", random.Next(2) == 0);
            //Sprzedarz
            var P1 = new PrzedstawicielHandlowy("Elisabeth", "Black-Montgomery", false);
            var P2 = new PrzedstawicielHandlowy("Izabela", "Stepczyk", false);
            var A1 = new AnalitykRegionu("Agnieszka", "Bednarek", false);
            var A2 = new AnalitykRegionu("Rafał", "Kozyra", false);
            var K = new KirownikRegionu("Adam", "O'Donell", true);
            //HR
            var H1 = new SpecjalistaHR("Anna", "Kowalczyk", true);
            var H2 = new Rekruter("Mikołaj", "Frączewski", false);
            //rejest
            Rejestr rejestr = new Rejestr();
            rejestr.Dodaj(I1);
            rejestr.Dodaj(I2);
            rejestr.Dodaj(O1);
            rejestr.Dodaj(O2);
            rejestr.Dodaj(O3);
            rejestr.Dodaj(O4);
            rejestr.Dodaj(K1);
            rejestr.Dodaj(K2);
            rejestr.Dodaj(P1);
            rejestr.Dodaj(P2);
            rejestr.Dodaj(A1);
            rejestr.Dodaj(A2);
            rejestr.Dodaj(K);
            rejestr.Dodaj(H1);
            rejestr.Dodaj(H2);
            //tworzenie projektu
            var projekty = new Projekty ("Optymalizacja kas samoobsługowychw sklepach sieci Biedronka", H1);
            projekty.Dodaj(I1);
            projekty.Dodaj(O2);
            projekty.Dodaj(O3);
            projekty.Dodaj(H1);
            projekty.Opis();
            //Wyświetlanie reestru
            Console.WriteLine("REJESTR WSZYSTKICH PRACOWNIKÓW");
            rejestr.Wszyscy();
           
        }
    }
}
