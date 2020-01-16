using Caliburn.Micro;

using Foundation;

using UIKit;

using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

namespace XMCM.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : FormsApplicationDelegate
    {
        //* Private Properties
        private readonly CaliburnAppDelegate appDelegate = new CaliburnAppDelegate();

        //* Overridden Methods
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            Forms.Init();
            LoadApplication(IoC.Get<App>());

            return base.FinishedLaunching(app, options);
        }
    }
}