using Microsoft.EntityFrameworkCore;
using RuhaKolcsonzo.Data.Models;

namespace RuhaKolcsonzo.Data.Data;

public class RuhaKolcsonzoContext : DbContext
{
    public DbSet<Ugyfel> Ugyfelek { get; set; }
    public DbSet<Ruha> Ruhak { get; set; }
    public DbSet<Kolcsonzes> Kolcsonzesek { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            @"Server=(localdb)\MSSQLLocalDB;Database=RuhaKolcsonzoDb20261116;Trusted_Connection=True;TrustServerCertificate=True;");
    }
}
