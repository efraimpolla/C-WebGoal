using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;
using Abp.Domain.Entities.Auditing;
using Castle.Components.DictionaryAdapter;

namespace Agenda.Agendas
{
    public class Agenda : FullAuditedEntity<long>
    {
        [ForeignKey("AgendaId")]
        public virtual ICollection<AgendaNode>  AgendaRoots { get; set; }

        public Agenda()
        {
            AgendaRoots = new List<AgendaNode>();
        }

        public Agenda(ICollection<AgendaNode> agendaRoots)
        {
            AgendaRoots = agendaRoots;
        }
    }
}