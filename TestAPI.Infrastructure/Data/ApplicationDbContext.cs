using Microsoft.EntityFrameworkCore;
using TestAPI.Application.Interfaces;
using TestAPI.Domain.Entities;

namespace TestAPI.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<TaskCard> TaskCards => Set<TaskCard>();
    }
}
