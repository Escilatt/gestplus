using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUI.DataModel
{
    [Table("Productos")]
    public class Productos
    {

        [Key]
        public int IdProducto { get; set; }
        public string Nombre { get; set; }

        public string FechaIngreso { get; set; }

        public string ValorPorUnidad { get; set; }

        public string ValorTotal { get; set; }

        public string Cantidad { get; set; }

    }

    [Table("Trabajador")]
    public class Trabajador
    {
        [Key]
        public int IdTra { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Rut { get; set; }
        public string Direccion { get; set; }
        public int IdCom { get; set; }
        public string NombreComuna { get; set; }  // Nuevo campo para el nombre de la comuna
        public string FechNa { get; set; }
        public string Correo { get; set; }
        public string Tel { get; set; }
        public string Contratacion { get; set; }
        public string Cargo { get; set; }
        public string VaHo { get; set; }
        public string VaHoEx { get; set; }
    }



    [Table("Comuna")]
    public class Comuna
    {

        [Key]
        public int IdCom { get; set; }
        public string Nombre { get; set; }
        public int IdPro { get; set; }

    }

    [Table("Provincia")]
    public class Provincia
    {

        [Key]
        public int IdPro { get; set; }
        public string Nombre { get; set; }
        public int IdReg { get; set; }

    }

    [Table("Region")]
    public class Region
    {

        [Key]
        public int IdReg { get; set; }
        public string Nombre { get; set; }

    }

    [Table("Ventas")]
    public class Ventas
    {

        [Key]
        public int IdVenta { get; set; }
        public string Nombre { get; set; }

        public string CantidadVenta { get; set; }

        public string TotalVenta { get; set; }

        public string PrecioProducto { get; set; }

        public string precio_compra { get; set; }

        public string PrecioTotCom { get; set; }



    }





}
