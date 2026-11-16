using System.ComponentModel.DataAnnotations;

namespace RuhaKolcsonzo.Data.Models;

public class Ruha
{
    public int Id { get; set; }

    [Required, StringLength(120)]
    public string Megnevezes { get; set; } = string.Empty;

    [Required, StringLength(50)]
    public string Kategoria { get; set; } = string.Empty;

    [Required, StringLength(10)]
    public string Meret { get; set; } = string.Empty;

    public int NapiDij { get; set; }

    public List<Kolcsonzes> Kolcsonzesek { get; set; } = new();

    public override string ToString() => $"{Megnevezes} ({Meret})";
}
