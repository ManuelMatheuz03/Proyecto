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
            var user = UserEntry.Text;
            var password = PasswordEntry.Text;
            if (String.IsNullOrEmpty(user) || String.IsNullOrEmpty(UserEntry.Text))
            {
                await DisplayAlert("Error", "Ingrese usuario", "Volver");
                return;
            }
            else if (String.IsNullOrEmpty(password) || String.IsNullOrEmpty(PasswordEntry.Text))
            {
                await DisplayAlert("Error", "Ingrese contraseña", "Volver");
                return;
            }
            else if (UserEntry.Text == "Manuel" && PasswordEntry.Text == "manuel123" || UserEntry.Text == "Daniel" && PasswordEntry.Text == "daniel123")
            {
                await Navigation.PushAsync(new Inicio());
            }
            else
            {
                await DisplayAlert("Error", "Usuario y/o contraseña invalidos", "Volver");
                return;
            }

            


        }
    }
}
