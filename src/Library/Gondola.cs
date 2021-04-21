using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Library
{
    public class Gondola
    {
        private string nombreGondola;

        public string NombreGondola
        {
            get
            {
                return nombreGondola;
            }
        }

        private List<Producto> estanteria;

        private ReadOnlyCollection<Producto> roEstanteria;

        public IList<Producto> Estanteria
        {
            get 
            {
                roEstanteria = estanteria.AsReadOnly();
                return roEstanteria;                
            }
        }

        public Gondola(string nombreGondola)
        {
            this.nombreGondola = nombreGondola;
            this.estanteria = new List<Producto>();
        }

        public void AgregarProducto(Producto producto)
        {
            estanteria.Add(producto);
            Console.WriteLine("Se ha AGREGADO el producto: " + producto.Nombre +" a la estantería de la "+ this.nombreGondola);
        }

        public void QuitarProducto(Producto producto)
        {
            estanteria.Remove(producto);
            Console.WriteLine("Se ha REMOVIDO el producto: " + producto.Nombre +" de la estantería de la " + this.nombreGondola);
        }
    }
}
