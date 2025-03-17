using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class ELocReg
    {
        public int ValIdReg;  //Crea una variable de valor entero

        public String ValNombre;  //Crea una variable de valor String

        public int IdReg                  // Declaración de variable de tipo Entero
        {
            get { return ValIdReg; }       // Navegación por la variable
            set { ValIdReg = value; }      // Navegación por la variable
        }
        public String Nombre                // Declaración de variable de tipo String
        {
            get { return ValNombre; }          // Navegación por la variable
            set { ValNombre = value; }         // Navegación por la variable
        }
    }
}

