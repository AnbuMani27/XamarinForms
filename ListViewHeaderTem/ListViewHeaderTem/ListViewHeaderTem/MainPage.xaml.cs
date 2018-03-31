using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListViewHeaderTem
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            MainListView.ItemsSource = new List<string>
            {
               "Anbu","Guna","Hari","Mani","Karthi","Sathis","Poovarasan","Mukesh","Karthik"
                 
            };

            MainListView.ItemSelected += MainListView_ItemSelected;
        }
        private void MainListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            DisplayAlert("This is " + e.SelectedItem.ToString(), "", "Ok");
        }
    }
}
