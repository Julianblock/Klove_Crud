using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Klove_Crud.Models
{
    public class EmployeeViewModel
    {
        public int ID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime startDate { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int departmentID { get; set; }
        public string departmentName { get; set; }
    }

}