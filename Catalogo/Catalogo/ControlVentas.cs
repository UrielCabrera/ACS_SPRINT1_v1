using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catalogo
{
    public class ControlVentas
    {
        private Carrito carrito;
        private int[] ventasAux;
        private Inventario inventario;
        private string leerVentas;
        private string[] filas;
        private string[] renglones;
        public ControlVentas() {
            carrito = new Carrito();
            leerVentas = File.ReadAllText("Venta.txt");
        }

        //Carga las ventas al carrito
        internal void CargarVentasDeArchivo()
        {
            int idImagen;
            int numPiezas;
            int j = 0;
            string cadena4, cadena5, cadena6;
            string[] columnas;
            filas = leerVentas.Split(new string[] { System.Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            if (filas.Length == carrito.NumeroArticulos)
            {
                MessageBox.Show("filas == carrito.Ventas.Length:", " 1ER IF");
            }
            else
            {
                ventasAux = new int[filas.Length];
                if (carrito.NumeroArticulos == 0)
                {
                    MessageBox.Show("ventas.Count == 0", " 2DO IF");
                    foreach (string linea in filas)
                    {
                        columnas = linea.Split(',');
                        idImagen = Convert.ToInt32(columnas[0]);
                        numPiezas = Convert.ToInt32(columnas[1]);
                        carrito.AgregarVenta(new Venta(inventario.GetProducto(idImagen), numPiezas));

                        j = j + 1;
                    }
                }
                if (filas.Length > carrito.NumeroArticulos)
                {
                    MessageBox.Show("filas > ventas.Count == ", " 3ER IF");
                    renglones = new String[filas.Length - carrito.Ventas.Length];
                    int k = 0, p = carrito.Ventas.Length;
                    for (int m = carrito.Ventas.Length; m < filas.Length; m++)
                    {
                        renglones[k] = filas[m];
                        k++;
                    }
                    foreach (string linea in renglones)
                    {
                        columnas = linea.Split(',');
                        idImagen = Convert.ToInt32(columnas[0]);
                        numPiezas = Convert.ToInt32(columnas[1]);
                        carrito.AgregarVenta(new Venta(inventario.GetProducto(idImagen), numPiezas));

                        p = p + 1;
                    }
                }
            } //termina else      

        }
            
        internal Carrito Carrito {
            get { return carrito; }
        }

        


    }
}
