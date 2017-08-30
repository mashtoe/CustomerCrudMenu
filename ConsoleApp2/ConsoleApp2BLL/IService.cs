
using ConsoleApp2BLL.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2BLL
{
    public interface IService
    {
        //C
        CustomerBO Create(CustomerBO cust);
        //R
        List<CustomerBO> GetAll();
        CustomerBO GetCustomer(int id);
        //U
        CustomerBO UpdateCustomer(CustomerBO cust);
        //D
        bool DeleteCustomer(int id);

        List<CustomerBO> CreateMultiple(List<CustomerBO> customers);
    }
}
