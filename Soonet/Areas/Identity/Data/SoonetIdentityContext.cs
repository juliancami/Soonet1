using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Soonet.Areas.Identity.Data;
using System.Reflection.Emit;

namespace Soonet.Data;

public class SoonetIdentityContext : IdentityDbContext<SoonetUser>
{
    public SoonetIdentityContext(DbContextOptions<SoonetIdentityContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);


        builder.Entity<IdentityRole>().HasData(
            new IdentityRole() { Name = "Admin",NormalizedName = "ADMIN"},
            new IdentityRole() { Name = "User", NormalizedName = "USER"},
            new IdentityRole() { Name = "Provider", NormalizedName = "PROVIDER"}
        );


    }
}
