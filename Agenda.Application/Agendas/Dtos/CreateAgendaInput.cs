using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;

namespace Agenda.Agendas.Dtos
{
    public class CreateAgendaInput :  IInputDto
    {
        [Required]
        public int Quantidade { get; set; }
        [Required]
        public string Telefones { get; set; }
    }
}