using Microsoft.AspNetCore.Mvc;
using WorkFlowProNew.API.DTOs.Auth;
using WorkFlowProNew.API.Interfaces;

namespace WorkFlowProNew.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authservice)
        {
            _authService = authservice;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequestDto request)
        {
            var result = _authService.Login(request);

            if (string.IsNullOrEmpty(result?.AccessToken))
            {
                return Unauthorized("Invalid username or password");
            }
            return Ok(result);
        }


    }
}
