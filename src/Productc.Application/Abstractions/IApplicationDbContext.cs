using Microsoft.EntityFrameworkCore;
using Productc.Domain.Entities.Products;
using Productc.Domain.Entities.Users;

namespace Productc.Application.Abstractions
{
    public interface IApplicationDbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
