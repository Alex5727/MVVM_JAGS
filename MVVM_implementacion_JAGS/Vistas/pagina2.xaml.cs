using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVM_implementacion_JAGS.Modelo;
using MVVM_implementacion_JAGS.VistaModelo;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVM_implementacion_JAGS.Vistas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class pagina2 : ContentPage
	{
		public pagina2 ()
		{
			InitializeComponent ();

            BindingContext = new VMpagina2(Navigation);
        }
	}
}