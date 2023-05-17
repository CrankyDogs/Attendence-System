using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication1.DTO;
using WebApplication1.Entities;

namespace WebApplication1.Abstract
{
    public interface IAuthService
    {
        Task<LoginResponseDto> LoginAsync(LoginDto loginDto);
        Task<List<ApplicationUser>> GetUsersAsync();

        Task<Guid> CreateUserAsync(string email, string name);


        //Task<>
    }
}
