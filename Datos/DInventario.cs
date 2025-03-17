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
    public class DInventario
    {
        private Conexion Cn = new Conexion();

        public static DInventario _instancia = null;

        public static DInventario Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new DInventario();
                }
                return _instancia;
            }


        }
        public List<EInventario> Listar()
        {
            List<EInventario> Lis = new List<EInventario>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.Conex))
            {
                SqlCommand cmd = new SqlCommand("Bus_Producto", oConexion);

                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    oConexion.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    {
                        while (dr.Read())
                        {
                            Lis.Add(new EInventario()
                            {
                                IdProducto = Convert.ToInt32(dr["IdProducto"].ToString()),
                                Nombre = dr["Nombre"].ToString(),
                                FechaIngreso = dr["FechaIngreso"].ToString(),
                                ValorPorUnidad = dr["ValorPorUnidad"].ToString(),
                                ValorTotal = dr["ValorTotal"].ToString(),
                                Cantidad = dr["Cantidad"].ToString()
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
        public int Ingresar(EInventario obj, out string Mensaje)
        {
            int Resultado = 0;
            Mensaje = string.Empty;
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.Conex))
                {
                    // Asociar la conexión al comando
                    SqlCommand cmd = new SqlCommand("Ing_Producto", oconexion);

                    // Agregar los parámetros
                    cmd.Parameters.AddWithValue("Nombre", obj.Nombre);
                    cmd.Parameters.AddWithValue("FechaIngreso", obj.FechaIngreso);
                    cmd.Parameters.AddWithValue("ValorPorUnidad", obj.ValorPorUnidad);
                    cmd.Parameters.AddWithValue("ValorTotal", obj.ValorTotal);
                    cmd.Parameters.AddWithValue("Cantidad", obj.Cantidad);
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
        public bool Actualizar(EInventario obj, out string Mensaje)//Funcion que actualiza a un cliente en la base de datos 
        {
            bool Resultado = false;
            Mensaje = string.Empty;
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.Conex))
                {
                    // Agregar los parámetros
                    SqlCommand cmd = new SqlCommand("Act_Producto", oconexion);
                    cmd.Parameters.AddWithValue("IdProducto", obj.IdProducto);
                    cmd.Parameters.AddWithValue("Nombre", obj.Nombre);
                    cmd.Parameters.AddWithValue("FechaIngreso", obj.FechaIngreso);
                    cmd.Parameters.AddWithValue("ValorPorUnidad", obj.ValorPorUnidad);
                    cmd.Parameters.AddWithValue("ValorTotal", obj.ValorTotal);
                    cmd.Parameters.AddWithValue("Cantidad", obj.Cantidad);
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
        public bool Eliminar(EInventario obj, out string Mensaje)
        {
            bool Resultado = false;
            Mensaje = string.Empty;
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.Conex))
                {
                    SqlCommand cmd = new SqlCommand("Producto_Eli", oconexion);
                    cmd.Parameters.AddWithValue("IdProducto", obj.IdProducto);
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
