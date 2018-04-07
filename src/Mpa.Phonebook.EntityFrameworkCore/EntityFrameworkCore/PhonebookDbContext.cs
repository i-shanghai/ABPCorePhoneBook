using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Mpa.Phonebook.Authorization.Roles;
using Mpa.Phonebook.Authorization.Users;
using Mpa.Phonebook.MultiTenancy;
using Mpa.Phonebook.PhoneBook.Persons;
using Mpa.Phonebook.PhoneBook.PhoneNumbers;

namespace Mpa.Phonebook.EntityFrameworkCore
{
    public class PhonebookDbContext : AbpZeroDbContext<Tenant, Role, User, PhonebookDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public PhonebookDbContext(DbContextOptions<PhonebookDbContext> options)
            : base(options)
        {
        }


        public DbSet<Person> Persons {get;set;}

        public DbSet<PhoneNumber> PhoneBooks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().ToTable("Person", "PB");
            modelBuilder.Entity<PhoneNumber>().ToTable("PhoneNumber", "PB");
             

            base.OnModelCreating(modelBuilder);
        }
    }
}
