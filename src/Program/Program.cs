using System;
using Library;
using System.Collections.Generic;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {   
            List<Producto> Estanteria = new List<Producto>();
            Producto arroz = new Producto(5514468, "Saman", 90);
            Producto jabon = new Producto(4496858, "Dove", 100);
            Producto escoba = new Producto(852015, "Brujita", 250);

            Estanteria.Add(arroz);
        

        }
    }
}
