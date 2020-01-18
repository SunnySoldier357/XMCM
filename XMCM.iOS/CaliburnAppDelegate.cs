using Caliburn.Micro;

using System;
using System.Collections.Generic;
using System.Reflection;

using XMCM.ViewModels;

namespace XMCM.iOS
{
	public class CaliburnAppDelegate : CaliburnApplicationDelegate
	{
		//* Private Properties
		private SimpleContainer _container;

		//* Constructors
		public CaliburnAppDelegate() => Initialize();

		//* Overridden Methods
		protected override void BuildUp(object instance) =>
			_container.BuildUp(instance);

		protected override void Configure()
		{
			_container = new SimpleContainer();

			_container
				.Instance(_container);

			_container
				.Singleton<App>();

			// TODO: Register any Platform Specific abstractions here
		}

		protected override IEnumerable<object> GetAllInstances(Type service) =>
			_container.GetAllInstances(service);

		protected override object GetInstance(Type service, string key) =>
			_container.GetInstance(service, key);

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