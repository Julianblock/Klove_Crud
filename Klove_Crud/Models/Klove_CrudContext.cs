using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Klove_Crud.Models
{
    public class Klove_CrudContext : DbContext
    {
        public System.Data.Entity.DbSet<Klove_Crud.Models.Employees> Employees { get; set; }
        public System.Data.Entity.DbSet<Klove_Crud.Models.Departments> Departments { get; set; }

    }
    
}
