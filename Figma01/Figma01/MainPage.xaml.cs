using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Figma01
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Kartochka.Source = ImageSource.FromResource("Figma01.haip.jpeg");
            //
        }

        private async void btnPasenis_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SecondPage());
        }
    }
}
