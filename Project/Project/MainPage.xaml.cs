using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Project
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnNoVeg_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MeatRecipe()); // meat recipes
        }

        private void BtnVeg_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new VegRecipe()); // vegetarian recipes
        }

        private void BtnAddRecipe_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddRecipe()); // add your own recipe
        }
    }
}
