using Parcial.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Negocio
{
    class ClsVenta
    {
        public String Cobro(Venta cobro)
        {
            cobro.Total = (cobro.Preciodeproducto * cobro.Cantidadproducto);
            
            if(cobro.Total > 50 )
            {
                cobro.Descuento = cobro.Total - (cobro.Total * 0.20);
                return ("el total a pagar con descuento es: " + cobro.Descuento);
               
            }
            else
            {
                return ("No se aplico ningun descuento." + cobro.Total);
            }
            
           
          


        }
        
    }
}
