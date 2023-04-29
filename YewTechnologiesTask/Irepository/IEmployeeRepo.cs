using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YewTechnologiesTask.Models;

namespace YewTechnologiesTask.Irepository
{
    public interface IEmployeeRepo
    {
        public bool InsertemployeeData(Employee employee);
        public bool UpdateEmployeeData(Employee employee);
        public bool DeleteEmployeeData(int id);
        public List<Employee> GetEmployeeDetiles();
        public Employee GetemployeeDAtaById(int id);
    }
}
