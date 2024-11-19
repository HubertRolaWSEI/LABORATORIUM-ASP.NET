using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models;

public class AppDbContext: IdentityDbContext<IdentityUser>
{
    public DbSet<ContactEntity> Contacts {
        get;
        set;
    }

    public DbSet<OrganizationEntity> Organizations { get; set; }
    
    
    private string DbPath { get; set; }
    public AppDbContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "contacts.db");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite($"Data source={DbPath}");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        string ADMIN_ID = Guid.NewGuid().ToString();
        string USER_ID = Guid.NewGuid().ToString();
        
        modelBuilder.Entity<IdentityRole>().HasData(
            new IdentityRole
            {
                Id = ADMIN_ID,
                Name = "Admin",
                NormalizedName = "ADMIN"
            },
            new IdentityRole
            {
                Id = USER_ID,
                Name = "User",
                NormalizedName = "USER"
            }
        );

        var Admin = new IdentityUser
        {
            Id = ADMIN_ID,
            UserName = "admin",
            NormalizedUserName = "ADMIN",
            Email = "adam@wsei.edu.pl",
            NormalizedEmail = "adam@wsei.edu.pl",
            EmailConfirmed = true,
        };
        
        PasswordHasher<IdentityUser> hasher = new PasswordHasher<IdentityUser>();
        Admin.PasswordHash = hasher.HashPassword(Admin, "1234");
        
        modelBuilder.Entity<IdentityUser>().HasData(Admin);
        
        var User = new IdentityUser
        {
            Id = USER_ID,
            UserName = "user",
            NormalizedUserName = "USER",
            Email = "hubert@wsei.edu.pl",
            NormalizedEmail = "hubert@wsei.edu.pl",
            EmailConfirmed = true,
        };
        
        User.PasswordHash = hasher.HashPassword(User, "1234");
        modelBuilder.Entity<IdentityUser>().HasData(User);
        
        modelBuilder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string>
            {
                RoleId = ADMIN_ID,
                UserId = ADMIN_ID
            },
            new IdentityUserRole<string>
            {
                RoleId = USER_ID,
                UserId = USER_ID
            }
        );

        
        modelBuilder.Entity<OrganizationEntity>()
            .OwnsOne(o => o.Address)
            .HasData(
                new { OrganizationEntityId = 1, City = "Kraków", Street = "Długa 1" },
                new { OrganizationEntityId = 2, City = "Kraków", Street = "Osiedle Zgody 3" }
            );
        
        modelBuilder.Entity<ContactEntity>()
            .HasOne<OrganizationEntity>(c => c.Organization)
            .WithMany(o => o.Contacts)
            .HasForeignKey(c => c.OrganizationId);


        modelBuilder.Entity<OrganizationEntity>()
            .HasData(
                new OrganizationEntity()
        {
            Id = 1,
            Regon = "73276",
            Nip = "1234567890",
            Name = "WSEI"
        },
                new OrganizationEntity()
                
                {
                    Id = 2,
                    Regon = "7322134",
                    Nip = "1234567894210",
                    Name = "POLIBUDA"
                }
            );
        
        
        modelBuilder.Entity<ContactEntity>()
            .HasData(
                new ContactEntity()
                {
                    Id = 1,
                    FirstName = "Adam",
                    LastName = "Nowak",
                    BirthDate = new(2000, 10, 10),
                    PhoneNumber = "333 333 333",
                    Email = "adam@.wsei.edu.pl",
                    Created = DateTime.Now,
                    OrganizationId = 1
                    
                },
                new ContactEntity()
                {
                    Id = 2,
                    FirstName = "Ada",
                    LastName = "Fisak",
                    BirthDate = new(2000, 11, 10),
                    PhoneNumber = "333 333 333",
                    Email = "ada@.wsei.edu.pl",
                    Created = DateTime.Now,
                    OrganizationId = 2
                }
            );
    }
}