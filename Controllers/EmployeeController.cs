using ConsoleToWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ConsoleToWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [Route("")]
        public List<EmployeeModel> GetEmployee()
        {
            return new List<EmployeeModel>() {
                new EmployeeModel() { Id = 1, Name = "Mohan"},
                new EmployeeModel() { Id = 2, Name = "Mohan 2"}
            };
        }

        [Route("{id}")]
        public IActionResult GetEmployee(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            return Ok(new List<EmployeeModel>() {
                new EmployeeModel() { Id = 1, Name = "Mohan"},
                new EmployeeModel() { Id = 2, Name = "Mohan 2"}
            });

        }
    }
}
