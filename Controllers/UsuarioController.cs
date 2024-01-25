using API_JWTRegister.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace jwtRegisterLogin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [Authorize]
        [HttpGet]
        public ActionResult<Response<string>> GetUsuario()
        {
            Response<string> response = new Response<string>();
            response.Mensagem = "Acessei";

            return Ok(response);
        }

    }
}