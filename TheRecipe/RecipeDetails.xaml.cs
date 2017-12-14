using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TheRecipe
{
    public partial class RecipeDetails : ContentPage
    {

        public RecipeDetails(Hit RD)
        {
            BindingContext = RD;
            InitializeComponent();
        }

       
    }
}
