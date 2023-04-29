using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YewTechnologiesTask.Models
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
       
        public DateTime DOB { get; set; }
        public string Email { get; set; }
        public long Mobile { get; set; }
        public string Department { get; set; }
        public string Designation { get; set; }
        public long Salary { get; set; }

    }
}
