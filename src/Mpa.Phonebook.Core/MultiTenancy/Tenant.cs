using Abp.MultiTenancy;
using Mpa.Phonebook.Authorization.Users;

namespace Mpa.Phonebook.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
