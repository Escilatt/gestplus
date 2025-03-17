using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class EVentas
    {
        public int ValIdVenta;

        public String ValNombre;

        public String ValCantidadVenta;

        public String ValTotalVenta;

        public String ValPrecioProducto;

        public String Valprecio_compra;

        public String ValPrecioTotCom;


        public int IdVenta
        {
            get { return ValIdVenta; }
            set { ValIdVenta = value; }
        }

        public String Nombre
        {
            get { return ValNombre; }
            set { ValNombre = value; }
        }

        public String CantidadVenta
        {
            get { return ValCantidadVenta; }
            set { ValCantidadVenta = value; }
        }

        public String TotalVenta
        {
            get { return ValTotalVenta; }
            set { ValTotalVenta = value; }
        }

        public String PrecioProducto
        {
            get { return ValPrecioProducto; }
            set { ValPrecioProducto = value; }
        }

        public String precio_compra
        {
            get { return Valprecio_compra; }
            set { Valprecio_compra = value; }
        }

        public String PrecioTotCom
        {
            get { return ValPrecioTotCom; }
            set { ValPrecioTotCom = value; }
        }
    }
}
