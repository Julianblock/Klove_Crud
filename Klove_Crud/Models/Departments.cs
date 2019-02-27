using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Klove_Crud.Models
{
    public class Departments
    {
        public int ID { get; set; }
        public string Department { get; set; }
        public int departmentManager { get; set; }
    }
    
}