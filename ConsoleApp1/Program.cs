using CustomerInfo.Data;
using CustomerInfo.Models;
using System.Net.Http.Headers;

using CustomerContext context = new CustomerContext();

AppContext.CreateDbIfNotExists();

//Customer newCustomer = new Customer()
//{
//    FirstName = "John",
//    LastName = "Smith",
//    Address = "123 Smith st.",
//    Phone = "555-555-5555",
//    Email = "JohnSmith@abcde.com",
//};

//context.Customers.Add(newCustomer);


//Customer newCustomer2 = new Customer()
//{
//    FirstName = "Jane",
//    LastName = "Smith",
//    Address = "456 Smith st.",
//    Phone = "555-555-5556",
//    Email = "JaneSmith@abcde.com",
//};
//context.Add(newCustomer2);

//context.SaveChanges();
