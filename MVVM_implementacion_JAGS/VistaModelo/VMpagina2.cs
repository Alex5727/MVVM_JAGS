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
                    Imagen = "https://ibb.co/6sXV78m"
                },

                new Musuarios
                {
                    Nombre = "Alejandro",
                    Imagen = "https://ibb.co/bmG33wL"
                },

                new Musuarios
                {
                    Nombre = "Grijalva",
                    Imagen = "https://ibb.co/9hP5Gg4"
                }
            };
            }

            public async Task Volver()
            {
            }
            public ICommand Volvercommand => new Command(async () => await Volver());
        

        public async Task Alerta(Musuarios parametros)
        {
            await DisplayAlert("Titulo", parametros.Nombre, "OK");
        }
        public ICommand Alertacommand => new Command<Musuarios>(async (p) => await Alerta(p));



     
        }
        #endregion
    public class Musuarios
    {
            public string Nombre { get; set; }
            public string Imagen { get; set; }
        }

    }
