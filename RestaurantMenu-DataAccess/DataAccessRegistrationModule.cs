using Autofac;
using RestaurantMenu_DataAccess.Repositories;

namespace RestaurantMenu_DataAccess
{
    public class DataAccessRegistrationModule : Module
    {
        //there are registrations for DB (DA)
        //instead of registrations in Startup
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<MenuDataContext>().AsSelf();
            builder.RegisterType<OrderRepository>().As<IOrderRepository>();
        }
    }
}
