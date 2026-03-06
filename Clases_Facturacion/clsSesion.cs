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
        public static string nombre_usuario;

        public clsSesion()
        {

        }
        public void setId_usuario(int valor)
        {
            id_usuario = valor;
        }
        public void setNombre_usuario(string valor)
        {
            nombre_usuario = valor;
        }
    }
}
