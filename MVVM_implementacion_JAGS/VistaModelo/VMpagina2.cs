using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using MVVM_implementacion_JAGS.Modelo;
using MVVM_implementacion_JAGS.VistaModelo;


namespace MVVM_implementacion_JAGS.VistaModelo
{
        public class VMpagina2 : BaseViewModel
        {
            private string _Texto;
            public List<Musuarios> listaUsuarios { get; set; }

            #region CONSTRUCTOR
            public VMpagina2()
            {

                MostrarUsuarios();
            }
            #endregion

            public VMpagina2(INavigation navigation)
            {
                Navigation = navigation;
                MostrarUsuarios();
            }

            #region COMANDOS 


            public void MostrarUsuarios()
            {
            listaUsuarios = new List<Musuarios> {

                new Musuarios
                {
                    Nombre = "Alex",
                    Imagen = "https://ibb.co/wg7cWjS"
                },

                new Musuarios
                {
                    Nombre = "Alejandro",
                    Imagen = "https://ibb.co/tHVKRqJ"
                },

                new Musuarios
                {
                    Nombre = "Grijalva",
                    Imagen = "https://ibb.co/wc7XsN4"
                }
            };
            }

            public async Task Cualquiera()
            {
            }
            public ICommand Volvercommand => new Command(async () => await Cualquiera());
            #endregion

        }

        public class Musuarios
    {
            public string Nombre { get; set; }
            public string Imagen { get; set; }
        }

    }
