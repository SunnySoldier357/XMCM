using System;

namespace XMCM.ViewModels
{
	public class FeatureViewModel
	{
		//* Public Properties
		public string Description { get; }
		public string Title { get; }

		public Type ViewModel { get; }

		//* Constructors
		public FeatureViewModel(string title, string description, Type viewModel)
		{
			Description = description;
			Title = title;

			ViewModel = viewModel;
		}
	}
}