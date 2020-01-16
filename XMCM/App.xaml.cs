using Caliburn.Micro;
using Caliburn.Micro.Xamarin.Forms;

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

			_container
				.PerRequest<ShellViewModel>();

			Initialize();

			DisplayRootViewFor<ShellViewModel>();
		}
	}
}