using Caliburn.Micro;

using System;
using System.Collections.Generic;
using System.Reflection;

using Windows.ApplicationModel.Activation;

using Xamarin.Forms;

using XMCM.ViewModels;

namespace XMCM.UWP
{
    public sealed partial class App : CaliburnApplication
    {
        //* Private Properties
        private WinRTContainer _container;

        //* Constructors
        public App()
        {
            Initialize();
            InitializeComponent();
        }

        //* Overridden Methods
        protected override void BuildUp(object instance) =>
            _container.BuildUp(instance);

        protected override void Configure()
        {
            _container = new WinRTContainer();

            _container.RegisterWinRTServices();

            _container
                .Instance(_container);

            _container
                .Singleton<XMCM.App>();

            // TODO: Register any Platform Specific abstractions here
        }

        protected override IEnumerable<object> GetAllInstances(Type service) =>
            _container.GetAllInstances(service);

        protected override object GetInstance(Type service, string key) =>
            _container.GetInstance(service, key);

        protected override void OnLaunched(LaunchActivatedEventArgs args)
        {
            if (args.PreviousExecutionState == ApplicationExecutionState.Running)
                return;

            Forms.Init(args);

            // Loads our MainPage as the root frame
            DisplayRootView<MainPage>();
        }

        protected override IEnumerable<Assembly> SelectAssemblies()
        {
            // Get a list of all assemblies that will be used by the
            // IoC container
            return new[]
            {
                GetType().Assembly,
                typeof(MenuViewModel).Assembly
            };
        }
    }
}