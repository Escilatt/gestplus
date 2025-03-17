using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;

namespace Negocio
{
    public class NEmpleado
    {
        private DEmpleado Datos = new DEmpleado();
        public List<EEmpleado> Listar()//Funcion que lista a los clientes 
        {
            return Datos.Listar();
        }

        public int Ingresar(EEmpleado obj, out string Mensaje)//Funcion para ingresar cliente 
        {
            Mensaje = string.Empty;

            if (obj.Nombre == "")
            {
                Mensaje += "Es necesario el Nombre del Empleado\n";
            }

            if (obj.Apellido == "")
            {
                Mensaje += "Es necesario el Apellido del Empleado\n";
            }

            if (obj.Rut == "")
            {
                Mensaje += "Es necesario el Rut del Empleado\n";
            }

            if (obj.Direccion == "")
            {
                Mensaje += "Es necesario el Direccion del Empleado\n";
            }

            if (obj.FechNa == "")
            {
                Mensaje += "Es necesario la fecha de nacimiento del Empleado\n";
            }

            if (obj.Tel == "")
            {
                Mensaje += "Es necesario el Telefono del Empleado\n";
            }

            if (obj.Correo == "")
            {
                Mensaje += "Es necesario el Correo del Empleado\n";
            }

            if (obj.Contratacion == "")
            {
                Mensaje += "Es necesario la fecha de contratacion del Empleado\n";
            }

            if (obj.Cargo == "")
            {
                Mensaje += "Es necesario el cargo del Empleado\n";
            }

            if (obj.VaHo == "")
            {
                Mensaje += "Es necesario el valor por hora del Empleado\n";
            }
            if (obj.VaHoEx == "")
            {
                Mensaje += "Es necesario el valor por hora extra del Empleado\n";
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

        public bool Actualizar(EEmpleado obj, out string Mensaje)//Funcion para ingresar cliente 
        {
            Mensaje = string.Empty;

            if (obj.Nombre == "")
            {
                Mensaje += "Es necesario el Nombre del Empleado\n";
            }

            if (obj.Apellido == "")
            {
                Mensaje += "Es necesario el Apellido del Empleado\n";
            }

            if (obj.Rut == "")
            {
                Mensaje += "Es necesario el Rut del Empleado\n";
            }

            if (obj.Direccion == "")
            {
                Mensaje += "Es necesario el Direccion del Empleado\n";
            }

            if (obj.FechNa == "")
            {
                Mensaje += "Es necesario la fecha de nacimiento del Empleado\n";
            }

            if (obj.Tel == "")
            {
                Mensaje += "Es necesario el Telefono del Empleado\n";
            }

            if (obj.Correo == "")
            {
                Mensaje += "Es necesario el Correo del Empleado\n";
            }

            if (obj.Contratacion == "")
            {
                Mensaje += "Es necesario la fecha de contratacion del Empleado\n";
            }

            if (obj.Cargo == "")
            {
                Mensaje += "Es necesario el cargo del Empleado\n";
            }

            if (obj.VaHo == "")
            {
                Mensaje += "Es necesario el valor por hora del Empleado\n";
            }
            if (obj.VaHoEx == "")
            {
                Mensaje += "Es necesario el valor por hora extra del Empleado\n";
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

        public bool Eliminar(EEmpleado obj, out string Mensaje)//Funcion para eliminar cliente 
        {
            return Datos.Eliminar(obj, out Mensaje);
        }
    }
}