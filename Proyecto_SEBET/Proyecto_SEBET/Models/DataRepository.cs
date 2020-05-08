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

        public void RegisterUser(User newUser)
        {
            this.context.Users.Add(newUser);
            this.context.SaveChanges();
        }
    }
}
