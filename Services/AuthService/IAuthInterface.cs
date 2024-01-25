using API_JWTRegister.Dtos;
using API_JWTRegister.Models;

namespace API_JWTRegister.Services.AuthService
{
    public interface IAuthInterface
    {
        Task<Response<UsuarioCriacaoDto>> Registrar(UsuarioCriacaoDto userRegistro);
        Task<Response<string>> Login(UsuarioLoginDto login);
    }
}
