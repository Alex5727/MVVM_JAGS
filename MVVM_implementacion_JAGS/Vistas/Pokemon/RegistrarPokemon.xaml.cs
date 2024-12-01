using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MVVM_implementacion_JAGS.Vistas.Pokemon;

using MVVM_implementacion_JAGS.VistaModelo.VMpokemon;
namespace MVVM_implementacion_JAGS.Vistas.Pokemon
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrarPokemon : ContentPage
    {
        public RegistrarPokemon()
        {
            InitializeComponent();
            BindingContext = new VMregistropokemon(Navigation);
        }
    }
}