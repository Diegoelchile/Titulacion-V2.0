using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_SEBET.Models
{
    public class DataRepository : IRepository
    {
        private DataContext context;

        public DataRepository(DataContext ctx) => context = ctx;

        public IQueryable<User> Users => context.Users;

        public IQueryable<Area> Areas => context.Areas;

        public IQueryable<Formality> Formalities => context.Formalities;

        //public User GetUser(long key) => context.Users.Find(key);

        public void RegisterUser(User newUser)
        {
            context.Users.Add(newUser);
            context.SaveChanges();
        }

        public void AddArea(Area area)
        {
            context.Areas.Add(area);
            context.SaveChanges();
        }

        public void AddFormality(Formality formality)
        {
            context.Formalities.Add(formality);
            context.SaveChanges();
        }
    }

    /*public class AreaRepository : IAreaRepository
    {
        private DataContext context;

        public AreaRepository(DataContext ctx) => context = ctx;

        public IQueryable<Area> Areas => context.Areas;

        public void AddArea(Area area)
        {
            context.Areas.Add(area);
            context.SaveChanges();
        }
    } */
}
