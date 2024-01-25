using API_JWTRegister.Models;

namespace API_JWTRegister.Services.SenhaService
{
    public interface ISenhaInterface
    {
        void CriarSenhaHash(string senha, out byte[] senhaHash, out byte[] senhaSalt);
        bool VerificaSenhaHash(string senha, byte[] senhaSalt, byte[] senhaHash);
        string CriarToken(UsuarioModel usuario);
    }
}
