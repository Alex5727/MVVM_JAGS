using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using MVVM_implementacion_JAGS.Modelo;
using MVVM_implementacion_JAGS.VistaModelo;
using MVVM_implementacion_JAGS.Vistas;

namespace MVVM_implementacion_JAGS.VistaModelo
{
    public class VMmenuprincipal : BaseViewModel
    {
            private string _Texto;
            public List<Mmenuprincipal> listaUsuarios { get; set; }

            #region CONSTRUCTOR
            public VMmenuprincipal()
            {
                MostrarUsuarios();
            }
            #endregion

            public VMmenuprincipal(INavigation navigation)
            {
                Navigation = navigation;
                MostrarUsuarios();
            }

        #region COMANDOS 


        public void MostrarUsuarios()
        {
            listaUsuarios = new List<Mmenuprincipal> {

                new Mmenuprincipal
                {
                    Nombre = "Entry, datepicker, picker, label, navegacion",
                    Icono = "https://ibb.co/wg7cWjS"
                },

                new Mmenuprincipal
                {
                    Nombre = "CollectionView sin enlace a Base de datos",
                    Icono = "https://ibb.co/tHVKRqJ"
                },

                new Mmenuprincipal
                {
                    Nombre = "Crud pokemon",
                    Icono = "https://ibb.co/wc7XsN4"
                }
            };
        }

        public async Task Volver()
            {
            }
          //  public ICommand Volvercommand => new Command(async () => await Volver());


            public async Task Navegar(Mmenuprincipal parametros)
            {
            string pagina;
            pagina = parametros.Pagina;
            if(pagina.Contains("Entry, datepicker"))
            {
                await Navigation.PushAsync(new pagina1());
            }
            if (pagina.Contains("CollectionView sin enlace"))
            {
                await Navigation.PushAsync(new pagina2());
            }
            if (pagina.Contains("Crud pokemon"))
            {
                await Navigation.PushAsync(new Crudpokemon());
            }

            }
            public ICommand Navegarcommand => new Command<Mmenuprincipal>(async (p) => await Navegar(p));

        }
        #endregion
        public class Mmenuprincipal
    {
            public string Nombre { get; set; }
            public string Icono { get; set; }
        }

    }
