using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;

namespace Agenda.Agendas.Dtos
{
    public class SearchByTermInput : IInputDto
    {
        [Required]
        public string TermSearch { get; set; }

    }
}