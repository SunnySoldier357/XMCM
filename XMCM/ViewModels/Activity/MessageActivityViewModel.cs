namespace XMCM.ViewModels.Activity
{
	public class MessageActivityViewModel : ActivityBaseViewModel
	{
		//* Public Properties
		public string Message { get; }
		public override string Title => "Message";

		//* Constructors
		public MessageActivityViewModel(string message) =>
			Message = message;
	}
}