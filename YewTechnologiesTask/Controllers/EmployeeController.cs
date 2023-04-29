using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YewTechnologiesTask.Ibusinesslogic;
using YewTechnologiesTask.Models;

namespace YewTechnologiesTask.Controllers
{   [EnableCors]
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public IEmployeeBUsiness employeeBUsiness;
        public EmployeeController(IEmployeeBUsiness  employeeB)
        {
            this.employeeBUsiness = employeeB;
        }
        [Route("DeleteEmployeeData")]
        [HttpDelete]
        public bool DeleteEmployeeData(int id)
        {
            return employeeBUsiness.DeleteEmployeeData(id);
        }
        [Route("GetemployeeDAtaById")]
        [HttpGet]
        public Employee GetemployeeDAtaById(int id)
        {
            return employeeBUsiness.GetemployeeDAtaById(id);
        }
        [Route("GetEmployeeDetiles")]
        [HttpGet]
        public List<Employee> GetEmployeeDetiles()
        {
            return employeeBUsiness.GetEmployeeDetiles();
        }
        [Route("InsertemployeeData")]
        [HttpPost]
        public bool InsertemployeeData(Employee employee)
        {
            return employeeBUsiness.InsertemployeeData(employee);
        }
        [Route("UpdateEmployeeData")]
        [HttpPut]
        public bool UpdateEmployeeData(Employee employee)
        {
            return employeeBUsiness.UpdateEmployeeData(employee);
        }
    }
}
