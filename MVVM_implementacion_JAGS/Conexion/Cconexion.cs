using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Firebase.Database;

namespace MVVM_implementacion_JAGS.Conexion
{
    public class Cconexion
    {
        public static FirebaseClient firebase = new FirebaseClient("https://mvvmjags-default-rtdb.firebaseio.com/");


    }
}
