using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CustomerInfo.Models;
using CustomerInfo.Data;
using Microsoft.EntityFrameworkCore;

namespace CustomerInfo.Services
{
    public class CustomerService
    {
        private readonly CustomerContext _context;

        public CustomerService(CustomerContext context)
        {
            _context = context;
        }

        ///starting CRUD
        public  IEnumerable<Customer> GetAll()
        {
            return _context.Customers
                .AsNoTracking()
                .ToList();
        }

        public Customer? GetById(int id)
        {
            return _context.Customers
                .AsNoTracking()
                .SingleOrDefault(c => c.Id == id);
        }

        public Customer Create(Customer newCustomer)
        {
            _context.Customers.Add(newCustomer);
            _context.SaveChanges();

            return newCustomer;
        }

        public void UpdateCustomer(int Id)
        {
            var CustomerToUpdate = _context.Customers.Find(Id);
            if (CustomerToUpdate is null)
            {
                throw new Exception("Customer not found");
            }
            _context.Customers.Update(CustomerToUpdate);
            _context.SaveChanges();
        }

        public void DeleteById(int Id)
        {
            var CustomerToDelete = _context.Customers.Find(Id);
                if ( CustomerToDelete != null)
                {
                    _context.Customers.Remove(CustomerToDelete);
                    _context.SaveChanges(true);
                }
        }
    }
}
