using Entidad;
using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NVentas
    {
        private DVentas Datos = new DVentas();
        public List<EVentas> Listar()//Funcion que lista a los clientes 
        {
            return Datos.Listar();
        }
        public int Ingresar(EVentas obj, out string Mensaje)//Funcion para ingresar cliente 
        {
            Mensaje = string.Empty;

            if (obj.Nombre == "")
            {
                Mensaje += "Es necesario el Nombre del Producto\n";
            }

            if (obj.CantidadVenta == "")
            {
                Mensaje += "Es necesario la cantidad de la venta del Producto\n";
            }

            if (obj.TotalVenta == "")
            {
                Mensaje += "Es necesario el Valor total de la venta del Producto\n";
            }

            if (obj.PrecioProducto == "")
            {
                Mensaje += "Es necesario el precio unitario de la venta del Producto\n";
            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return Datos.Ingresar(obj, out Mensaje);
            }
        }
    }
}
