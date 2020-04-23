using Autofac;
using System.Web.Http;
using System.Reflection;
using AKQADataAPI.Services;
using Autofac.Integration.WebApi;



namespace AKQADataAPI.App_Start
{
    public class ContainerConfig
    {
        internal static void RegisterContiner(HttpConfiguration httpConfiguration)
        {
            var builder = new ContainerBuilder();
            builder.RegisterApiControllers(typeof(WebApiApplication).Assembly);
            builder.RegisterType<WordConverter>().As<IWordConverter>().InstancePerRequest();
            var container = builder.Build();
            httpConfiguration.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }


    }
}