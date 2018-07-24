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
	public partial class nuevoPedido : ContentPage
	{
        private SQLiteConnection conn;
        public Pedido pedido;

		public nuevoPedido ()
		{
			InitializeComponent ();
            conn = DependencyService.Get<ISQLite>().GetConnection();
            conn.CreateTable<Pedido>();
        }

        private void SaveButton_Clicked(object sender, EventArgs e)
        {
            pedido = new Pedido();
            pedido.Semana = Semana.Text;
            pedido.Contrato = Contrato.Text;
            conn.Insert(pedido);
            Semana.Text = "";
            Contrato.Text = "";
        }
       
    }
}