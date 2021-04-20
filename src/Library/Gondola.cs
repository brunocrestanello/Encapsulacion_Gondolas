using System;
using System.Collections.Generic;
using System.Collections.ObjectModel.ReadOnlyCollection;|

namespace Library
{
    public class Gondola
    {

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


        public Gondola()
        {
            this.estanteria = new List<Producto>();
        }

        

        public void AgregarProducto(Producto producto)
        {
            Estanteria.Add(producto);
        }

        public void QuitarProducto(Producto producto)
        {
            Estanteria.Remove(producto);
        }
    }
}
