using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVM_implementacion_JAGS.VistaModelo.VMpokemon
{
    public class VMregistropokemon : BaseViewModel
    {
        #region VARIABLES
        string _Txtcolorfondo;
        string _Txtcolorpoder;
        string _Txtnombre;
        string _Txtnro;
        string _Txtpoder;
        string _Txticono;

        #endregion
        #region CONSTRUCTOR

        public string Txtcolorfondo
        {
            get { return _Txtcolorfondo; }
            set { SetValue(ref _Txtcolorfondo, value); }
        }

        public string Txtcolorpoder
        {
            get { return _Txtcolorpoder; }
            set { SetValue(ref _Txtcolorpoder, value); }
        }
        public string Txtnombre
        {
            get { return _Txtnombre; }
            set { SetValue(ref _Txtnombre, value); }
        }
        public string Txtnro
        {
            get { return _Txtnro; }
            set { SetValue(ref _Txtnro, value); }
        }
        public string Txtpoder
        {
            get { return _Txtpoder; }
            set { SetValue(ref _Txtpoder, value); }
        }
        public string Txticono
        {
            get { return _Txticono; }
            set { SetValue(ref _Txticono, value); }
        }
        #endregion
        #region PROCESOS

        public async Task ProccesoAsyncrong()
        {
        }
        public void ProcesoSimple()
        {
        }
        #endregion
        #region COMANDOS
        public ICommand ProcesoAsynccommand => new Command(async () => await ProccesoAsyncrong());
        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        #endregion

        #region CONSTRUCTOR
        public VMregistropokemon(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion
    }
}
