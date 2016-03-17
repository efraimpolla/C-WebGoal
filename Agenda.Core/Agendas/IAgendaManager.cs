using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Abp.Domain.Services;

namespace Agenda.Agendas
{
    public interface IAgendaManager : IDomainService
    {
        Task<int> InsertAndGetTamanho(ICollection<string> stringList);
    }
}