using ConsoleApp2Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2BLL
{
    public interface IService
    {
        //C
        Customer Create(Customer cust);
        //R
        List<Customer> GetAll();
        Customer GetCustomer(int id);
        //U
        Customer UpdateCustomer(Customer cust);
        //D
        bool DeleteCustomer(int id);
    }
}
