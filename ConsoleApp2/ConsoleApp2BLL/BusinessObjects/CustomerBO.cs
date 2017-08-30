using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2BLL.BusinessObjects
{
    public class CustomerBO
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        public int Id { get; set; }
        public string Address { get; set; }
        public string FullName
        {
            get { return $"{Name} {Lastname}"; }
        }

        public CustomerBO()
        {

        }
    }
}
