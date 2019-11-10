using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catalogo
{
    class Carrito
    {
        private ArrayList ventas;
        private double total;
        private int numeroArticulos;

        public Carrito()
        {
            ventas = new ArrayList();
            total = 0;
            numeroArticulos = 0;
        }

        public double Total
        {
            get { return total; } 
        }

        public int NumeroArticulos {
            get { return numeroArticulos; }       
        }

        internal void AgregarVenta(Venta venta)
        {
            ventas.Add(venta);
            total = total + venta.SubTotal;
            numeroArticulos = numeroArticulos + 1;
        }

        /*Elimina una venta de la lista de ventas*/
        internal void EliminarVenta(int indice) 
        {
            total = total - ((Venta)ventas[indice]).SubTotal;
            numeroArticulos = numeroArticulos - 1;
            ventas.RemoveAt(indice);
        }

        internal Venta getVenta(int indice)
        {
            //MessageBox.Show("indice getVenta:"+indice);
            return (Venta)ventas[indice]; 
        }
        
        public Venta[] Ventas{
            get
            {
                Venta[] listaVentas = new Venta[ventas.Count];
                for (int i = 0; i < ventas.Count; i++)
                {
                    listaVentas[i] = (Venta)ventas[i];
                }

                return listaVentas;

            }
        }
    }
}
