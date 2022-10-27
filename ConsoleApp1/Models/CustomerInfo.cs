using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CustomerInfo.Models
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
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; } = null!;
        [Required]
        [MaxLength(100)]
        public string LastName { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Email { get; set; } = null!;
    }
}