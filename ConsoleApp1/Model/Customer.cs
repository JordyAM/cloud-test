using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Customer.Models
{
// public class CustomerContext : DbContext
// {
//     public DbSet<Customer> Customers { get; set;}

//     public string DbPath { get; }
    
//     public CustomerContext() 
//     {
//         var folder = Environment.SpecialFolder.LocalApplicationData;
//         var path = Environment.GetFolderPath(folder);
//         DbPath = System.IO.Path.Join(path, "customer.db");
//     }

//     //this makes the database, probably change later.
//     protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite($"Data Source={DbPath}");
// }

public class Customer
{
    [key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
}
}