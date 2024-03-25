using Autofac;
using Stationery.Application.Contracts;
using Stationery.Application.Services;
using Stationery.Application.Services.ServicesContracts;
using Stationery.Context.Context;
using Stationery.Infrastructure.Repositories;
using System;
using System.Collections.Generic; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stationary_Presentation.Autofac
{
    public class AutofacConfig
    {
        internal static IContainer BuildContainer()
        {
            var builder = new ContainerBuilder();

            //services
            builder.RegisterType<UserServices>().As<IUserServices>();
            //builder.RegisterType<AdminServices>().As<IAdminServices>();
            builder.RegisterType<OrderServices>().As<IOrderServices>();
            builder.RegisterType<OrderItemServices>().As<IOrderItemServices>();
            builder.RegisterType<ProductServices>().As<IProductServices>();
            builder.RegisterType<CategoryServices>().As<ICategoryServices>();
            //Rrposatories
            builder.RegisterType<UserRepository>().As<IUserRepository>();
            //builder.RegisterType<AdminRepository>().As<IAdminRepository>();
            builder.RegisterType<OrderRepository>().As<IOrderRepository>();
            builder.RegisterType<OrderItemRepository>().As<IOrderItemRepository>();
            builder.RegisterType<ProductRepository>().As<IProductRepository>();
            builder.RegisterType<CategoryRepository>().As<ICategoryRepository>();
            //context
            builder.RegisterType<StationeryContext>().As<StationeryContext>();
            //forms
            builder.RegisterType<SignUp>().As<SignUp>();
            builder.RegisterType<UserHomePage>().As<UserHomePage>();
            builder.RegisterType<AdminHomePage>().As<AdminHomePage>();
            builder.RegisterType<Login>().As<Login>();
            builder.RegisterType<CategoryCRUD>().As<CategoryCRUD>();
            builder.RegisterType<OrderForm>().As<OrderForm>();
            builder.RegisterType<ProductCRUD>().As<ProductCRUD>();


            return builder.Build();
        }
    }
}
