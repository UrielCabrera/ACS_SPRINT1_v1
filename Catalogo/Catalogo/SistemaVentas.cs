using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catalogo
{
    public partial class SistemaVentas : Form
    {
        private Venta[] ventasForm3;
        Conversion convertir = new Conversion(); //creo un nuevo objeto para convertir de numeros a letras

        public SistemaVentas()
        {
            InitializeComponent();
        }
        string[,] ListaVenta = new string[200,6];
        int fila;
        //-------------------------------------------------------------------------------------------------------------

        internal void AgregarProducto(Venta[] ventasData)
        {
            ventasForm3 = ventasData;
        }
        //............funcion que calculara el costo a pagar...............
        public void CostoPagar()
        {
            double descuento, total;
            double CostoFinal=0,CostoTotal = 0;
            int count = 0;
            
            count = dgvLista.RowCount;
            for(int i =0; i < count; i++)
            {
                CostoTotal = double.Parse(dgvLista.Rows[i].Cells[4].Value.ToString());
                CostoFinal = CostoFinal + CostoTotal;
            }
            lblTotal.Text = CostoFinal.ToString();//muestra el subtotal de la venta 
            //------hacemos el descuento sobre el subtotal 
            descuento = (double.Parse(lblTotal.Text) * 0.10);
            lblDescuento.Text = descuento.ToString();
            total = double.Parse(lblTotal.Text) - descuento;
             lblTot.Text = total.ToString();
            // -----mostramos la el total en letra----
            txtCantVendida.Text = convertir.enletras(lblTot.Text);
        }
//-------------------------------------Fuencion que recibe el pago -------------------------------------------------------------------------------------------------
        private void txtPagoEfectivo_TextChanged(object sender, EventArgs e)
        {
         
          double descuento,total;
            double cambio = 0.00;
            try
            {

                descuento = (double.Parse(lblTotal.Text) * 0.10);
                total = double.Parse(lblTotal.Text) - descuento;
                cambio = (double.Parse(txtPagoEfectivo.Text) - total);
                if (txtPagoEfectivo.Text=="" || double.Parse(txtPagoEfectivo.Text) <= 0.00)
                {
                    lblCambio.Text = "0.00";
                }
                else
                {
                    lblCambio.Text = cambio.ToString();
                   
                    
                }
            }
            catch
            {
                lblCambio.Text = "0.00";
            }
        }




        //-------------------------------------Boton que realiza el ticket de compra ---------------------------------------------------------------------------------------------
        private void btnRealizarCompra_Click_1(object sender, EventArgs e)
        {
            double descuento, total;
            descuento = (double.Parse(lblTotal.Text) * 0.10);
            total = double.Parse(lblTotal.Text) - descuento;
            
            if ((double.Parse(txtPagoEfectivo.Text) < total) || txtPagoEfectivo.Text =="")
            {
                MessageBox.Show(" Pago NO Valido !!\n Ingrese una Cantidad Mayor o Igual al Pago Requerido ");
                txtPagoEfectivo.Text = "";
            }
            else
            {


                clsFuncion.CreaTicket Ticket1 = new clsFuncion.CreaTicket();


                Ticket1.TextoCentro("         Plumas America  "); //imprime una linea de descripcion
                Ticket1.TextoCentro("**********************************");
                Ticket1.TextoIzquierda("");
                Ticket1.TextoCentro("Ticket de Compra "); //imprime una linea de descripcion
                Ticket1.TextoIzquierda("No Ticket: 10216");
                Ticket1.TextoIzquierda("Fecha:" + DateTime.Now.ToShortDateString() + " Hora:" + DateTime.Now.ToShortTimeString());
                Ticket1.TextoIzquierda("");
                clsFuncion.CreaTicket.LineasGuion();

                clsFuncion.CreaTicket.EncabezadoVenta();
                clsFuncion.CreaTicket.LineasGuion();
                foreach (DataGridViewRow r in dgvLista.Rows)
                { //                        Nombre del articulo                Precio                                   Cantidad                                SubTotal 


                    Ticket1.AgregaArticulo(r.Cells[1].Value.ToString(), double.Parse(r.Cells[2].Value.ToString()), int.Parse(r.Cells[3].Value.ToString()), double.Parse(r.Cells[4].Value.ToString())); //imprime una linea de descripcion
                }

                clsFuncion.CreaTicket.LineasGuion();
                Ticket1.AgregaTotales("Sub_Total", double.Parse(lblTotal.Text)); // imprime linea con total

                Ticket1.AgregaTotales("Descuento(10%):", descuento); // imprime linea con total
                Ticket1.AgregaTotales("I.V.A", double.Parse("0")); // imprime linea con total
                Ticket1.TextoIzquierda(" ");
                Ticket1.AgregaTotales("TOTAL", total); // imprime linea con total
                Ticket1.TextoIzquierda(" ");
                Ticket1.AgregaTotales("METODO PAGO (EFECTIVO):", double.Parse(txtPagoEfectivo.Text));
                Ticket1.TextoCentro(txtCantVendida.Text.ToString() + "MXN");
                Ticket1.AgregaTotales("Dvolucion:", double.Parse(lblCambio.Text));


                Ticket1.TextoIzquierda(" ");
                Ticket1.TextoCentro("**********************************");
                Ticket1.TextoCentro("*   Gracias por Comprar en  Productos America    *");

                Ticket1.TextoCentro("**********************************");
                Ticket1.TextoIzquierda(" ");
                string impresora = "Microsoft XPS Document Writer"; //mpueden usar variable
                Ticket1.ImprimirTiket(impresora);

            }
        }
//------------------------------------------Boton que realiza la Factura -----------------------------------------------------------------------------------
        private void btnFactura_Click(object sender, EventArgs e)
        {
           
            clsFuncion.CreaTicket Ticket1 = new clsFuncion.CreaTicket();
            double descuento, total;
            if (txtAtiende.Text == "" || txtCantVendida.Text == "" || txtCliente.Text == "")
            {
                MessageBox.Show("Error..!! Faltan Campos Por Llenar ");
            }
            else
            {


                Ticket1.TextoCentro(" Plumas America  "); //imprime una linea de descripcion
                Ticket1.TextoCentro("**********************************");

                Ticket1.TextoIzquierda("Direccion: UACM Plantel San Lorenzo Tezonco");
                Ticket1.TextoIzquierda("Tel: 55-UACM-31-61");
                Ticket1.TextoIzquierda("");
                Ticket1.TextoCentro(" Factura  de Compra "); //imprime una linea de descripcion
                Ticket1.TextoIzquierda("No Factura: FA10216");
                Ticket1.TextoIzquierda("Fecha:" + DateTime.Now.ToShortDateString() + " Hora:" + DateTime.Now.ToShortTimeString());
                Ticket1.TextoIzquierda("Gerente:" + txtAtiende.Text.ToString());///////////////////////////////////
                Ticket1.TextoIzquierda("RFC:" + txtRFC.Text.ToString());
                Ticket1.TextoIzquierda("Nombre:" + txtCliente.Text.ToString());
                Ticket1.TextoIzquierda("Direccion:" + txtDireccion.Text.ToString());
                Ticket1.TextoIzquierda("");
                clsFuncion.CreaTicket.LineasGuion();

                clsFuncion.CreaTicket.EncabezadoVenta();
                clsFuncion.CreaTicket.LineasGuion();
                foreach (DataGridViewRow r in dgvLista.Rows)
                { //                        Nombre del articulo                Precio                                   Cantidad                                SubTotal 


                    Ticket1.AgregaArticulo(r.Cells[1].Value.ToString(), double.Parse(r.Cells[2].Value.ToString()), int.Parse(r.Cells[3].Value.ToString()), double.Parse(r.Cells[4].Value.ToString())); //imprime una linea de descripcion
                }
 

                clsFuncion.CreaTicket.LineasGuion();
                Ticket1.AgregaTotales("Sub_Total", double.Parse(lblTotal.Text)); // imprime linea con total
                descuento = (double.Parse(lblTotal.Text) * 0.10);
                total = double.Parse(lblTotal.Text) - descuento;
                Ticket1.AgregaTotales("Descuento(10%):", descuento); // imprime linea con total
                Ticket1.AgregaTotales("I.V.A", double.Parse("0")); // imprime linea con total
                Ticket1.TextoIzquierda(" ");
                Ticket1.AgregaTotales("TOTAL", total); // imprime linea con total
                Ticket1.TextoIzquierda(" ");
                Ticket1.AgregaTotales("METODO PAGO (EFECTIVO):", double.Parse(txtPagoEfectivo.Text));
                Ticket1.TextoCentro(txtCantVendida.Text.ToString() + "MXN");
                Ticket1.AgregaTotales("Devolucion:", double.Parse(lblCambio.Text));


                Ticket1.TextoIzquierda(" ");
                Ticket1.TextoCentro("**********************************");
                Ticket1.TextoCentro("*   Gracias Por Su preferencia    *");

                Ticket1.TextoCentro("**********************************");
                Ticket1.TextoIzquierda(" ");
                string impresora = "Microsoft XPS Document Writer"; //mpueden usar variable
                Ticket1.ImprimirTiket(impresora);


                //este es para limpiar el dgv
                fila = 0;
                while (dgvLista.RowCount > 0)//limpia el dgv
                { dgvLista.Rows.Remove(dgvLista.CurrentRow); }
                txtAtiende.Text = txtCantVendida.Text = txtCliente.Text = txtRFC.Text = txtDireccion.Text= "";
                lblTotal.Text = lblCambio.Text = lblDescuento.Text = "0.00";

            }
        
        }

        
        private void SistemaVentas_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < ventasForm3.Length; i++)
            {
                ListaVenta[i, 0] = ventasForm3[i].Producto.Id.ToString();
                ListaVenta[i, 1] = ventasForm3[i].Producto.Descripcion.Nombre;
                ListaVenta[i, 2] = ventasForm3[i].Producto.Descripcion.Precio.ToString();
                ListaVenta[i, 3] = ventasForm3[i].Piezas.ToString();
                ListaVenta[i, 4] = ventasForm3[i].SubTotal.ToString();
                dgvLista.Rows.Add(ListaVenta[i, 0], ListaVenta[i, 1], ListaVenta[i, 2], ListaVenta[i, 3], ListaVenta[i, 4]);
            }
            CostoPagar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Portada formPortada = new Portada();
            while (dgvLista.RowCount > 0)//limpia el dgv
            { dgvLista.Rows.Remove(dgvLista.CurrentRow); }
            txtAtiende.Text = txtCantVendida.Text = txtCliente.Text = txtRFC.Text = "";
            lblTotal.Text = lblCambio.Text = lblDescuento.Text = "0.00";
            Factura Cancelar = new Factura();
            Cancelar.Show();
            this.Hide();
            formPortada.Show();
        }
    }
}
