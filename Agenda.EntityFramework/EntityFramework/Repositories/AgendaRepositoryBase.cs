using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace Agenda.EntityFramework.Repositories
{
    public abstract class AgendaRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<AgendaDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected AgendaRepositoryBase(IDbContextProvider<AgendaDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class AgendaRepositoryBase<TEntity> : AgendaRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected AgendaRepositoryBase(IDbContextProvider<AgendaDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
