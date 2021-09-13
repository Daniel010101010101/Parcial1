using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Entidades
{
    class Venta
    {
        private int identificadorproducto;
        private string nombreproducto;
        private string descripciónproducto;
        private double preciodeproducto;
        private int cantidadproducto;
        private double total;
        private double descuento;
        

       

        public int Identificadorproducto { get => identificadorproducto; set => identificadorproducto = value; }
        public string Nombreproducto { get => nombreproducto; set => nombreproducto = value; }
        public string Descripciónproducto { get => descripciónproducto; set => descripciónproducto = value; }
        public double Preciodeproducto { get => preciodeproducto; set => preciodeproducto = value; }
        public int Cantidadproducto { get => cantidadproducto; set => cantidadproducto = value; }
        public double Total { get => total; set => total = value; }
        public double Descuento { get => descuento; set => descuento = value; }

        public override string ToString()
        {
            return "Identificador del producto: " + Identificadorproducto +
                "\nNombre del producto: " + nombreproducto +
                "\nDescripción del producto: " + descripciónproducto +
                "\nPrecio del Producto:  " + preciodeproducto +
                "\nCantidad del Producto: " + cantidadproducto;
        }
    }
}
