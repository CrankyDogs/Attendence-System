using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Any;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WebApplication1.Abstract;
using WebApplication1.Data;
using WebApplication1.DTO;
using WebApplication1.Entities;

namespace WebApplication1.Implementation
{
    public class AuthUser : IAuthService
    {

        //private readonly IAuthService _authService;
        private readonly DataContext _dbContext;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AuthUser(
            DataContext dbContext,
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager
            )
        {
            _signInManager = signInManager;
            _dbContext = dbContext;
            _userManager = userManager;
        }

        public async Task<LoginResponseDto> LoginAsync(LoginDto loginDto)
        {
            //throw new System.NotImplementedException();
            var user = await _userManager.FindByEmailAsync( loginDto.Email );
            if ( user == null )
            {
                throw new ValidationException("Invalid Email");
            }

            var isPasswordValid = await _userManager.CheckPasswordAsync(user, loginDto.Password );
            if ( !isPasswordValid ) {
                throw new ValidationException("Invalid Password");
            }

            var signInResult = await _signInManager.PasswordSignInAsync(user, loginDto.Password, true, false);
            if (! signInResult.Succeeded )
            {
                throw new ValidationException("Invalid Password or Email");
            }

            var userClaims = await GetClaimAsync(user);

            var role = userClaims.Where(x => x.Type == ClaimTypes.Role).ToList();
            var userRole = role[0].Value;

            

            return new LoginResponseDto()
            {
                Email = user.Email,

                Username = user.UserName,


                //userClaims = userClaims
                UserRole = userRole,
                //Roles = 

            };
        }

        public async Task<Guid> CreateUserAsync(string email, string name)
        {
            var userExists = await _userManager.FindByEmailAsync(email);

            if (userExists is not null)
                throw new ValidationException("Email Already In Use");

            ApplicationUser user = new ApplicationUser()
            {
                Email = email,
                NormalizedEmail = email.ToUpper(),
                UserName = name,
                NormalizedUserName = name.ToUpper(),
                SecurityStamp = DateTime.Now.Ticks.ToString()
            };

            PasswordHasher<ApplicationUser> hasher = new PasswordHasher<ApplicationUser>();
            user.PasswordHash = hasher.HashPassword(user, "employee123");

            await _userManager.CreateAsync(user);
            await _userManager.AddToRoleAsync(user, "EMPLOYEE");
            return user.Id;

        }

        public async Task<List<ApplicationUser>> GetUsersAsync()
        {
            return await _userManager.Users.ToListAsync();

        }


        public async Task<List<Claim>> GetClaimAsync(ApplicationUser user)
        {
            List<Claim> authClaims = new()
            {
                new Claim("email", user.Email),
                new Claim("uid", user.Id.ToString())
            };

            IList<string> userRoles = await _userManager.GetRolesAsync(user);

            foreach(var role in userRoles)
            {
                authClaims.Add(new Claim(ClaimTypes.Role, role));
            }

            return authClaims;
        }
    }
}
