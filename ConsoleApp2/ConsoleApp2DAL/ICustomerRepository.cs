using ConsoleApp2Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2DAL
{
    public interface ICustomerRepository
    {
        //C
        Customer Create(Customer cust);
        //R
        List<Customer> GetAll();
        Customer GetCustomer(int id);
        //U No update for the Repository, It will be the task of the unit of work
        //D
        bool DeleteCustomer(int id);
    }
}
