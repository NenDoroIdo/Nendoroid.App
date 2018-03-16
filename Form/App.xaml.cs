using Form.Pages.Search.Capture;
using Form.Pages.Search.Main;
using Xamarin.Forms;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace Form
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new CameraPage()); //new MainPage();
        }

        protected override void OnStart()
        {

#if !DEBUG
            // Handle when your app starts
            AppCenter.Start("ios=57193881-deaa-4419-b401-f89675081968;" +
                            "uwp=411a559a-22c5-4918-9be4-9f92f7a99aa4;" +
                            "android=7b6bdb59-4ba0-4360-94a9-1a30c40b80d8;",
                typeof(Analytics), typeof(Crashes));
#endif

        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}