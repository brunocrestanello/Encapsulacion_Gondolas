using System;
using System.Collections.Generic;

namespace Library
{
    public class Producto
    {
        private int codigo;
        private string nombre;
        private int precio;

        public int Codigo
        {
            get
            {
                return codigo;
            }
            set
            {
                if(codigo is int)
                {
                    codigo = value;
                }
            }
        }
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                if(!String.IsNullOrEmpty(value))
                {
                    nombre = value;
                }
            }
        }
        public int Precio
        {
            get
            {
                return precio;
            }
            set
            {
                if(precio is int)
                {
                    precio = value;
                }
            }
        }

        public Producto(int codigo, string nombre, int precio)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.precio = precio;
        }
        
        
    }
}
