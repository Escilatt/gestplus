using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NLocReg
    {
        public List<ELocReg> Listar()
        {
            return DLocReg.Instancia.Listar();  //Devuelve el campo de la lista de la clase Entidad
        }
    }
}
