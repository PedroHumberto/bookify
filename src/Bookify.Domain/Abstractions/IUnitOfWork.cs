using Bookify.Domain.Users;

namespace Bookify.Domain.Abstractions
{
    public interface IUnitOfWork
    {
        Task<int> SaveChangesAsync(Guid Id, CancellationToken cancellationToken = default);
    }
}