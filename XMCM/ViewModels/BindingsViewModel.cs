using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Text;
using XMCM.ViewModels.Activity;

namespace XMCM.ViewModels
{
	public class BindingsViewModel : Screen
	{
		//* Private Properties
		private ActivityBaseViewModel selectedActivity;

		//* Public Properties
		public ActivityBaseViewModel SelectedActivity
		{
			get => selectedActivity;
			set => Set(ref selectedActivity, value);
		}

		public BindableCollection<ActivityBaseViewModel> Activities { get; }

		//* Constructors
		public BindingsViewModel()
		{
			Activities = new BindableCollection<ActivityBaseViewModel>
			{
				new MessageActivityViewModel(Lipsum.Get()),
				new PhotoActivityViewModel(Lipsum.Get()),
				new MessageActivityViewModel(Lipsum.Get()),
				new PhotoActivityViewModel(Lipsum.Get())
			};
		}
	}
}