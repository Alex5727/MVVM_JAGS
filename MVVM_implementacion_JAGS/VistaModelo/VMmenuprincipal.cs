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
            public List<Mmenuprincipal> listapaginas { get; set; }

            #region CONSTRUCTOR
            public VMmenuprincipal()
            {
            MostrarPaginas();
            }
            #endregion

            public VMmenuprincipal(INavigation navigation)
            {
                Navigation = navigation;
            MostrarPaginas();
            }

        #region COMANDOS 


        public void MostrarPaginas()
        {
            listapaginas = new List<Mmenuprincipal> {

                new Mmenuprincipal
                {
                    Pagina = "Entry, datepicker, picker, label, navegacion",
                    Icono = "https://ibb.co/6sXV78m"
                },

                new Mmenuprincipal
                {
                    Pagina = "CollectionView sin enlace a Base de datos",
                    Icono = "https://ibb.co/bmG33wL"
                },

                new Mmenuprincipal
                {
                    Pagina = "Crud pokemon",
                    Icono = "https://ibb.co/9hP5Gg4"
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
            public string Pagina { get; set; }
            public string Icono { get; set; }
        }

    }
