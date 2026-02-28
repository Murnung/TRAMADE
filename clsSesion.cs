using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMADE
{
    internal class clsSesion
    {
        public static int id_usuario;
        public static int nombre_usuario;

        public clsSesion() { }

        public void setIdUsuario(int valor)
        {
            id_usuario = valor;
        }  

        public void setNombreUsuario(int valor)
        {
            nombre_usuario = valor;
        }   
    }
}
