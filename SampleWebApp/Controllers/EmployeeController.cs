using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SampleWebApp.Models;

namespace SampleWebApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly ModelContext _context;
        public EmployeeController(ModelContext context)
        {
            _context = context;
        }

        [HttpGet("list-employees")]
        public IActionResult GetEmployees()
        {
            Console.WriteLine("hello world");
            var employees = _context.Employees.Include(e => e.Department).ToList();
            return Ok(employees);
        }

        public void MyFirstMethod()
        {
            //do something
        }
        public void MySecondMethod()
        {
            //do something
        }
        public void MyThirdMethod()
        {
            //do something
        }
    }
}
