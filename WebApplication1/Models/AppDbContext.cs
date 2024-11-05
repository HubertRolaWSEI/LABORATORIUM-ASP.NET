using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models;

public class AppDbContext : DbContext
{
    public DbSet<ContactEntity> Contacts { get; set; }

    private string DbPath { get; set; }

    public AppDbContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "contacts.db");

    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite($"Data Source={DbPath}");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ContactEntity>()
            .HasData(
                new ContactEntity()
                {
                    Id = 1,
                    FirstName = "Hubert",
                    LastName = "Rola",
                    Email = "hubert.rola@microsoft.wsei.edu.pl",
                    PhoneNumber = "999 999 999",
                    Created = DateTime.Now,
                },
                new ContactEntity()
                {
                    Id = 2,
                    FirstName = "Karol",
                    LastName = "Dominiak",
                    Email = "karol@malpa.pl",
                    PhoneNumber = "999 999 999",
                    Created = DateTime.Now,

                }
            );
    }
}         