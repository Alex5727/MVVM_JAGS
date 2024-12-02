using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using MVVM_implementacion_JAGS.Modelo;
using MVVM_implementacion_JAGS.Vistas;
using MVVM_implementacion_JAGS.Vistas.Pokemon;

namespace MVVM_implementacion_JAGS.VistaModelo.VMpokemon
{
    public class VMlistapokemon : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        #endregion
        #region CONSTRUCTOR

        public string Texto
        {
            get { return _Texto; }
            set { SetValue(ref _Texto, value); }
        }
        #endregion
        #region PROCESOS

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
        public VMlistapokemon(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion
    }
}
