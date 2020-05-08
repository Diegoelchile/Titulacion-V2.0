using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_SEBET.Models
{
    public interface IRepository
    {
        IEnumerable<User> Users { get; }

        void RegisterUser(User newUser);
    }
}
