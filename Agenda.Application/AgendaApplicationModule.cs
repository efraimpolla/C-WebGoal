using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;

namespace Agenda
{
    [DependsOn(typeof(AgendaCoreModule), typeof(AbpAutoMapperModule))]
    public class AgendaApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
