using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DLogin
    {
        private Conexion Cn = new Conexion();

        public static DLogin _instancia = null;

        public static DLogin Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new DLogin();
                }
                return _instancia;
            }
        }
        public int IngSig(string Nombre, string Pass, out string Mensaje)
        {
            int Respuesta = 0;
            Mensaje = "";

            using (SqlConnection connection = new SqlConnection(Conexion.Conex))
            {
                try
                {
                    SqlCommand command = new SqlCommand("IngSig", connection);
                    command.Parameters.AddWithValue("Nombre", Nombre);
                    command.Parameters.AddWithValue("Pass", Pass);
                    command.Parameters.Add("IdUsu", SqlDbType.Int).Direction = ParameterDirection.Output;
                    command.Parameters.Add("Mensaje", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;
                    command.CommandType = CommandType.StoredProcedure;

                    connection.Open();

                    command.ExecuteNonQuery();

                    command.ExecuteNonQuery();

                    command.ExecuteNonQuery();

                    Respuesta = Convert.ToInt32(command.Parameters["IdUsu"].Value);
                    Mensaje = command.Parameters["Mensaje"].Value.ToString();
                }
                catch (Exception)
                {
                    Respuesta = 0;
                }
            }
            return Respuesta;
        }
    }
}
