using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using WebApplication1.Abstract;
using WebApplication1.Data;
using WebApplication1.DTO;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Employee : ControllerBase
    {
        private readonly EmployeeService _employeeService;
        private readonly DataContext _dataContext;

        public Employee(EmployeeService employeeService, DataContext dataContext)
        {
            _employeeService = employeeService;
            _dataContext = dataContext;
        }

        [HttpPost]
        [Route("[action]")]

        public async Task<IActionResult> Add(AddemployeeDto addemployeeDto)
        {
            return Ok(await _employeeService.CreateAsync(addemployeeDto));
        }

        [HttpGet]
        [Route("[action]")]

        public async Task<IActionResult> Get()
        {
            return Ok(await _employeeService.GetAsync());
        }
    }
}
