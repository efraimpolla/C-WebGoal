using System.Threading.Tasks;
using Abp.Application.Services;
using Agenda.Roles.Dto;

namespace Agenda.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
