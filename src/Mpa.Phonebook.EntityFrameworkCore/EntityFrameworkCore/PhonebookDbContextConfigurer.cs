using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Mpa.Phonebook.EntityFrameworkCore
{
    public static class PhonebookDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<PhonebookDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<PhonebookDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
