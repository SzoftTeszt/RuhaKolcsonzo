namespace RuhaKolcsonzo.Data.Models;

public class Kolcsonzes
{
    public int Id { get; set; }

    public int UgyfelId { get; set; }
    public Ugyfel Ugyfel { get; set; } = null!;

    public int RuhaId { get; set; }
    public Ruha Ruha { get; set; } = null!;

    public DateTime Kezdet { get; set; }
    public DateTime TervezettVissza { get; set; }
    public DateTime? VisszahozasDatuma { get; set; }
}
