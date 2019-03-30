using Plugin.Connectivity;
using Plugin.Connectivity.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ConnectivityCheck
{
    public static class InternetConnectivityCheck
    {
        public static void CurrentOnConnectivityTypeChanged(object sender, ConnectivityTypeChangedEventArgs connectivityTypeChangedEventArgs)
        {
            try
            {
                if (!connectivityTypeChangedEventArgs.IsConnected)
                { 
                    NoNetwork();  
                    return;
                }
                else
                {
                    ConnectionRestored();
                }

 
            }
            catch (Exception ex)
            {

            }
        }

        public static void CurrentOnConnectivityChanged(object sender, ConnectivityChangedEventArgs connectivityChangedEventArgs)
        {
            try
            {
                if (connectivityChangedEventArgs.IsConnected)
                { 
                
                    ConnectionRestored();
                  
                }
            }
            catch (Exception ex)
            {

            }
        }
        public static void SetupConnectionListeners()
        {
            try
            {
                CrossConnectivity.Current.ConnectivityChanged += CurrentOnConnectivityChanged;
                CrossConnectivity.Current.ConnectivityTypeChanged += CurrentOnConnectivityTypeChanged;
            }
            catch(Exception ex)
            {

            }
            } 
        public static void ConnectionRestored()
        {
            try
            {
               
                MessagingCenter.Send<string, string>("ConnectivityCheck", "Connectivity", "INTERNET CONNECTION RESTORED");
                   
            }
            catch (Exception ex)
            {

            }

        }

        public static void NoNetwork()
        {
            try
            { 
                
                        MessagingCenter.Send<string, string>("ConnectivityCheck", "Connectivity", "NO INTERNET CONNECTION");
                        

            }
            catch (Exception ex)
            {

            }
        }
    }
}
