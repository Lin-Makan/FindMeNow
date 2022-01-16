using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using FindMeNow.ViewModels;
using FindMeNow.Repositories;
using System.Reflection;
using System.Linq;
using Xamarin.Forms;

namespace FindMeNow
{
    public class Bootstrapper
    {
        protected ContainerBuilder ContainerBuilder
        {
            get; private set;
        }
        public Bootstrapper()
        {
            Initialize();
            FinishInitialization();
        }
        protected virtual void Initialize()
        {
            ContainerBuilder = new ContainerBuilder();
            var currentAssembly = Assembly.GetExecutingAssembly();
            foreach (var type in currentAssembly.DefinedTypes.
            Where(e => e.IsSubclassOf(typeof(Page))))
            {
                ContainerBuilder.RegisterType(type.AsType());
            }
            foreach (var type in currentAssembly.DefinedTypes.
            Where(e => e.IsSubclassOf(typeof(ViewModel))))
            {
                ContainerBuilder.RegisterType(type.AsType());
            }
            ContainerBuilder.RegisterType<LocationRepository>
            ().As<ILocationRepository>();
        }
        private void FinishInitialization()
        {
            var container = ContainerBuilder.Build();
            Resolver.Initialize(container);
        }
    }
}
