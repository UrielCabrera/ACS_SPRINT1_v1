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
    public class ControlInventario
    {
        private Inventario inventario;

        private string leerRegistros;
        private string leerImagenes;
        private string[] imagenes;
        private string[] registros;
        public ControlInventario()
        {
            inventario = new Inventario();

            leerRegistros = File.ReadAllText("Registro.txt");
            leerImagenes = File.ReadAllText("Imagenes.txt");
        }

        internal void CargarInventarioDeAlmacen(){
            string nombre;
            string material;
            double precio;
            int categoria;
            int exitencias;
            int id;
            registros = leerRegistros.Split(new string[] { System.Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            imagenes = leerImagenes.Split(new string[] { System.Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            string[] columnas;

            foreach (string fila in registros)
            {
                columnas = fila.Split(',');                
                nombre = columnas[0];
                precio = Convert.ToDouble(columnas[1]);
                categoria = Convert.ToInt32(columnas[2]);
                material = columnas[3];
                exitencias = Convert.ToInt32(columnas[4]);
                id = Convert.ToInt32(columnas[5]);

                inventario.AgregarProducto(new Producto(nombre, precio, categoria, material, exitencias, id)); 
            }
            int i = 0;
            if (imagenes.Length==18) {
                MessageBox.Show("imagenes.length==18");
                foreach (string linea in imagenes) {
                    inventario.GetProducto(i).SetImagen(linea);
                    i++;
                }
            }

        }

        internal Inventario Inventario 
        {
            get { return inventario; } 
        }

    }
}

