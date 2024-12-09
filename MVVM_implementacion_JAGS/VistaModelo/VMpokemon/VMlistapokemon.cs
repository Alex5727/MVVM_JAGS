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
using System.Collections.ObjectModel;

namespace MVVM_implementacion_JAGS.VistaModelo.VMpokemon
{
    public class VMlistapokemon : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        ObservableCollection<Mpokemon> _Listapokemon;
        #endregion
        #region CONSTRUCTOR
        public VMlistapokemon(INavigation navigation)
        {
            Navigation = navigation;
            MostrarPokemon();
        }


        public ObservableCollection<Mpokemon> Listapokemon
        {
            get { return _Listapokemon; }
            set { SetValue(ref _Listapokemon, value);
                OnPropertyChanged();

            }
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
        public async Task Iradetalle(Mpokemon parametros)
        {
            await Navigation.PushAsync(new DetallePokemon(parametros));
        }
        public void ProcesoSimple()
        {
        }
        #endregion
        #region COMANDOS
        public ICommand Iraregistrocommand => new Command(async () => await Iraregistro());
        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        public ICommand Iradetallecommand => new Command<Mpokemon>(async (p) => await Iradetalle(p));

        #endregion

        #region CONSTRUCTOR

        #endregion
    }
}

