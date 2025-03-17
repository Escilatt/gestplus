using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NLocPro
    {
        public List<ELocPro> Listar()
        {
            return DLocPro.Instancia.Listar();
        }
        public DataTable Filtrar(int IdPro)
        {
            return DLocPro.Instancia.Filtrar(IdPro);
        }
    }
}
