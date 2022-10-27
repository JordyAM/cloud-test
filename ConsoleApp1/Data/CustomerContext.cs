using CustomerInfo.Models;

using Microsoft.EntityFrameworkCore;

namespace CustomerInfo.Data;

public class CustomerContext : DbContext
{
    public DbSet<Customer> Customers { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-586K36T\JMCLEAN;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
    }
}