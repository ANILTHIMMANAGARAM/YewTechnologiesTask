using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YewTechnologiesTask.Ibusinesslogic;
using YewTechnologiesTask.Irepository;
using YewTechnologiesTask.Models;

namespace YewTechnologiesTask.BusinessLogic
{
    public class EmployeeBusineeLogic : IEmployeeBUsiness
    {
        public IEmployeeRepo employeeRepo;
        public EmployeeBusineeLogic(IEmployeeRepo employee)
        {
            this.employeeRepo = employee;
        }
        public bool DeleteEmployeeData(int id)
        {
            return employeeRepo.DeleteEmployeeData(id);
        }

        public Employee GetemployeeDAtaById(int id)
        {
            return employeeRepo.GetemployeeDAtaById(id);
        }

        public List<Employee> GetEmployeeDetiles()
        {
            return employeeRepo.GetEmployeeDetiles();
        }

        public bool InsertemployeeData(Employee employee)
        {
            return employeeRepo.InsertemployeeData(employee);
        }

        public bool UpdateEmployeeData(Employee employee)
        {
            return employeeRepo.UpdateEmployeeData(employee);
        }
    }
}
