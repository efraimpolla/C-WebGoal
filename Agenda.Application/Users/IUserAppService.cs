using System.Threading.Tasks;
using Abp.Application.Services;
using Agenda.Users.Dto;

namespace Agenda.Users
{
    public interface IUserAppService : IApplicationService
    {
        Task ProhibitPermission(ProhibitPermissionInput input);

        Task RemoveFromRole(long userId, string roleName);
    }
}