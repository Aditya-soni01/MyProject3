using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace MyProject3.EntityFrameworkCore
{
    public static class MyProject3DbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MyProject3DbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<MyProject3DbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
