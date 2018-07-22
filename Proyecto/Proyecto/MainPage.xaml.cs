using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Proyecto
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            btnInicio.Clicked += BtnInicio_Clicked;
        }

        async void BtnInicio_Clicked(object sender, EventArgs e)
        {
            NavigationPage.SetHasNavigationBar(this, false);
            await Navigation.PushAsync(new Inicio());
        }
    }
}
