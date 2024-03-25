using Stationery.Context.Context;
using Stationery.Infrastructure.Repositories;
using Stationery.Application.Services;
using Microsoft.VisualBasic.Logging;
using Stationary_Presentation.Autofac;
using Autofac;
using Microsoft.EntityFrameworkCore;
namespace Stationary_Presentation
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            StationeryContext context = new StationeryContext();
            var container = AutofacConfig.BuildContainer();
            Application.Run(container.Resolve<AdminHomePage>());

            //Application.Run(new UserHomePage(new ProductServices(new ProductRepository(context)), context));
            //Application.Run(new ProductCRUD(new CategoryServices(new CategoryRepository(new StationeryContext())), new ProductServices(new ProductRepository(new StationeryContext()))));


        }
    }
}