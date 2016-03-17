using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Domain.Repositories;

namespace Agenda.Agendas
{
    public class AgendaManager : IAgendaManager
    {
        #region Implementation of IAgendaManager

        /// <summary>
        /// insere na arvore
        /// </summary>
        /// <param name="stringList">lista com todos os contatos</param>
        /// <returns>tamanho necessario para inserir </returns>
        public Task<int> InsertAndGetTamanho(ICollection<string> stringList)
        {


            var agenda = new Agenda();

            foreach (var contato in stringList)
            {
                
                if (!agenda.AgendaRoots.Any())
                {
                    var node = new AgendaNode() ;
                    node.CriaRoot(int.Parse(contato[0].ToString()), agenda);
                    //node =
                    CriaNode(contato, 1, ref node);
                    agenda.AgendaRoots.Add(node);
                }
                else
                {
                    var node = agenda.AgendaRoots.FirstOrDefault( x => x.Numero == int.Parse(contato[0].ToString()));
                    if (node != null )
                    {
                        //raiz existe
                        CriaNode(contato, 0, ref node);
                    }
                    else
                    {
                        //nova raiz
                        node = new AgendaNode();
                        node.CriaRoot(int.Parse(contato[0].ToString()), agenda);
                        CriaNode(contato, 1, ref node);
                        agenda.AgendaRoots.Add(node);
                    }
                }
            }
           
            return Task.FromResult(agenda.AgendaRoots.Sum(agendaRoot => agendaRoot.CalculaTamanhoTotal()));


        }
        /// <summary>
        /// Cria novo node
        /// </summary>
        /// <param name="numeros">contado a ser adicionado</param>
        /// <param name="index">posicao da string</param>
        /// <param name="pai"> referencia para o node pai</param>
        private void CriaNode(string numeros, int index, ref AgendaNode pai)
        {
            if (index >= numeros.Length)
            {
                return;
            }
            //cria novo no se nao existe
            if (pai.Numero != int.Parse(numeros[index].ToString()))
            {
                
                var novoNode = new AgendaNode();
                novoNode.CriaNode(int.Parse(numeros[index].ToString()),pai );
                pai.AdicionaNode(novoNode);
                CriaNode(numeros, index + 1, ref novoNode);
            }
            else
            {
                var filho = pai.Nodes.FirstOrDefault(x => x.Numero == int.Parse(numeros[index + 1 ].ToString()));
                if (filho != null)
                {
                    CriaNode(numeros, index + 1, ref filho);
                }
                else
                {
                    // evita que um mesmo numero que ja esteja cadastrado seja recadastrado
                    if ((index+1) >= numeros.Length)
                    {
                        return;
                    }
                    var novoNode = new AgendaNode();
                    
                    novoNode.CriaNode(int.Parse(numeros[index + 1].ToString()), pai);
                    pai.AdicionaNode(novoNode);
                    CriaNode(numeros, index + 2, ref novoNode);
              
                }

                
            }



        }

        #endregion
    }
}