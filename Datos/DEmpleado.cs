using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Datos
{
    public class DEmpleado
    {
        private Conexion Cn = new Conexion();

        public static DEmpleado _instancia = null;

        public static DEmpleado Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new DEmpleado();
                }
                return _instancia;
            }
        }

        public List<EEmpleado> Listar()
        {
            List<EEmpleado> Lis = new List<EEmpleado>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.Conex))
            {
                SqlCommand cmd = new SqlCommand("Bus_Trabajador", oConexion);

                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    oConexion.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    {
                        while (dr.Read())
                        {
                            Lis.Add(new EEmpleado()
                            {
                                IdTra = Convert.ToInt32(dr["IdTra"].ToString()),
                                Nombre = dr["Nombre"].ToString(),
                                Apellido = dr["Apellido"].ToString(),
                                FechNa = dr["FechNa"].ToString(),
                                IdCom = Convert.ToInt32(dr["IdCom"].ToString()),
                                Com = new ELocCom() { Nombre = dr["NombreComuna"].ToString() },
                                Rut = dr["Rut"].ToString(),
                                Direccion = dr["Direccion"].ToString(),
                                Correo = dr["Correo"].ToString(),
                                Tel = dr["Tel"].ToString(),
                                Contratacion = dr["Contratacion"].ToString(),
                                Cargo = dr["Cargo"].ToString(),
                                VaHo = dr["VaHo"].ToString(),
                                VaHoEx = dr["VaHoEx"].ToString()
                            });
                        }
                        dr.Close();
                        return Lis;
                    }
                }
                catch (Exception)
                {
                    Lis = null;
                    return Lis;
                }
            }
            
        }



        public int Ingresar(EEmpleado obj, out string Mensaje)
        {
            int Resultado = 0;
            Mensaje = string.Empty;
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.Conex))
                {
                    // Asociar la conexión al comando
                    SqlCommand cmd = new SqlCommand("Ing_Trabajador", oconexion);

                    // Agregar los parámetros
                    cmd.Parameters.AddWithValue("Nombre", obj.Nombre);
                    cmd.Parameters.AddWithValue("Apellido", obj.Apellido);
                    cmd.Parameters.AddWithValue("Rut", obj.Rut);
                    cmd.Parameters.AddWithValue("FechNa", obj.FechNa);
                    cmd.Parameters.AddWithValue("IdCom", obj.IdCom);
                    cmd.Parameters.AddWithValue("Correo", obj.Correo);
                    cmd.Parameters.AddWithValue("Direccion", obj.Direccion);
                    
                    cmd.Parameters.AddWithValue("Tel", obj.Tel);
                    cmd.Parameters.AddWithValue("Contratacion", obj.Contratacion);
                    cmd.Parameters.AddWithValue("Cargo", obj.Cargo);
                    cmd.Parameters.AddWithValue("VaHo", obj.VaHo);
                    cmd.Parameters.AddWithValue("VaHoEx", obj.VaHoEx);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;

                    // Especifica que el comando es un procedimiento almacenado
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Abre la conexión y ejecuta el comando
                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    // Obtiene los valores de salida
                    Resultado = Convert.ToInt32(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                Resultado = 0;
                Mensaje = ex.Message;
            }
            return Resultado;
        }

        public bool Actualizar(EEmpleado obj, out string Mensaje)//Funcion que actualiza a un cliente en la base de datos 
        {
            bool Resultado = false;
            Mensaje = string.Empty;
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.Conex))
                {
                    // Agregar los parámetros
                    SqlCommand cmd = new SqlCommand("Act_Trabajador", oconexion);
                    cmd.Parameters.AddWithValue("IdTra", obj.IdTra);
                    cmd.Parameters.AddWithValue("Nombre", obj.Nombre);
                    cmd.Parameters.AddWithValue("Apellido", obj.Apellido);
                    cmd.Parameters.AddWithValue("Rut", obj.Rut);
                    cmd.Parameters.AddWithValue("FechNa", obj.FechNa);
                    cmd.Parameters.AddWithValue("IdCom", obj.IdCom);
                    cmd.Parameters.AddWithValue("Correo", obj.Correo);
                    cmd.Parameters.AddWithValue("Direccion", obj.Direccion);
                    cmd.Parameters.AddWithValue("Tel", obj.Tel);
                    cmd.Parameters.AddWithValue("Contratacion", obj.Contratacion);
                    cmd.Parameters.AddWithValue("Cargo", obj.Cargo);
                    cmd.Parameters.AddWithValue("VaHo", obj.VaHo);
                    cmd.Parameters.AddWithValue("VaHoEx", obj.VaHoEx);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();
                    cmd.ExecuteNonQuery();
                    Resultado = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                Resultado = false;
                Mensaje = ex.Message;
            }
            return Resultado;
        }
        public bool Eliminar(EEmpleado obj, out string Mensaje)
        {
            bool Resultado = false;
            Mensaje = string.Empty;
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.Conex))
                {
                    SqlCommand cmd = new SqlCommand("Eli_Trabajador", oconexion);
                    cmd.Parameters.AddWithValue("IdTra", obj.IdTra);
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                    Resultado = true; // Asume que la eliminación fue exitosa
                }
            }
            catch (Exception ex)
            {
                Resultado = false;
                Mensaje = ex.Message;
            }
            return Resultado;
        }

    }
}
