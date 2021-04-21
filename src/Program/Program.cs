using System;
using Library;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {   
            Gondola gondola1 = new Gondola("Góndola de alimentos");
            Gondola gondola2 = new Gondola("Góndola de limpieza");
            Gondola gondola3 = new Gondola("Góndola de higiene personal");
            
            Producto arroz = new Producto(5514468, "Arroz Samán", 90);
            Producto jabon = new Producto(4496858, "Jabón Dove", 100);
            Producto escoba = new Producto(852015, "Escoba Alonso & Mariños", 250);
            Producto pastaDental = new Producto(452037, "Pasta de dientes Colgate", 150);

            gondola1.AgregarProducto(arroz);        
            gondola1.AgregarProducto(escoba);
            gondola1.QuitarProducto(escoba);

            gondola2.AgregarProducto(escoba);
            gondola2.AgregarProducto(jabon);

            gondola3.AgregarProducto(pastaDental);
        }
    }
}
