using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using Ejercicio1_4.Controllers;
using Ejercicio1_4.Vistas;
using System.IO;

namespace Ejercicio1_4
{
    public partial class App : Application
    {
        static DatosDB basedatos;

        public static DatosDB BaseDatos
        {
            get
            {
                if (basedatos == null)
                {
                    basedatos = new DatosDB(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "EmpleadosDB.db3"));
                }
                return basedatos;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ListaEmpleados());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
