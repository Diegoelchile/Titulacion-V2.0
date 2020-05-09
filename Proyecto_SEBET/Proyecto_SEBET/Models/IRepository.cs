using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_SEBET.Models
{
    public interface IRepository
    {
        IQueryable<User> Users { get; }

        IQueryable<Area> Areas { get; }

        IQueryable<Formality> Formalities { get; }

        //User GetUser(long key);

        void RegisterUser(User newUser);

        void AddArea(Area area);

        void AddFormality(Formality formality);
    }

    /*public interface IAreaRepository
    {
        IQueryable<Area> Areas { get; }

        void AddArea(Area area); 
    }*/
}
