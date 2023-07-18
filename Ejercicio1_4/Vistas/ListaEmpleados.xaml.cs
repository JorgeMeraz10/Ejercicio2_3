using Ejercicio1_4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicio1_4.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListaEmpleados : ContentPage
    {
        public ListaEmpleados()
        {
            InitializeComponent();
        }
        private async void toolmenu_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            listapersonas.ItemsSource = await App.BaseDatos.obtenerListaEmple();
        }

        private async void liestapersonas_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var persona = (Empleados)e.Item;
            Vista_Foto page = new Vista_Foto();
            page.BindingContext = persona;
            await Navigation.PushAsync(page);

        }
    }
}