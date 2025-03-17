using Entidad;
using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NLogin
    {
        private DLogin Datos = new DLogin();

        public int IngSig(string Nombre, string Pass, out string Mensaje)
        {
            return DLogin.Instancia.IngSig(Nombre, Pass, out Mensaje);
        }
    }
}
