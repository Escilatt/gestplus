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
    public class DVentas
    {
        private Conexion Cn = new Conexion();

        public static DVentas _instancia = null;

        public static DVentas Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new DVentas();
                }
                return _instancia;
            }


        }

        public List<EVentas> Listar()
        {
            List<EVentas> Lis = new List<EVentas>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.Conex))
            {
                SqlCommand cmd = new SqlCommand("Bus_Ventas", oConexion);

                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    oConexion.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    {
                        while (dr.Read())
                        {
                            Lis.Add(new EVentas()
                            {
                                IdVenta = Convert.ToInt32(dr["IdVenta"].ToString()),
                                Nombre = dr["Nombre"].ToString(),
                                CantidadVenta = dr["CantidadVenta"].ToString(),
                                TotalVenta = dr["TotalVenta"].ToString(),
                                PrecioProducto = dr["PrecioProducto"].ToString(),
                                precio_compra = dr["precio_compra"].ToString(),
                                PrecioTotCom = dr["PrecioTotCom"].ToString()

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


        public int Ingresar(EVentas obj, out string Mensaje)
        {
            int Resultado = 0;
            Mensaje = string.Empty;
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.Conex))
                {
                    // Asociar la conexión al comando
                    SqlCommand cmd = new SqlCommand("Ing_Ventas", oconexion);

                    // Agregar los parámetros
                    cmd.Parameters.AddWithValue("Nombre", obj.Nombre);
                    cmd.Parameters.AddWithValue("CantidadVenta", obj.CantidadVenta);
                    cmd.Parameters.AddWithValue("Totalventa", obj.TotalVenta);
                    cmd.Parameters.AddWithValue("PrecioProducto", obj.PrecioProducto);
                    cmd.Parameters.AddWithValue("precio_compra", obj.precio_compra);
                    cmd.Parameters.AddWithValue("PrecioTotCom", obj.PrecioTotCom);
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
    }
}
