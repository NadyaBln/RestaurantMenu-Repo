using Autofac;
using RestaurantMenu_BusinessLogic.Services;
using RestaurantMenu_DataAccess;

namespace RestaurantMenu_BusinessLogic
{
   public class BLRegistrationModule : Module
    {
        //there are registrations with dependence from DA
        //instead of registrations in Startup
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule<DataAccessRegistrationModule>();
            builder.RegisterType<OrderService>().As<IOrderService>();
        }
    }
}
