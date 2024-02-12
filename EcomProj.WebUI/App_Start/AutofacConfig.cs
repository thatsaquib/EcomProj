using Autofac;
using Autofac.Integration.Mvc;
using EcomProj.Repository.Common.Repository.Implementation;
using EcomProj.Repository.Common.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace EcomProj.WebUI.App_Start
{
    public class AutofacConfig
    {
        public static void Register()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterModule<AutofacWebTypesModule>();
            //builder.RegisterType<yaha par classname>().As<yaha par repositoryname>();
            //builder.RegisterType<ProductRepository>().As<IProductRepository>();
            //ab ye upar wali line likhne ki zarurat nahi hai because of line number 25-29

            var assembly = Assembly.Load("EcomProj.Repository");
            builder.RegisterAssemblyTypes(assembly)
                .Where(t => t.Name.EndsWith("Repository", StringComparison.OrdinalIgnoreCase))
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}