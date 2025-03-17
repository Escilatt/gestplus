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
   public class DLocCom
    {
        public Conexion Cn = new Conexion();   //LLama a la clase, creando una variable con un nuevo nombre

        public static DLocCom _instancia = null;

        public static DLocCom Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new DLocCom();
                }
                return _instancia;
            }
        }
        public List<ELocCom> Listar()
        {
            List<ELocCom> Lis = new List<ELocCom>();   //Se llama lista de variables de la Entidad llamada (Tamaño, Tipo)
            using (SqlConnection oConexion = new SqlConnection(Conexion.Conex))   //Usa la clase de conexion, crea una variable de nuevo nombre a la clase llamada
            {
                SqlCommand cmd = new SqlCommand("Bus_LCom", oConexion);  //LLama al procedimiento almacenado
                cmd.CommandType = CommandType.StoredProcedure;   //Establece un valor igual al nombre de un procedimiento almacenado
                try
                {
                    oConexion.Open();  //Abre la conexion a una base de datos
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())  //Realiza un bucle while, donde lee la variable si hay filas, si no, devuelve con un false
                    {
                        Lis.Add(new ELocCom()  //Agrega variables de Entidad con la clase llamada
                        {
                            IdCom = Convert.ToInt32(dr["IdCom"].ToString()),   //Se convierte en valor entero, devuelve una cadena que representa el objeto actual
                            Nombre = dr["Nombre"].ToString(),   //La variable devuelve una cadena que representa el objeto actual
                            IdPro = Convert.ToInt32(dr["IdPro"].ToString()),    //Se convierte en valor entero, devuelve una cadena que representa el objeto actual
                            Pro = new ELocPro() { Nombre = dr["NombreProvincia"].ToString() },   //se crea nueva instancia , donde devuelve una cadena que representa el objeto actual
                            IdReg = Convert.ToInt32(dr["IdPro"].ToString()),    //Se convierte en valor entero, devuelve una cadena que representa el objeto actual
                            Reg = new ELocReg() { Nombre = dr["NombreRegion"].ToString() },  //se crea nueva instancia , donde devuelve una cadena que representa el objeto actual
                        });
                    }
                    dr.Close();  //Cierra la variable
                    return Lis;   //Devolver filas de la tabla
                }
                catch (Exception)   //Excepción de las intrucciones dadas
                {
                    Lis = null;  //La variable es igual a nulo
                    return Lis;   //Devolver filas de la tabla
                }
            }
        }

        public DataTable Filtrar(int IdCom)
        {
            DataTable dt = new DataTable();  //Se crea una variable que representa una tabla de datos, inicializando una nueva instancia
            List<Parametro> parametros = new List<Parametro>();  //Se llama lista de variables de la clase llamada (Tamaño, Tipo)
            try
            {
                parametros.Add(new Parametro("@Id", IdCom));
                using (SqlConnection conexion = new SqlConnection(Conexion.Conex))   //Usa la clase de conexion, crea una variable de nuevo
                {
                    SqlCommand cmd = new SqlCommand("Fil_Id_LCom", conexion);  //LLama al procedimiento almacenado
                    cmd.CommandType = CommandType.StoredProcedure;   //Establece un valor igual al nombre de un procedimiento almacenado
                    foreach (var parametro in parametros)
                    {
                        cmd.Parameters.AddWithValue(parametro.Nombre, parametro.Valor);   //Devuelve parametros del procedimiento almacenado, agregandole valor a las variables asignadas
                    }
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))   //Usa un comando de datos para rellenar un DataSet y actualizar una base de datos SQL
                    {
                        da.Fill(dt);  //Agrega o actualiza filas en el DataSet
                    }
                }
                return dt;  //Devuleve la variable
            }
            catch (Exception ex)  //Excepción de las intrucciones dadas
            {
                throw ex; //Devuelve un error 
            }
        }
    }
}
