using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp2Entity;
using System.Linq;

namespace ConsoleApp2DAL.Repositories
{
    class CustomerRepositoryFakeDB : ICustomerRepository
    {
        #region
        private static int Id = 1;
        private static List<Customer> Customers = new List<Customer>();
        #endregion

        public Customer Create(Customer cust)
        {
            Customer newCust;
            Customers.Add(newCust = new Customer()
            {
                Id = Id++,
                Name = cust.Name,
                Lastname = cust.Lastname,
                Address = cust.Address
            });

            return newCust;
        }

        public bool DeleteCustomer(int id)
        {
            var cust = GetCustomer(id);

            if (cust != null)
            {
                Customers.Remove(cust);
                return true;
            }
            return false;
        }

        public List<Customer> GetAll()
        {
            return new List<Customer>(Customers);
        }

        public Customer GetCustomer(int id)
        {
            return Customers.FirstOrDefault(x => x.Id == id);
        }
    }
}
