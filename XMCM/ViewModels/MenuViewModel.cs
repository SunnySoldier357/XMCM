using Caliburn.Micro;
using Caliburn.Micro.Xamarin.Forms;

using System.Threading.Tasks;

namespace XMCM.ViewModels
{
	public class MenuViewModel : Screen
	{
		//* Private Properties
		private readonly INavigationService _navigationService;

		//* Public Properties
		public BindableCollection<FeatureViewModel> Features { get; }

		//* Constructors
		public MenuViewModel(INavigationService navigationService)
		{
			_navigationService = navigationService;

			Features = new BindableCollection<FeatureViewModel>
			{
				// TODO: Add FeatureViewModels
			};
		}

		//* Public Methods
		public async Task ShowFeature(FeatureViewModel feature) =>
			await _navigationService.NavigateToViewModelAsync(feature.ViewModel);
	}
}