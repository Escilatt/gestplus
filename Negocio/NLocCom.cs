using Entidad;
using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NLocCom
    {
        public List<ELocCom> Listar()
        {
            return DLocCom.Instancia.Listar();
        }

        public DataTable Filtrar(int IdCom)
        {
            return DLocCom.Instancia.Filtrar(IdCom);
        }
    }
}
