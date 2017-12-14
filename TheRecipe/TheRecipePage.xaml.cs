using Xamarin.Forms;

namespace TheRecipe
{
    public partial class TheRecipePage : ContentPage
    {
        public TheRecipePage()
        {
            InitializeComponent();
        }
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new GroceryList());
        }
    }
}
