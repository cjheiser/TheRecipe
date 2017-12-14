using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Newtonsoft.Json;
using Xamarin.Forms;
using static TheRecipe.Recipe;

namespace TheRecipe
{
    public partial class RestPage : ContentPage
    {
        public RestPage(ObservableCollection<string> Ingredients)
        {
            var query = BuildQuery(Ingredients);
            GetJSON(query);

            InitializeComponent();

        }

        public string BuildQuery(ObservableCollection<string> Ingredients)
        {
            string basePath = "http://api.edamam.com/search?q=";
            string uriParams = "";
            string Apikey = "&app_id=9e585655&app_key=edb2dbd038389bb61547d2160f10522a";

            foreach (var item in Ingredients)
            {
                uriParams += item + ",";
            }
            return basePath + uriParams + Apikey;
        }

        private async void GetJSON(string query)
        {

            // Check network status  
            if (NetworkCheck.IsInternet())
            {
                var client = new System.Net.Http.HttpClient();
                var response = await client.GetAsync(query);
                string recipeJson = await response.Content.ReadAsStringAsync(); //Getting response 
                RootObject ObjRecipeList = new RootObject();
                if (recipeJson != "")
                {
                    ObjRecipeList = JsonConvert.DeserializeObject<RootObject>(recipeJson);  //Json conversion
                }

                listviewRecipe.ItemsSource = ObjRecipeList.hits;
            }
            else
            {
                await DisplayAlert("JSONParsing", "No network is available.", "Ok");
            }
            ProgressLoader.IsVisible = false;
        }

        void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return;
            }
            var item = e.SelectedItem;

            Navigation.PushAsync(new RecipeDetails((TheRecipe.Hit)item));
            
        }
             
    }


    }

