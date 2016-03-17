using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Abp.Application.Services.Dto;
using Castle.Core.Internal;

namespace Agenda.Agendas
{
    public class AgendaNode : EntityDto<long>
    {
        public virtual int Numero { get; set; }
        public virtual long? PaiId { get; set; }
        public virtual AgendaNode Pai { get; set; }

        [ForeignKey("PaiId")]
        public virtual ICollection<AgendaNode > Nodes { get; set; }

        public virtual long? AgendaId { get; set; }
        public virtual Agenda Agenda { get; set; }

        public AgendaNode()
        {
            Numero = -1;
            Nodes = new List<AgendaNode>();
        }

        public AgendaNode(int numero, long? paiId, ICollection<AgendaNode> nodes, long? agendaId, Agenda agenda, AgendaNode pai)
        {
            Nodes = nodes;
            Numero = numero;
            PaiId = paiId;
            AgendaId = agendaId;
            Agenda = agenda;
            Pai = pai;
        }

        public virtual int CalculaTamanhoTotal()
        {

            return  1+ CalculaTamanhoTotal(Nodes);
        }

        private int CalculaTamanhoTotal(ICollection<AgendaNode> nodes)
        {
            var tamanho = 0;
            foreach (var agendaNode in nodes)
            {
                tamanho += agendaNode.CalculaTamanhoTotal(agendaNode.Nodes);
                tamanho ++;
            }
            return tamanho; 
        }

        public void CriaRoot(int numero, Agenda agenda)
        {
            Numero = numero;
            Agenda = agenda;
        }

        public void CriaNode(int numero, AgendaNode pai)
        {
            Numero = numero;
            Pai = pai;
        }

        public void AdicionaNode(AgendaNode filho)
        {
            Nodes.Add(filho);
        }
    }
}