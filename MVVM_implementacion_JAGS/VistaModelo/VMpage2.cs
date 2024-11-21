using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using MVVM_implementacion_JAGS.VistaModelo;

namespace MVVM_implementacion_JAGS.VistaModelo
{
    internal class VMpage2 : BaseViewModel
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

        public async Task Volver()
        {
            await Navigation.PopAsync();
        }
        public void ProcesoSimple()
        {
        }
        #endregion
        #region COMANDOS
        public ICommand VolverCommand => new Command(async () => await Volver());
        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        #endregion

        #region CONSTRUCTOR
        public VMpage2(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion
    }
}
