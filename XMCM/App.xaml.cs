using Caliburn.Micro;
using Caliburn.Micro.Xamarin.Forms;

using System.Linq;

using Xamarin.Forms;

using XMCM.ViewModels;

namespace XMCM
{
	public partial class App : FormsApplication
	{
		//* Private Properties
		private readonly SimpleContainer _container;

		//* Constructors
		public App(SimpleContainer container)
		{
			_container = container;

			// Register all ViewModels
			GetType().Assembly.GetTypes()
				.Where(type => type.IsClass)
				.Where(type => type.Name.EndsWith("ViewModel"))
				.ToList()
				.ForEach(viewModelType => _container.RegisterPerRequest(
					viewModelType, viewModelType.ToString(), viewModelType));

			Initialize();

			MessageBinder.SpecialValues.Add("$selectedItem", c =>
			{
				var listView = c.Source as ListView;

				return listView?.SelectedItem;
			});

			DisplayRootViewFor<MenuViewModel>();
		}
	}
}