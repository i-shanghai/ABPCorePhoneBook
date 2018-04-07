using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Mpa.Phonebook.Configuration;
using Mpa.Phonebook.Web;

namespace Mpa.Phonebook.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class PhonebookDbContextFactory : IDesignTimeDbContextFactory<PhonebookDbContext>
    {
        public PhonebookDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<PhonebookDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            PhonebookDbContextConfigurer.Configure(builder, configuration.GetConnectionString(PhonebookConsts.ConnectionStringName));

            return new PhonebookDbContext(builder.Options);
        }
    }
}
