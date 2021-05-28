using ListX.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ListX.ViewModel
{
    class MyListPageViewModel
    {
        public ObservableCollection<MyListModel> FoodList { get; set; }
        public MyListPageViewModel()
        {
            FoodList = new ObservableCollection<MyListModel>();
            FoodList.Add(new MyListModel { 
                Name = "Amburger", 
                Detail = "This is an amburger", 
                Ingredients = "Lechuga y tomate",
                Image = "https://cdn131.picsart.com/290410756003211.png"
            });            
            FoodList.Add(new MyListModel { 
                Name = "Choco Banano", 
                Detail = "The Best Flavor", 
                Ingredients = "Bananas and chocolate",
                Image = "https://cdn.shopify.com/s/files/1/0289/3381/6355/files/BananaChocolate-Image.png"
            });            
            FoodList.Add(new MyListModel { 
                Name = "Pizza", 
                Detail = "The Best Italian Pizza", 
                Ingredients = "Queeze, Motzarella",
                Image = "https://assets.stickpng.com/images/580b57fcd9996e24bc43c1e1.png"
            });
        }
    }
}
