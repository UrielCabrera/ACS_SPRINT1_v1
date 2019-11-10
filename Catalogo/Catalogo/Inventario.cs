using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catalogo
{
    class Inventario
    {
        private ArrayList productos;
        private ArrayList imagenes;
        public Inventario()
        {
            productos = new ArrayList();
            imagenes = new ArrayList();
        }
        public void AgregarProducto(Producto articulo)
        {
            productos.Add(articulo); 
 
        }

        public void AgregarImagen(PictureBox pictureBox) {
            imagenes.Add(pictureBox);
        }

        public ArrayList Productos
        {
            get { return productos; }
        }

        public ArrayList Imagenes {
            get { return imagenes; }
        }

        public Producto GetProducto(int indice) 
        { 
            return (Producto)productos[indice]; 
        }

        public PictureBox GetImagen(int indice) {
            return (PictureBox)imagenes[indice];
        }

    }
}
