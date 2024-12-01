using MVVM_implementacion_JAGS.VistaModelo;
using MVVM_implementacion_JAGS.Vistas;
using MVVM_implementacion_JAGS.Vistas.Pokemon;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace MVVM_implementacion_JAGS
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new RegistrarPokemon());        

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
