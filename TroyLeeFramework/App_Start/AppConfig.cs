
namespace TroyLeeFramework
{
    using System.Reflection;
    using System.Web.Mvc;
    using Autofac;
    using Autofac.Integration.Mvc;
    using TroyLeeFramework.Data;

    using TroyLeeFramework.Data.Repositories;
    using TroyLeeFramework.Mappers;

    public static class AppConfig
    {
        public static void Run()
        {
            SetAutofacContainer();
            AutoMapperConfiguration.Configure();
        }
        private static void SetAutofacContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            builder.RegisterAssemblyTypes(typeof(ArticleRepository).Assembly)
            .Where(t => t.Name.EndsWith("Repository"))
            .AsImplementedInterfaces().InstancePerHttpRequest();
            var context = new TroyLeeFrameworkDataContext("TroyLeeFrameworkDataContext");
            //builder.RegisterInstance(context).As<TroyLeeFrameworkDataContext>().SingleInstance();
            context.Database.Initialize(true);
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}