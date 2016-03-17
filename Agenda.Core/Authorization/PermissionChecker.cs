using Abp.Authorization;
using Agenda.Authorization.Roles;
using Agenda.MultiTenancy;
using Agenda.Users;

namespace Agenda.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
