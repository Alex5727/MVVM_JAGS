using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_implementacion_JAGS.VistaModelo
{
     class VMpatron : BaseViewModel 
    {
        #region Variables
        string _Texto;
        #endregion

        #region Constructor
        #endregion

        #region Objetos
        public string Texto
        {
            get { return _Texto; }
            set { SetValue(ref _Texto, value); }
        }
        #endregion

        #region Procesos
        public async Task ProcesoAsyncrong()
        {

        }

        public void ProcesoSimple()
        {

        }
        #endregion

    }
}
