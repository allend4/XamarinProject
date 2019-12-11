using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Project
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AddRecipe : ContentPage
	{
        string _fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "NewRecipe.txt");

        public AddRecipe()
        {
            InitializeComponent();

            if (File.Exists(_fileName))
            {
                _editor.Text = File.ReadAllText(_fileName);
            }
        }
        // saves text my saving to file
        private void SaveBtn_Clicked(object sender, EventArgs e)
        {
            File.WriteAllText(_fileName, _editor.Text);
        }
        // deletes text as overwrites information
        private void DeleteBtn_Clicked(object sender, EventArgs e)
        {
            if (File.Exists(_fileName))
            {
                File.Delete(_fileName);
            }
            _editor.Text = string.Empty;
        }
    }
}