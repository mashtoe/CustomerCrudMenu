using ConsoleApp2BLL;
using ConsoleApp2Entity;
using System;
using System.Collections.Generic;

namespace ConsoleApp2UI
{
    class Program
    {
        static BLLFacade bllFacade = new BLLFacade(); 

        static void Main(string[] args)
        {
            Program prog = new Program();
        }

        Program()
        {
            var cust = new Customer()
            {
                Name = "Jens",
                Lastname = "Jensen",
                Address = "Bedstevej 41"
            };

            bllFacade.CustomerService.Create(cust);

            while(CrudMenu())
            {
                Console.Clear();
            }
        }

        private bool CrudMenu()
        {
            Console.WriteLine("Menu\n");
            string[] crud = { "Create", "Read", "Update", "Delete", "Shutdown" };
            for (int i = 0; i < crud.Length; i++)
            {
                Console.WriteLine((i+1) + ". " + crud[i]);
            }

            int value;
            string c;
            while (!int.TryParse(c = Console.ReadLine(), out value)) //|| value >= 0 || value < crud.Length))
            {
                Console.WriteLine($"{c} not valid");
            }
            return CrudActionSwitch(value-1);
        }

        private bool CrudActionSwitch(int value)
        {
            switch (value)
            {
                case 0:
                    Create();
                    break;
                case 1:
                    Read();
                    break;
                case 2:
                    Update();
                    break;
                case 3:
                    Delete();
                    break;
                case 4:
                    return false;
                default:
                    break;
            }
            return true;
        }

        private void Delete()
        {
            List<Customer> customers = bllFacade.CustomerService.GetAll();
            List<string> items = new List<string>();
            for (int i = 0; i < customers.Count; i++)
            {
                items.Add(customers[i].Name);
            }
            int value = ListItems(items);


            if (value != customers.Count)
            {
                bool succesful = bllFacade.CustomerService.DeleteCustomer(customers[value].Id);
            }
        }

        private void Update()
        {
            List<Customer> customers = bllFacade.CustomerService.GetAll();
            List<string> items = new List<string>();
            for (int i = 0; i < customers.Count; i++)
            {
                items.Add(customers[i].Name);
            }
            int value = ListItems(items);


            if (value != customers.Count)
            {
                Console.Clear();
                Console.WriteLine("Enter firstname:");
                string name = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Enter lastname:");
                string lastname = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Enter address:");
                string address = Console.ReadLine();

                customers[value].Name = name;
                customers[value].Lastname = lastname;
                customers[value].Address = address;
            }
            bllFacade.CustomerService.UpdateCustomer(customers[value]);
        }

        private void Read()
        {
            List<Customer> customers = bllFacade.CustomerService.GetAll();
            List<string> items = new List<string>();
            for (int i = 0; i < customers.Count; i++)
            {
                items.Add(customers[i].Name);
            }
            int value = ListItems(items);


            if (value != customers.Count)
            {
                Console.Clear();
                Console.WriteLine($"{customers[value].Name} {customers[value].Lastname} ({customers[value].Address})");
                Console.ReadLine();
            }
            
        }

        private int ListItems(List<string> items)
        {
            Console.Clear();
            items.Add("Go back");
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {items[i]}");
            }

            int value;
            string input;
            while (!int.TryParse(input = Console.ReadLine(),out value) || value > items.Count || value <= 0)
            {
                Console.WriteLine($"Please type number ranging 1-{items.Count}. (Input: {input})");
            }
            return value-1;
        }

        private void Create()
        {
            Console.Clear();
            Console.WriteLine("Enter firstname:");
            string name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Enter lastname:");
            string lastname = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Enter address:");
            string address = Console.ReadLine();

            Customer newCust = bllFacade.CustomerService.Create(new Customer()
            {
                Name = name,
                Lastname = lastname,
                Address = address

            });


        }
    }
}
