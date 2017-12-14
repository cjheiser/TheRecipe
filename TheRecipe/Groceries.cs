using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace TheRecipe
{

    public class Groceries : INotifyPropertyChanged
    {
        public string Ingred { get; set; }


        public class GroceryManager
        {
            public static List<Groceries> GetGroceries()
            {
                var Ing = new List<Groceries>();

                Ing.Add(new Groceries { Ingred = "Chicken" });
                Ing.Add(new Groceries { Ingred = "Tomato" });
                Ing.Add(new Groceries { Ingred = "Eggs" });

                return Ing;

            }
        }

       // <Entry x:Name = "userIngredient" Placeholder = "Enter Grocery Item" Completed = "Handle_Completed" ></Entry>
        //<ListView.ItemTemplate>
            //    <DataTemplate >
                        
            //        <TextBlock   />
                        
            //    </DataTemplate>
            //</ListView.ItemTemplate>

        void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

      
    }
}


// Create a List to Add Items to intially. Bind that List to an ObservableCollection call notifypropertychanged on the initial list.
