using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Abp.UI;
using Agenda.Agendas.Dtos;
using Castle.Components.DictionaryAdapter;

namespace Agenda.Agendas
{
    public class AgendaAppService : AgendaAppServiceBase, IAgendaAppService
    {
        private readonly IAgendaManager _agendaManager;
        
        public AgendaAppService(IAgendaManager agendaManager)
        {
            
            _agendaManager = agendaManager;
        }

        #region Implementation of IAgendaAppService

        
        
        public Task<int> Create(CreateAgendaInput input)
        {
            var stringList = input.Telefones.Trim().Split(',').OrderBy(x => x.Length).ToList();
            if (stringList.Count != input.Quantidade) 
                throw new UserFriendlyException("Quantidade de contatos difere da quantidade inserida");
            return _agendaManager.InsertAndGetTamanho(stringList);
        }

   

        #endregion
    }
}