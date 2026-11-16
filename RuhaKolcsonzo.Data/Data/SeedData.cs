using RuhaKolcsonzo.Data.Models;
using System.Globalization;

namespace RuhaKolcsonzo.Data.Data;

public static class SeedData
{
    public static void Betoltes()
    {
        using RuhaKolcsonzoContext db = new();

        if (!db.Ugyfelek.Any())
        {
            string path = Path.Combine(AppContext.BaseDirectory, "Data", "ugyfelek.csv");

            foreach (string sor in File.ReadAllLines(path))
            {
                if (string.IsNullOrWhiteSpace(sor)) continue;
                string[] a = sor.Split(';');

                db.Ugyfelek.Add(new Ugyfel
                {
                    Nev = a[0].Trim(),
                    Telefon = a[1].Trim(),
                    Email = a[2].Trim()
                });
            }

            db.SaveChanges();
        }

        if (!db.Ruhak.Any())
        {
            string path = Path.Combine(AppContext.BaseDirectory, "Data", "ruhak.csv");

            foreach (string sor in File.ReadAllLines(path))
            {
                if (string.IsNullOrWhiteSpace(sor)) continue;
                string[] a = sor.Split(';');

                db.Ruhak.Add(new Ruha
                {
                    Megnevezes = a[0].Trim(),
                    Kategoria = a[1].Trim(),
                    Meret = a[2].Trim(),
                    NapiDij = int.Parse(a[3].Trim())
                });
            }

            db.SaveChanges();
        }

        if (!db.Kolcsonzesek.Any())
        {
            string path = Path.Combine(AppContext.BaseDirectory, "Data", "kolcsonzesek.csv");

            foreach (string sor in File.ReadAllLines(path))
            {
                if (string.IsNullOrWhiteSpace(sor)) continue;
                string[] a = sor.Split(';');

                db.Kolcsonzesek.Add(new Kolcsonzes
                {
                    UgyfelId = int.Parse(a[0].Trim()),
                    RuhaId = int.Parse(a[1].Trim()),
                    Kezdet = DateTime.ParseExact(a[2].Trim(), "yyyy.MM.dd", CultureInfo.InvariantCulture),
                    TervezettVissza = DateTime.ParseExact(a[3].Trim(), "yyyy.MM.dd", CultureInfo.InvariantCulture),
                    VisszahozasDatuma = string.IsNullOrWhiteSpace(a[4])
                        ? null
                        : DateTime.ParseExact(a[4].Trim(), "yyyy.MM.dd", CultureInfo.InvariantCulture)
                });
            }

            db.SaveChanges();
        }
    }
}
