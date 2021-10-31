using Autofac;
using Business.Interfaces;
using Business.Services;
using Persistence.Repositories;

namespace IoC
{
    public class CoreModule:Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<LoggingService>().As<ILoggingService>();
            builder.RegisterType<LoggingRepository>().As<ILoggingRepository>();
            //builder.RegisterType<EarningService>().As<IEarningService>();
            //builder.RegisterType<EarningRepository>().As<IEarningRepository>();
        }
    }
}