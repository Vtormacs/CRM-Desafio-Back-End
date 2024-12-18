using Microsoft.EntityFrameworkCore;

namespace CRM_Desafio_Back_End.Data
{
    public class AppDbContext : DbContext
    {
        protected AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
    }
}
