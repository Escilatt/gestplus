using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class EInventario
    {
        public int ValIdProducto;

        public String ValNombre;

        public String ValFechaIngreso;

        public String ValValorPorUnidad;

        public String ValValorTotal;

        public String ValCantidad;

        public int IdProducto
        {
            get { return ValIdProducto;  }
            set { ValIdProducto = value; }
        }
        public String Nombre
        {
            get { return ValNombre; }
            set { ValNombre = value; }
        }
        public String FechaIngreso
        {
            get { return ValFechaIngreso; }
            set { ValFechaIngreso = value; }
        }
        public String ValorPorUnidad
        {
            get { return ValValorPorUnidad; }
            set { ValValorPorUnidad = value; }
        }
        public String ValorTotal
        {
            get { return ValValorTotal; }
            set { ValValorTotal = value; }
        }
        public String Cantidad
        {
            get { return ValCantidad; }
            set { ValCantidad = value; }
        }
    }
}
