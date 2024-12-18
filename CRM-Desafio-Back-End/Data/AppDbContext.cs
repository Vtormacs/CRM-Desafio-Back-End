using CRM_Desafio_Back_End.Model;
using Microsoft.EntityFrameworkCore;

namespace CRM_Desafio_Back_End.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<UserModel> users { get; set; }
        public DbSet<ProductModel> products { get; set; }
        public DbSet<MovementModel> movements { get; set; }
    }
}
