using Parcial.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Negocio
{
    class ClsUsuariio
    {

        public String Acceso(Usuario acceso)
        {
            if (acceso.Nombre == "Daniel" && acceso.Contra == 123)
            {
                acceso.Token = 1;
                return ("INICIO DE  SESIÓN CORRECTO PUEDES CONTINUAR CON EL PROCESO DE VENTA" );
            }
            else
            {
                acceso.Token = 2;
                return ("SU USUARIO Y CONTRASEÑA NO SON CORRECTOS");
            }
            
        
        }
    }
}
