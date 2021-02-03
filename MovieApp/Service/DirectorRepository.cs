using MovieApp.Context;
using MovieApp.Interface;
using MovieApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Service
{
    public class DirectorRepository : IDirectorRepository
    {
        private readonly InstrukcjaDbContext context;
        public DirectorRepository(InstrukcjaDbContext _context)
        {
            context = _context;
        }
        public Director Delete(int directorId)
        {
            Director director = context.Directors.Find(directorId);
            if (director != null)
            {
                context.Directors.Remove(director);
                context.SaveChanges();
            }
            return director;
        }
        public Director Get(int directorId)
        {
            return context.Directors.Find(directorId);
        }
        public IEnumerable<Director> GetAll()
        {
            return context.Directors;
        }
        public Director Post(Director newDirector)
        {
            context.Directors.Add(newDirector);
            context.SaveChanges();
            return newDirector;
        }
        public Director Put(Director updatedDirector)
        {
            var director = context.Directors.Attach(updatedDirector);
            director.State = Microsoft
            .EntityFrameworkCore
            .EntityState
            .Modified;
            context.SaveChanges();
            return updatedDirector;
        }
    }
}
