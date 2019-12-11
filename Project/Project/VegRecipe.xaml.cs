using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Project
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class VegRecipe : ContentPage
	{
		public VegRecipe()
		{
			InitializeComponent ();
		}

        private void ImageButton_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Recipe2()); // Avocado Soup With Feta 
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Recipe10()); // Chickpea Gyros 
        }

        private void ImageButton_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Recipe11()); // Mediterranean Baked Sweet Potatoes
        }

        private void ImageButton_Clicked_3(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Recipe12()); // Tomato and Halloumi Bake
        }

        private void ImageButton_Clicked_4(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Recipe13()); // Red Beans And Rice
        }

        private void ImageButton_Clicked_5(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Recipe14()); // Parsley And Garlic Salmon
        }

        private void ImageButton_Clicked_6(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Recipe15()); // QuinoaPizzaBowlsVeg
        }
    }
}