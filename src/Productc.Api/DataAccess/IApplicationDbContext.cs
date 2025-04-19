using Microsoft.EntityFrameworkCore;
using Productc.Api.Models.Products;
using Productc.Api.Models.Users;

namespace Productc.Api.DataAccess
{
    public interface IApplicationDbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

    }
}
