using Abp.Application.Features;
using Agenda.Authorization.Roles;
using Agenda.MultiTenancy;
using Agenda.Users;

namespace Agenda.Features
{
    public class FeatureValueStore : AbpFeatureValueStore<Tenant, Role, User>
    {
        public FeatureValueStore(TenantManager tenantManager)
            : base(tenantManager)
        {
        }
    }
}