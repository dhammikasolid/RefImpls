using Autofac;
using Facility.Data;

namespace Facility.Service
{
    public class FacilityModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.RegisterType<FacilityContext>().AsSelf();
            builder.RegisterType<FacilityService>().AsSelf();
        }
    }
}
