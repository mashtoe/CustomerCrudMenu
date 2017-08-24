using ConsoleApp2BLL.Services;
using ConsoleApp2DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2BLL
{
    public class BLLFacade
    {
        public IService CustomerService
        {
            get { return new CustomerService(new DALFacade()); }
        }
    }
}
