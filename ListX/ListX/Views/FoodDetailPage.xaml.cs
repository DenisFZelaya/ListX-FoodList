using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListX.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FoodDetailPage : ContentPage
    {
        public FoodDetailPage(string Name, string Image, string Ingredients)
        {
            InitializeComponent();
            BindingContext = Name;

            MyImageCall.Source = Image;
            MyItemNameShow.Text = Name;
            MyIngredientItemShow.Text = Ingredients;
            this.Title =  Name;
        }
    }
}