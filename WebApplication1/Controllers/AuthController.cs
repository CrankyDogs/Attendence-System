using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.Threading.Tasks;
using WebApplication1.Abstract;
using WebApplication1.Data;
using WebApplication1.DTO;

namespace WebApplication1.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        private readonly IConfigService _configService;

        //private readonly DataContext _dataContext;

        public AuthController(IAuthService authService, IConfigService configService)
        {
            _authService = authService;
           _configService = configService;
            //_dataContext = dataContext;
        }

        [HttpPost]
        [Route("[action]")]

        public async Task<IActionResult> Login(LoginDto loginDto)
        {
            return Ok(await _authService.LoginAsync(loginDto));
        }

        [HttpGet]

        public async Task<IActionResult> GetUsersAsync()
        {
            return Ok(await _authService.GetUsersAsync());
        }

        [HttpPost]
        [Route("[action]")]

        public async Task<IActionResult> AddConfig(AddConfigDto addConfigDto)
        {
            //return Ok(await _configService.AddConfigAsync());
            return Ok(await _configService.AddConfigAsync(addConfigDto));
        }

        [HttpGet]
        [Route("[action]")]

        public async Task<IActionResult> getConfig()
        {
            return Ok(await _configService.GetConfigAsync());
        }


    }
}
