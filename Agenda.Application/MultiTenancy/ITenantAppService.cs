using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Agenda.MultiTenancy.Dto;

namespace Agenda.MultiTenancy
{
    public interface ITenantAppService : IApplicationService
    {
        ListResultOutput<TenantListDto> GetTenants();

        Task CreateTenant(CreateTenantInput input);
    }
}
