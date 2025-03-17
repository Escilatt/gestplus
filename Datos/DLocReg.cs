using Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DLocReg
    {
        private Conexion Cn = new Conexion();   //LLama a la clase, creando una variable con un nuevo nombre

        public static DLocReg _instancia = null;

        public static DLocReg Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new DLocReg();
                }
                return _instancia;
            }
        }
        public List<ELocReg> Listar()
        {
            List<ELocReg> lista = new List<ELocReg>();   //Se llama lista de variables de la Entidad llamada (Tamaño, Tipo)
            using (SqlConnection oconexion = new SqlConnection(Conexion.Conex))   //Usa la clase de conexion, crea una variable de nuevo nombre a la clase llamada
            {
                try
                {
                    StringBuilder query = new StringBuilder();  //LLama a la clase, crea una variable y genera una nueva instancia
                    query.AppendLine("Select IdReg, Nombre From LReg");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);  //LLama al procedimiento almacenado
                    cmd.CommandType = CommandType.Text;  //La variable establece el valor de texto
                    oconexion.Open();   //Abre la conexion a una base de datos
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())  //Realiza un bucle while, donde lee la variable si hay filas, si no devuelve con un false
                        {

                            lista.Add(new ELocReg()   //Agrega variables de Entidad con la clase llamada
                            {
                                IdReg = Convert.ToInt32(dr["IdReg"]),   //Se convierte en valor entero, devuelve una cadena que representa el objeto actual
                                Nombre = dr["Nombre"].ToString(),   //La variable devuelve una cadena que representa el objeto actual
                            });
                        }
                    }
                }
                catch (Exception ex)   //Excepción de las intrucciones dadas
                {
                    lista = new List<ELocReg>();  //La variable da igual una inicializacion de una nueva instancia de la clase llamando a la clase Entidad
                }
            }
            return lista;  //Devolver filas de la tabla
        }
    }
}
