using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;

namespace Negocio
{
    public class NInventario
    {
        private DInventario Datos = new DInventario();
        public List<EInventario> Listar()//Funcion que lista a los clientes 
        {
            return Datos.Listar();
        }

        public int Ingresar(EInventario obj, out string Mensaje)//Funcion para ingresar cliente 
        {
            Mensaje = string.Empty;

            if (obj.Nombre == "")
            {
                Mensaje += "Es necesario el Nombre del Producto\n";
            }

            if (obj.FechaIngreso == "")
            {
                Mensaje += "Es necesario la Fecha de Ingreso del Producto\n";
            }

            if (obj.ValorPorUnidad == "")
            {
                Mensaje += "Es necesario el Valor por Unidad del Producto\n";
            }

            if (obj.ValorTotal == "")
            {
                Mensaje += "Es necesario el Valor Total del Producto\n";
            }

            if (obj.Cantidad == "")
            {
                Mensaje += "Es necesario la Cantidad del Producto\n";
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
        public bool Actualizar(EInventario obj, out string Mensaje)//Funcion para ingresar cliente 
        {
            Mensaje = string.Empty;

            if (obj.Nombre == "")
            {
                Mensaje += "Es necesario el Nombre del Producto\n";
            }

            if (obj.FechaIngreso == "")
            {
                Mensaje += "Es necesario la Fecha de Ingreso del Producto\n";
            }

            if (obj.ValorPorUnidad == "")
            {
                Mensaje += "Es necesario el Valor por Unidad del Producto\n";
            }

            if (obj.ValorTotal == "")
            {
                Mensaje += "Es necesario el Valor Total del Producto\n";
            }

            if (obj.Cantidad == "")
            {
                Mensaje += "Es necesario la Cantidad del Producto\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return Datos.Actualizar(obj, out Mensaje);
            }

        }
        public bool Eliminar(EInventario obj, out string Mensaje)//Funcion para eliminar cliente 
        {
            return Datos.Eliminar(obj, out Mensaje);
        }
    }
}
