using MVVM_implementacion_JAGS.VistaModelo.VMpokemon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVM_implementacion_JAGS.Vistas.Pokemon
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListaPokemon : ContentPage
    {
        public ListaPokemon()
        {
            InitializeComponent();
            BindingContext = new VMlistapokemon(Navigation);
        }
    }
}