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
	public partial class Inventarios : ContentPage
    {
        private SQLiteConnection conn;
        public Inventarios ()
		{
			InitializeComponent ();
            conn = DependencyService.Get<ISQLite>().GetConnection();
        }

        async void btnNuevoProducto_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new nuevoProducto());
        }

        private void ShowButton_Clicked(object sender, EventArgs e)
        {
            var data = (from inv in conn.Table<Inventario>() select inv);
            DataList.ItemsSource = data;
        }
    }
}