using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVM_implementacion_JAGS.VistaModelo
{
    public class VMpagina1 : BaseViewModel
    {
        #region Variables
        string _Texto;
        #endregion

        #region Constructor
        public VMpagina1(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion

        #region Objetos
        public string Texto
        {
            get { return _Texto; }
            set { SetValue(ref _Texto, value); }
        }
        #endregion

        #region Procesos
        public async Task Alerta()
        {
            await DisplayAlert("Titulo", "Mensaje", "Ok");
        }

        public void ProcesoSimple()
        {

        }
        #endregion

        #region Comandos
        public ICommand Alertacommand => new Command(async () => await Alerta());
        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        #endregion


    }
}
