using Abp.Authorization.Roles;
using Agenda.MultiTenancy;
using Agenda.Users;

namespace Agenda.Authorization.Roles
{
    public class Role : AbpRole<Tenant, User>
    {

    }
}