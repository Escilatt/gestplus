using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class ELocPro
    {
        public int ValIdPro;  //Crea una variable de valor entero

        public String ValNombre;  //Crea una variable de valor String

        public int ValIdReg;   //Crea una variable de valor entero

        public ELocReg ValReg;  //Crea una variable de la clase

        public int IdPro         // Declaración de variable de tipo Entero
        {
            get { return ValIdPro; }       // Navegación por la variable
            set { ValIdPro = value; }      // Navegación por la variable
        }

        public String Nombre     // Declaración de variable de tipo String
        {
            get { return ValNombre; }       // Navegación por la variable
            set { ValNombre = value; }     // Navegación por la variable
        }

        public int IdReg           // Declaración de variable de tipo Entero
        {
            get { return ValIdReg; }        // Navegación por la variable
            set { ValIdReg = value; }       // Navegación por la variable
        }
        public ELocReg Reg  // Declaración de variable de la clase
        {
            get { return ValReg; }  // Navegación por la variable
            set { ValReg = value; }  // Navegación por la variable
        }
    }
}
