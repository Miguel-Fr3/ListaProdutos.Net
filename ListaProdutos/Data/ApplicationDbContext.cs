using ListaProdutos.Models;
using Microsoft.EntityFrameworkCore;

namespace ListaProdutos.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Produto> Produto { get; set; }
    }
}
