using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp2Entity;
using ConsoleApp2DAL;
using System.Linq;

namespace ConsoleApp2BLL.Services
{
    class CustomerService : IService
    {
        DALFacade facade;

        public CustomerService(DALFacade facade)
        {
            this.facade = facade;
        }

        public Customer Create(Customer cust)
        {
            using (var uow = facade.UnitOfWork)
            {
                var newCust = uow.CustomerRepository.Create(cust);
                uow.Complete();
                return newCust;
            }

        }

        public bool DeleteCustomer(int id)
        {
            using (var uow = facade.UnitOfWork)
            {
                var succeeded = uow.CustomerRepository.DeleteCustomer(id);
                uow.Complete();
                return succeeded;
            }
        }

        public List<Customer> GetAll()
        {
            using (var uow = facade.UnitOfWork)
            {
                return uow.CustomerRepository.GetAll();
            }
        }

        public Customer GetCustomer(int id)
        {
            using (var uow = facade.UnitOfWork)
            {
                return uow.CustomerRepository.GetCustomer(id);
            }
        }

        public Customer UpdateCustomer(Customer cust)
        {
            using (var uow = facade.UnitOfWork)
            {
                var customerFromDb = uow.CustomerRepository.GetCustomer(cust.Id);
                if (customerFromDb == null)
                {
                    throw new InvalidOperationException("Customer not found");
                }
                customerFromDb.Name = cust.Name;
                customerFromDb.Lastname = cust.Lastname;
                customerFromDb.Address = cust.Address;
                uow.Complete();
                return customerFromDb;
            }
                
            
            
        }
    }
}
