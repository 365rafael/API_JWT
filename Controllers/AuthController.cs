using API_JWTRegister.Dtos;
using API_JWTRegister.Services.AuthService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_JWTRegister.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthInterface _authInterface;
        public AuthController(IAuthInterface authInterface)
        {
            _authInterface = authInterface;
        }

        [HttpPost("login")]
        public async Task<ActionResult> Login(UsuarioLoginDto usuarioLogin)
        {

            var resposta = await _authInterface.Login(usuarioLogin);
            return Ok(resposta);
        }


        [HttpPost("register")]
        public async Task<ActionResult> Register(UsuarioCriacaoDto usuarioRegister)
        {

            var resposta = await _authInterface.Registrar(usuarioRegister);
            return Ok(resposta);
        }

    }
}
