using Microsoft.EntityFrameworkCore;
using TestAPI.Domain.Entities;

namespace TestAPI.Application.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<TaskCard> TaskCards { get; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
