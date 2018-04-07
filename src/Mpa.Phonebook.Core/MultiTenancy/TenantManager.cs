using Abp.Application.Features;
using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using Mpa.Phonebook.Authorization.Users;
using Mpa.Phonebook.Editions;

namespace Mpa.Phonebook.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager,
            IAbpZeroFeatureValueStore featureValueStore) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager,
                featureValueStore)
        {
        }
    }
}
