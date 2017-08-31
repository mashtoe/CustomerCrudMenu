using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp2DAL.Entities;
using ConsoleApp2DAL.Context;
using System.Linq;

namespace ConsoleApp2DAL.Repositories
{
    public class GenreRepositoryEFMemory : IGenreRepository
    {
        InMemoryContext context;

        public GenreRepositoryEFMemory(InMemoryContext context)
        {
            this.context = context;
        }

        public Genre Create(Genre genre)
        {
            context.Genre.Add(genre);
            return genre;
        }

        public Genre Delete(int id)
        {
            var genre = Get(id);
            context.Genre.Remove(genre);
            return genre;
        }

        public Genre Get(int id)
        {
            return context.Genre.FirstOrDefault(x => x.Id == id);
        }

        public List<Genre> GetAll()
        {
            return context.Genre.ToList();             
        }
    }
}
