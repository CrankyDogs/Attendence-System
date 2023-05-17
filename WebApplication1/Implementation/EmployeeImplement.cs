using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Abstract;
using WebApplication1.Controllers;
using WebApplication1.Data;
using WebApplication1.DTO;
using WebApplication1.Entities;

namespace WebApplication1.Implementation
{
    public class EmployeeImplement : EmployeeService
    {
        private readonly IAuthService _authService;
        private readonly DataContext _dataContext;

        public EmployeeImplement()
        {
        }

        public EmployeeImplement(IAuthService authService, DataContext dataContext)
        {
            _authService = authService;
            _dataContext = dataContext;
        }

        public async Task<EmployeeDto> CreateAsync(AddemployeeDto addemployeeDto)
        {
            //throw new System.NotImplementedException();

            if (string.IsNullOrEmpty(addemployeeDto.Name))
            {
                throw new ValidationException("Name cannot be blank");
            }   
            if (string.IsNullOrEmpty(addemployeeDto.Email))
            {
                throw new ValidationException("Email cannot be blank");
            }


            var newUserId = await _authService.CreateUserAsync(addemployeeDto.Email, addemployeeDto.Name);

            var employee = new Entities.Employee()
            {
                Name = addemployeeDto.Name,
                ApplicationUserId = newUserId,
            };

            await _dataContext.Employees.AddAsync(employee);
            await _dataContext.SaveChangesAsync();

            //return new EmployeeDto(employee.Id, employee.Name, employee.CreatedOn.ToShortDateString(), employee.IsActive);
            return new EmployeeDto(employee.Id, employee.Name, addemployeeDto.Email, employee.CreatedOn, employee.IsActive);

        }

        public async Task<List<Entities.Employee>> GetAsync()
        {

            return await _dataContext.Employees.ToListAsync();
        }
    }
}