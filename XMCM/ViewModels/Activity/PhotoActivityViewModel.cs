namespace XMCM.ViewModels.Activity
{
	public class PhotoActivityViewModel : ActivityBaseViewModel
	{
		//* Public Properties
		public string Caption { get; }
		public override string Title => "Photo";

		//* Constructors
		public PhotoActivityViewModel(string caption) =>
			Caption = caption;
	}
}