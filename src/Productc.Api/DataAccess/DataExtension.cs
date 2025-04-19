using Microsoft.EntityFrameworkCore;

namespace Productc.Api.DataAccess
{
    public static class DataExtension
    {
        /// <summary>
        /// Automatically updated database based on latest migration
        /// </summary>
        /// <param name="app"></param>
        public static void ApplyMigration(this WebApplication app)
        {
            using var scope = app.Services.CreateScope();

            var db = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
            if (db.Database.GetPendingMigrations().Any())
                db.Database.Migrate();
        }
    }
}
