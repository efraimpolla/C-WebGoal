using System.Data.Common;
using System.Data.Entity;
using Abp.Zero.EntityFramework;
using Agenda.Authorization.Roles;
using Agenda.MultiTenancy;
using Agenda.Users;

namespace Agenda.EntityFramework
{
    public class AgendaDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...
        public virtual IDbSet<Agendas.Agenda> Agendas { get; set; }
        public virtual IDbSet<Agendas.AgendaNode> AgendaNodes { get; set; }
        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public AgendaDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in AgendaDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of AgendaDbContext since ABP automatically handles it.
         */
        public AgendaDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public AgendaDbContext(DbConnection connection)
            : base(connection, true)
        {

        }
    }
}
