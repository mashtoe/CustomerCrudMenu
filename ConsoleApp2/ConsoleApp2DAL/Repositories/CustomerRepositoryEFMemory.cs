using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp2DAL.Context;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq;
using ConsoleApp2DAL.Entities;

namespace ConsoleApp2DAL.Repositories
{
    public class CustomerRepositoryEFMemory : ICustomerRepository
    {
        InMemoryContext context;

        public CustomerRepositoryEFMemory(InMemoryContext context)
        {
            this.context = context;
        }

        public Customer Create(Customer cust)
        {
            context.Customers.Add(cust);
            return cust;
        }

        public bool DeleteCustomer(int id)
        {
            var cust = GetCustomer(id);
            context.Customers.Remove(cust);
            return true;
        }

        public List<Customer> GetAll()
        {
            return context.Customers.ToList();
        }

        public Customer GetCustomer(int id)
        {
            return context.Customers.FirstOrDefault(x => x.Id == id);
        }
    }
}
