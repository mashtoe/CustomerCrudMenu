using ConsoleApp2DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2DAL
{
    public interface IGenreRepository
    {
        //C
        Genre Create(Genre genre);
        //R
        Genre Get(int id);
        List<Genre> GetAll();
        //U
        //D
        Genre Delete(int id);
    }
}
