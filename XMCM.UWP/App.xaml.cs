using Caliburn.Micro;

using System;
using System.Collections.Generic;
using System.Reflection;

using Windows.ApplicationModel.Activation;
using Windows.UI.Core;
using Windows.UI.Popups;
using Windows.UI.Xaml.Controls;

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
            // Initialize();
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

            Initialize();
            Xamarin.Forms.Forms.Init(args);

            // Loads our MainPage as the root frame
            DisplayRootView<MainPage>();
        }

        protected override async void OnUnhandledException(object sender,
            Windows.UI.Xaml.UnhandledExceptionEventArgs args)
        {
            //args.Handled = true;

            //var dialog = new MessageDialog(args.Message, "An error has occurred");

            //await dialog.ShowAsync();
        }

        protected override void PrepareViewFirst(Frame rootFrame)
        {
            //var navigationService = _container.RegisterNavigationService(rootFrame);
            //var navigationManager = SystemNavigationManager.GetForCurrentView();

            //navigationService.Navigated += (s, e) =>
            //{
            //    navigationManager.AppViewBackButtonVisibility = navigationService.CanGoBack ?
            //        AppViewBackButtonVisibility.Visible :
            //        AppViewBackButtonVisibility.Collapsed;
            //};
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