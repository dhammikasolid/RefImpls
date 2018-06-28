using Autofac;

namespace API.Customers
{
    public class CustomerModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            //builder.Register(c => 
            //{
            //    return new CustomerContext(c.Resolve<DbConnection>()); 
            //})
            //.As<CustomerContext>()
            //.InstancePerRequest();
            builder.RegisterType<CustomerContext>().AsSelf();

            builder.RegisterType<CustomerSerive>().AsSelf();
            builder.RegisterType<CustomerRepository>().AsImplementedInterfaces();
        }
    }
}