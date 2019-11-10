using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo
{
    class Descripcion
    {
        private string nombre;
        private double precio;
        private string material;
        private int categoria;

        public Descripcion(string nombre, double precio, int categoria, string material)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.categoria = categoria;
            this.material = material;
        }

        public string Nombre
        {
            get { return nombre; } 
        }

        public double Precio 
        {
            get { return precio; } 
        }

        public string GetMaterial() 
        { 
            return material; 
        }

        public string Categoria
        {
            get
            {
                if (categoria == 1) { return "Dama"; }
                if (categoria == 2) { return "Caballero"; }
                if (categoria == 3) { return "Niña"; }
                if (categoria == 4) { return "Niño"; }
                if (categoria == 5) { return "Decoracion"; }
                if (categoria == 6) { return "Otro"; }
                return null;
            }
        }
        public override string ToString()
        {
            string cadena = "";
            cadena = "Nombre:" + nombre + "\nCategoria:" + Categoria + "\n Precio:" + precio + " $" + "\n Material:" + material + "\n";
            return cadena;
        }

        public string GetNombrePrecio()
        {
            string nombrePrecio = nombre + "\nPrecio:" + precio + " $";
            return nombrePrecio;
        }

    }
}
