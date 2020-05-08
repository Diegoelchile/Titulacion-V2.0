using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_SEBET.Models
{
    public class User
    {
        public long ID { get; set; }

        public string Name { get; set; }
        public string LastName { get; set; }
        public string IdentifierSeries { get; set; } //Numero de boleta o RFC

        //public string Area { get; set; }            //Area de conocimiento o Industria
        //public string Formality { get; set; }       //Grado de Estudios o Formacion jurídica
        public string SpecialBusiName { get; set; }  //Nombre de especialidad o Nombre de la empresa

        public string Email { get; set; }
        public string Password { get; set; }

        //RelationShip
        public long AreaID { get; set; }
        public Area Area { get; set; }

        public long FormalityID { get; set; } 
        public Formality Formality { get; set; }

    }
}
