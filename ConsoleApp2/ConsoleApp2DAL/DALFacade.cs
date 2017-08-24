using ConsoleApp2DAL.Repositories;
using ConsoleApp2DAL.UOW;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2DAL
{
    public class DALFacade
    {
        public ICustomerRepository CustomerRepository
        {
            //get { return new CustomerRepositoryFakeDB(); }
            get
            {
                return new CustomerRepositoryEFMemory(new Context.InMemoryContext());
            }

        }

        public IUnitOfWork UnitOfWork
        {
            get
            {
                return new UnitOfWorkMem();
            }

        }
    }
}
