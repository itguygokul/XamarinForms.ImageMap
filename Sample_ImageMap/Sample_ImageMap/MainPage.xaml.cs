using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Sample_ImageMap
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            image_bg.Source = ImageSource.FromResource("Sample_ImageMap.Images.bg.png");
        }

        private void btn1_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Got you!", "You have clicked on first apple.", "OK");
        }

        private void btn2_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Got you!", "You have clicked on Second apple.", "OK");
        }

        private void btn3_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Got you!", "You have clicked on Third apple.", "OK");
        }

        private void btn4_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("locked!", "You have to ate the third apple first", "OK");
        }

        private void btn5_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("locked!", "You have to ate the third apple first", "OK");
        }
    }
}
