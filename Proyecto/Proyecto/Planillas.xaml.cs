using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using Proyecto.Model;

namespace Proyecto
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Planillas : ContentPage
    {
        private SQLiteConnection conn;
        public Planillas ()
		{
			InitializeComponent ();
            conn = DependencyService.Get<ISQLite>().GetConnection();
        }

        async void BtnNuevoPedido_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new nuevoPedido());
        }

        private void ShowButton_Clicked(object sender, EventArgs e)
        {
            var data = (from ped in conn.Table<Pedido>() select ped);
            DataList.ItemsSource = data;
        }
    }
}