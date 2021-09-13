using Parcial.Entidades;
using Parcial.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario();
            Console.WriteLine("Ingrese su nombre de usuario");
            usuario.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su contraseña");
            usuario.Contra = Convert.ToInt32(Console.ReadLine());
            ClsUsuariio clsUsuariio = new ClsUsuariio();
            Console.WriteLine(clsUsuariio.Acceso(usuario));
            
            while (usuario.Token == 1)
            {
                ;
                Venta venta = new Venta();
                ClsVenta clsVenta = new ClsVenta();
                Console.WriteLine("Ingrese el id del producto");
                venta.Identificadorproducto = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el nombre del producto");
                venta.Nombreproducto = Console.ReadLine();
                Console.WriteLine("Ingrese la descripción del producto");
                venta.Descripciónproducto = Console.ReadLine();
                Console.WriteLine("Ingrese el precio del producto");
                venta.Preciodeproducto = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese la cantidad de productos que llevara");
                venta.Cantidadproducto = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(clsVenta.Cobro(venta));
                Console.WriteLine(venta.ToString());

            }

            
               

            
        }
    }
}
