using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2DAL.Entities
{
    public class Customer
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        public int Id { get; set; }
        public string Address { get; set; }

        public Customer()
        {
            
        }
    }
}
