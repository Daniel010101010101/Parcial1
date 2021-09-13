using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Entidades
{
    class Usuario
    {
         string nombre;
         int contra;
         int token;
        

    
        public string Nombre { get => nombre; set => nombre = value; }
        public int Contra { get => contra; set => contra = value; }
        public int Token { get => token; set => token = value; }
    }
}
