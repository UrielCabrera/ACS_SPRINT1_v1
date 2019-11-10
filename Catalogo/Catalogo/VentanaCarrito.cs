using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace Catalogo
{
    public partial class VentanaCarrito : Form
    {
        private ControlVentas controlVentas1=new ControlVentas();
        private int indiceEliminar=0;
        public VentanaCarrito(){InitializeComponent();}
        private void Form3_Load(object sender, EventArgs e)
        {
            controlVentas1.CargarVentasDeArchivo();
            //Si no hay ningun producto en el carrito
            botonEliminar.Enabled = false;
            if ( controlVentas1.Carrito.NumeroArticulos <= 0)
            {
                botonRealizarCompra.Enabled = false;
                labelTotal.Text ="";

            }
            else {
                for (int h = 0; h < controlVentas1.Carrito.NumeroArticulos; h++)
                {
                    ListViewItem itemh = new ListViewItem("", h);
                    itemh.SubItems.Add(controlVentas1.Carrito.getVenta(h).Producto.Descripcion.Nombre);
                    itemh.SubItems.Add(Convert.ToString(controlVentas1.Carrito.getVenta(h).Producto.Descripcion.Precio) + " $");
                    itemh.SubItems.Add(Convert.ToString(controlVentas1.Carrito.getVenta(h).Piezas));
                    itemh.SubItems.Add(Convert.ToString(controlVentas1.Carrito.getVenta(h).SubTotal) + " $");

                    listViewCarrito.Items.AddRange(new ListViewItem[] { itemh });
                    imageList1.Images.Add(controlVentas1.Carrito.getVenta(h).Producto.Imagen);
                }
                listViewCarrito.SmallImageList = imageList1;
                labelTotal.Text = Convert.ToString(controlVentas1.Carrito.Total) + " $";
            }                  
        }


        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            SistemaVentas ventanaSistVentas = new SistemaVentas();
            ventanaSistVentas.AgregarProducto(controlVentas1.Carrito.Ventas);
            ventanaSistVentas.Show();
            this.Hide();
        }

        private void listViewCarrito_SelectedIndexChanged(object sender, EventArgs e){}


        //Elimina el item seleccionado de la lista de "listViewCarrito"
        private void botonEliminar_Click(object sender, EventArgs e)
        { 
            foreach (ListViewItem elemento in listViewCarrito.SelectedItems) 
            {
                indiceEliminar = listViewCarrito.Items.IndexOf(elemento);
                elemento.Remove();
            }
            controlVentas1.Carrito.EliminarVenta(indiceEliminar);
            labelTotal.Text= Convert.ToString(controlVentas1.Carrito.Total) + " $";
        }

        private void listViewCarrito_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            botonEliminar.Enabled = true;
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e) 
        { 
            this.Hide(); 
        }
    }
}
