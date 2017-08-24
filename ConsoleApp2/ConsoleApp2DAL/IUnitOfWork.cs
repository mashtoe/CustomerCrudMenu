using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2DAL
{
    public interface IUnitOfWork : IDisposable
    {   
        ICustomerRepository CustomerRepository { get; }

        int Complete();
    }
}
