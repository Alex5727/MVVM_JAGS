﻿using MVVM_implementacion_JAGS.Vistas;
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
        #region VARIABLES
        string _N1;
        string _N2;
        string _R;
        #endregion

        #region CONSTRUCTOR
        public VMpagina1(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion

        #region OBJETOS
        public string N1
        {
            get { return _N1; }
            set { SetValue(ref _N1, value); }
        }

        public string N2
        {
            get { return _N2; }
            set { SetValue(ref _N2, value); }
        }

        public string R
        {
            get { return _R; }
            set { SetValue(ref _R, value); }
        }
        #endregion

        #region PROCESOS
        public async Task Procesoasync()
        { }

        public void Sumar()
        {
            double n1 = 0;
            double n2 = 0;
            double r = 0;

            n1 = Convert.ToDouble(N1);
            n2 = Convert.ToDouble(N2);
            r = n1 + n2;
            R = r.ToString();
        }

        public void ProcesoSimple()
        {
        }
        #endregion

        #region COMANDOS
        public ICommand suymarcommand => new Command(Sumar);
        public ICommand Procesoasynccomand => new Command(async () => await Procesoasync());
        #endregion
    }
}