using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;

namespace Agenda.Agendas.Dtos
{
    public class UpdateAgendaInput : EntityDto<long>, IInputDto
    {
        [Required]
        public string Telefone { get; set; }
    }
}