using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SinavSistemi.Models;

namespace SinavSistemi.DataContex
{
    public class CreateAQuizDb : IdentityDbContext<AppUser>
    {
        public CreateAQuizDb(DbContextOptions options) : base(options)
        {
        }// deneme commit

        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<New> News { get; set; }
    }
}
