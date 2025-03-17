using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class ELogin
    {
        public int ValIdUsu;

        public String ValNombre;

        public String ValPass;

        public int IdUsu
        {
            get { return ValIdUsu; }
            set { ValIdUsu = value; }
        }

        public String Nombre
        {
            get { return ValNombre; }
            set { ValNombre = value; }
        }

        public String Pass
        {
            get { return ValPass; }
            set { ValPass = value; }
        }
    }
}