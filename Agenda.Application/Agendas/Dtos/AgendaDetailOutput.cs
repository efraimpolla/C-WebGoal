using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace Agenda.Agendas.Dtos
{
    [AutoMapFrom(typeof(Agenda))]
    public class AgendaDetailOutput : FullAuditedEntityDto<long>, IOutputDto
    {
        
        public int Numero { get; set; }

        public long PaiId { get; set; }
        
    }
}