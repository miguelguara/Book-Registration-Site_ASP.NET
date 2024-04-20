using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Web_Projeto_integrado.Models;

namespace Web_Projeto_integrado.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {   
        }


        public DbSet<EmprestimosModel> Emprestimos { get; set;}
    }
}
