using System;
using Autofac;
using Autofac.Extras.CommonServiceLocator;
using CommonServiceLocator;
using SampleAutoFacDI.ViewModels;
using ServiceManager;

namespace SampleAutoFacDI
{
    public sealed class AutoFacContainer
    { 
        public static void Initialize()
        {
            ContainerBuilder containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterType<MainPageViewModel>().AsSelf();
            containerBuilder.RegisterType<EmployeeService>().As<IEmployeeService>();

            IContainer container = containerBuilder.Build();

            AutofacServiceLocator autofacServiceLocator = new AutofacServiceLocator(container);
            ServiceLocator.SetLocatorProvider(() => autofacServiceLocator); 
        }
    }
}
