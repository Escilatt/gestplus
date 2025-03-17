using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Entidad
{
    public class EEmpleado
    {
        public int ValIdTra;

        public String ValNombre;

        public String ValApellido;

        public String ValFechNa;

        public int ValIdReg;

        public ELocReg ValReg;

        public int ValIdPro;

        public ELocPro ValPro;

        public int ValIdCom;

        public ELocCom ValCom;

        public String ValRut;

        public String ValContratacion;

        public String ValCorreo;

        public String ValCargo;

        public String ValDireccion;

        public String ValTel;

        public String ValVaHo;

        public String ValVaHoEx;


        public int IdTra
        {
            get { return ValIdTra; }
            set { ValIdTra = value; }
        }

        public String Nombre
        {
            get { return ValNombre; }
            set { ValNombre = value; }
        }
        public String Apellido
        {
            get { return ValApellido; }
            set { ValApellido = value; }
        }
        public String FechNa
        {
            get { return ValFechNa; }
            set { ValFechNa = value; }
        }
        public int IdReg
        {
            get { return ValIdReg; }
            set { ValIdReg = value; }
        }
        public ELocReg Reg
        {
            get { return ValReg; }
            set { ValReg = value; }
        }
        public int IdPro
        {
            get { return ValIdPro; }
            set { ValIdPro = value; }
        }

        public ELocPro Pro
        {
            get { return ValPro; }
            set { ValPro = value; }
        }

        public int IdCom
        {
            get { return ValIdCom; }
            set { ValIdCom = value; }
        }

        public ELocCom Com 
        {
            get { return ValCom; }
            set { ValCom = value; }
        }
        public String Contratacion
        {
            get { return ValContratacion; }
            set { ValContratacion = value; }
        }
        public String Cargo
        {
            get { return ValCargo; }
            set { ValCargo = value; }
        }
        public String Rut
        {
            get { return ValRut; }
            set { ValRut = value; }
        }

        public String Direccion
        {
            get { return ValDireccion; }
            set { ValDireccion = value; }
        }
        public String Correo
        {
            get { return ValCorreo; }
            set { ValCorreo = value; }
        }
        public String Tel
        {
            get { return ValTel; }
            set { ValTel = value; }
        }


        public String VaHo
        {
            get { return ValVaHo; }
            set { ValVaHo = value; }
        }

        public String VaHoEx
        {
            get { return ValVaHoEx; }
            set { ValVaHoEx = value; }
        }
    }
}
