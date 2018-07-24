using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Proyecto
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Facturas : ContentPage
	{
		public Facturas ()
		{
			InitializeComponent ();
            btnNuevoPedido.Clicked += BtnNuevoPedido_Clicked;
		}

        async void BtnNuevoPedido_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new nuevoPedido());
        }
    }
}