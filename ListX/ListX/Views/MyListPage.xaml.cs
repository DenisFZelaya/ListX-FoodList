using ListX.Models;
using ListX.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListX.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyListPage : ContentPage
    {
        public MyListPage()
        {
            InitializeComponent();
            BindingContext = new MyListPageViewModel();
        }

        private async void onItemSelected_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var details = e.Item as MyListModel;
            Debug.WriteLine(details.Detail);
            await Navigation.PushAsync(new FoodDetailPage(details.Name, details.Image, details.Ingredients));
        }
    }
}