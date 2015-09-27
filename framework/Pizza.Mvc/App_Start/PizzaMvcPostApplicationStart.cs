using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.WebPages;
using Autofac;
using Autofac.Integration.Mvc;
using Pizza.Mvc;
using Pizza.Mvc.Filters;
using RazorGenerator.Mvc;

[assembly: WebActivatorEx.PostApplicationStartMethod(typeof(PizzaMvcPostApplicationStart), "Start")]

namespace Pizza.Mvc
{
    public static class PizzaMvcPostApplicationStart
    {
        public static void Start()
        {
            RegisterRazorGeneratedViewEngine();
            RegisterGlobalFilters();
            BootstrapAutofac();
        }

        private static void RegisterRazorGeneratedViewEngine()
        {
            var engine = new PrecompiledMvcEngine(typeof(PizzaMvcPostApplicationStart).Assembly)
            {
                UsePhysicalViewsIfNewer = HttpContext.Current.Request.IsLocal
            };

            ViewEngines.Engines.Add(engine);

            // StartPage lookups are done by WebPages. 
            VirtualPathFactoryManager.RegisterVirtualPathFactory(engine);
        }

        private static void RegisterGlobalFilters()
        {
            GlobalFilters.Filters.Add(new UniversalExceptionFilter());
            GlobalFilters.Filters.Add(new UniversalExceptionFilter());
        }

        private static void BootstrapAutofac()
        {
            var builder = new ContainerBuilder();
            var loadedAssemblies = AppDomain.CurrentDomain.GetAssemblies();
            builder.RegisterAssemblyModules(loadedAssemblies.ToArray());
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}