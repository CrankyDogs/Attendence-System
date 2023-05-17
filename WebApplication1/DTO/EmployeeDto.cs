
using System;

namespace WebApplication1.DTO
{ 
 public record EmployeeDto(Guid Id, string Name, string Email, string CreatedOn, bool IsActive);
}
