using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using System.ComponentModel;
using static TheRecipe.Groceries;

namespace TheRecipe
{
    public partial class GroceryList : ContentPage 
    {
        public GroceryList()
        {
           BindingContext = this; 
           Ingredients = new ObservableCollection<string>();

            InitializeComponent();

        }
       
        public void AddIngredients(string Ingredient)
        {
            Ingredients.Add(Ingredient);

        }



        void Handle_Completed(object sender, System.EventArgs e)
        {
            var text = userIngredient.Text;

            AddIngredients(text);

            userIngredient.Text = "";

        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync( new RestPage(Ingredients));

        }

        public ObservableCollection<string> Ingredients { get; set; }
}
    }

