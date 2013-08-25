using Autofac;
using Autofac.Integration.Mvc;
using Spelunk.Core;
using Spelunk.Web;
using System;
using System.Reflection;
using System.Web.Http;
using System.Web.Mvc;

namespace Spelunk.Web
{
    public class IocConfig
    {
        #region Methods

        /// <summary>
        /// Registers this instance.
        /// </summary>
        public static void Register()
        {
            // Register Autofac
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            builder.Register(_ => new BuildingService()).As<IBuildingService>();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        } 

        #endregion
    }
}