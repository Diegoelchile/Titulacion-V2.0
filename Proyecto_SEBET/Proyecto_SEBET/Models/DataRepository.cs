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

        public IEnumerable<User> Users => context.Users;

        //public User GetUser(long key) => context.Users.Find(key);

        public void RegisterUser(User newUser)
        {
            this.context.Users.Add(newUser);
            this.context.SaveChanges();
        }
    }

    public class AreaRepository : IAreaRepository
    {
        private DataContext context;

        public AreaRepository(DataContext ctx) => context = ctx;

        public IEnumerable<Area> Areas => context.Areas;

        public void AddArea(Area area)
        {
            context.Areas.Add(area);
            context.SaveChanges();
        }
    } 
}
