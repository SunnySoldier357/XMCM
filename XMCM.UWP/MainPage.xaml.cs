using Caliburn.Micro;

namespace XMCM.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();

            LoadApplication(IoC.Get<XMCM.App>());
        }
    }
}