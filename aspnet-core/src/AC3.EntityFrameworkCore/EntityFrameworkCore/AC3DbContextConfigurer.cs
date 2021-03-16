using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace AC3.EntityFrameworkCore
{
    public static class AC3DbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<AC3DbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<AC3DbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
