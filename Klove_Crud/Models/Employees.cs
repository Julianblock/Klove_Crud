using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Klove_Crud.Models
{
    public class Employees
    {
        public int ID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime startDate { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
        public string departmentID { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
    
}