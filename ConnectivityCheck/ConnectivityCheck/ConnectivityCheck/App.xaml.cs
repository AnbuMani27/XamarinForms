using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace ConnectivityCheck
{
    public partial class App : Application
    {
        public App()
        {
            try
            {
                InitializeComponent();
                InternetConnectivityCheck.SetupConnectionListeners();
                MainPage = new MainPage();
            }catch(Exception ex)
            {

            }

        }

        protected override void OnStart()
        {
            // Handle when your app starts
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
