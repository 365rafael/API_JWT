using API_JWTRegister.Models;
using Microsoft.EntityFrameworkCore;

namespace API_JWTRegister.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        
        public DbSet<UsuarioModel> Usuario { get; set; }
    }
}
