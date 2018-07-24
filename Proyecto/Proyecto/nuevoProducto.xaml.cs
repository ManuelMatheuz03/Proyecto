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
	public partial class nuevoProducto : ContentPage
    {
        private SQLiteConnection conn;
        public Inventario inventario;

        public nuevoProducto ()
		{
			InitializeComponent ();
            conn = DependencyService.Get<ISQLite>().GetConnection();
            conn.CreateTable<Inventario>();
        }
        private void SaveButton_Clicked(object sender, EventArgs e)
        {
            inventario = new Inventario();
            inventario.Producto = Producto.Text;
            inventario.Cantidad = Cantidad.Text;
            inventario.Medida = Medida.Text;
            conn.Insert(inventario);
            Producto.Text = "";
            Cantidad.Text = "";
            Medida.Text = "";
        }

    }
}