using System.ComponentModel.DataAnnotations;

namespace RuhaKolcsonzo.Data.Models;

public class Ugyfel
{
    public int Id { get; set; }

    [Required, StringLength(100)]
    public string Nev { get; set; } = string.Empty;

    [Required, StringLength(30)]
    public string Telefon { get; set; } = string.Empty;

    [Required, StringLength(120)]
    public string Email { get; set; } = string.Empty;

    public List<Kolcsonzes> Kolcsonzesek { get; set; } = new();

    public override string ToString() => Nev;
}
