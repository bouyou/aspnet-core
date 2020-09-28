using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Lille.EntityFrameworkCore
{
    public static class LilleDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<LilleDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<LilleDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
