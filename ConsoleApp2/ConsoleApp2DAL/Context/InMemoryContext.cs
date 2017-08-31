
using ConsoleApp2DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2DAL.Context
{
    public class InMemoryContext : DbContext
    {
        static DbContextOptions<InMemoryContext> options = 
            new DbContextOptionsBuilder<InMemoryContext>().UseInMemoryDatabase("TheDB").Options;

        public InMemoryContext() : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Genre> Genre { get; set; }
    }
}
