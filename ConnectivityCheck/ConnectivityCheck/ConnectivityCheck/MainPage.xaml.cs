using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ConnectivityCheck
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            try
            {
                InitializeComponent();
                ConnectivityPopup.IsVisible = true;

                MessagingCenter.Subscribe<string, string>("ConnectivityCheck", "Connectivity", (sender, arg) =>
                {
                    if (arg == "NO INTERNET CONNECTION")
                    {
                        TxtNetworkConnection.Text = "INTERNET DISCONNECTED";
                        StackLayoutConnectyion.BackgroundColor = Color.Red;
                        ConnectivityPopup.IsVisible = true;
                    }
                    else
                    {
                        TxtNetworkConnection.Text = "INTERNET CONNECTED";
                        StackLayoutConnectyion.BackgroundColor = Color.Green;
                        ConnectivityPopup.IsVisible = true;
                    }
                });
            }
            catch(Exception ex)
            {

            }

        }
    }
}
