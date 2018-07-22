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
    public partial class Inicio : ContentPage
    {
        public Inicio()
        {
            InitializeComponent();
            imgPedidos.Clicked += ImgPedidos_Clicked;
            imgPlanillas.Clicked += ImgPlanillas_Clicked;
            imgFacturas.Clicked += ImgFacturas_Clicked;
            imgInventarios.Clicked += ImgInventarios_Clicked;
        }

        async void ImgPedidos_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pedidos());
        }

        async void ImgPlanillas_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Planillas());
        }

        async void ImgFacturas_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Facturas());
        }

        async void ImgInventarios_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Inventarios());
        }
    }
}