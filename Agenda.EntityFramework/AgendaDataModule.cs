using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using Agenda.EntityFramework;

namespace Agenda
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(AgendaCoreModule))]
    public class AgendaDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
