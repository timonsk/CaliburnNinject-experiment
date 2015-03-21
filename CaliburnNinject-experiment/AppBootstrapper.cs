using System;
using System.Collections.Generic;
using System.Windows;
using Caliburn.Micro;
using CaliburnNinjectExperiment.View;
using Ninject;

namespace CaliburnNinjectExperiment
{
    public class AppBootstrapper : BootstrapperBase
    {
        private readonly IKernel _kernel = new StandardKernel();

        public AppBootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<ShellViewModel>();
        }

        protected override void Configure()
        {
            _kernel.Bind<IWindowManager>().To<WindowManager>();
            _kernel.Load("CaliburnNinjectModule*.dll");
            _kernel.Bind<ShellViewModel>().ToSelf().InSingletonScope();

        }

        protected override IEnumerable<object> GetAllInstances(Type service)
        {
            return _kernel.GetAll(service);
        }

        protected override object GetInstance(Type service, string key)
        {
            return _kernel.Get(service, key);
        }

        protected override void BuildUp(object instance)
        {
            _kernel.Inject(instance);
        }
    }
}