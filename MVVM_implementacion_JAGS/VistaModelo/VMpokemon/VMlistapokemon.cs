using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using MVVM_implementacion_JAGS.Modelo;
using MVVM_implementacion_JAGS.Vistas;
using MVVM_implementacion_JAGS.Vistas.Pokemon;
using MVVM_implementacion_JAGS.Datos;

namespace MVVM_implementacion_JAGS.VistaModelo.VMpokemon
{
    public class VMlistapokemon : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        List<Mpokemon> _Listapokemon;
        #endregion
        #region CONSTRUCTOR
        public VMlistapokemon(INavigation navigation)
        {
            Navigation = navigation;
            MostrarPokemon();
        }


        public List<Mpokemon> Listapokemon
        {
            get { return _Listapokemon; }
            set { SetValue(ref _Listapokemon, value); }
        }
        #endregion
        #region PROCESOS
        public async Task MostrarPokemon()
        {
            var funcion = new Dpokemon();
            Listapokemon = await funcion.MostrarPokemones();
        }

        public async Task Iraregistro()
        {
            await Navigation.PushAsync(new RegistrarPokemon());
        }
        public void ProcesoSimple()
        {
        }
        #endregion
        #region COMANDOS
        public ICommand Iraregistrocommand => new Command(async () => await Iraregistro());
        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        #endregion

        #region CONSTRUCTOR

        #endregion
    }
}

