using Microsoft.EntityFrameworkCore;

public class AppContext : DbContext
{
    public DbSet<AdminAccount> AdminAccounts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
        builder.UseNpgsql(Initialize.Database());
    }
}
