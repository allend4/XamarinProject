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
	public partial class MeatRecipe : ContentPage
	{
		public MeatRecipe ()
		{
			InitializeComponent ();
		}

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Recipe1()); //teriyaki chicken
        }

        private void ImageButton_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Recipe3());// basil halumi
        }

        private void ImageButton_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Recipe4());// sausage
        }

        private void ImageButton_Clicked_3(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Recipe5());// basil chicken
        }

        private void ImageButton_Clicked_4(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Recipe6());// mongolian beef
        }

        private void ImageButton_Clicked_5(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Recipe7());// taco pasta
        }

        private void ImageButton_Clicked_6(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Recipe8());// Caprese Chicken
        }

        private void ImageButton_Clicked_7(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Recipe9());// quinoa pizza bowl
        }
    }
}