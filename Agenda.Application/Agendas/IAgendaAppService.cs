using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Agenda.Agendas.Dtos;

namespace Agenda.Agendas
{
    public interface IAgendaAppService : IApplicationService
    {
        Task<int> Create(CreateAgendaInput input);
        
    }
}