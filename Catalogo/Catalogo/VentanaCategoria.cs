using System;
using System.Windows.Forms;
using System.Data;
using System.Collections;
using System.IO;
using System.Collections.Generic;

namespace Catalogo
{    
    public partial class VentanaCategoria : Form{
        private ControlInventario controlForm1;
        private int[] ventasAux;
        public VentanaCategoria(ControlInventario controlForm1){
            InitializeComponent();
            this.controlForm1 = controlForm1;
        }

        public VentanaCategoria()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e){
            label1.Text = controlForm1.Inventario.GetProducto(0).GetNombrePrecioDispo();
            label2.Text = controlForm1.Inventario.GetProducto(1).GetNombrePrecioDispo();
            label3.Text = controlForm1.Inventario.GetProducto(2).GetNombrePrecioDispo();
            label4.Text = controlForm1.Inventario.GetProducto(3).GetNombrePrecioDispo();
            label5.Text = controlForm1.Inventario.GetProducto(4).GetNombrePrecioDispo();
            label6.Text = controlForm1.Inventario.GetProducto(5).GetNombrePrecioDispo();
            label7.Text = controlForm1.Inventario.GetProducto(6).GetNombrePrecioDispo();
            label8.Text = controlForm1.Inventario.GetProducto(7).GetNombrePrecioDispo();
            label9.Text = controlForm1.Inventario.GetProducto(8).GetNombrePrecioDispo();
            label10.Text = controlForm1.Inventario.GetProducto(9).GetNombrePrecioDispo();
            label11.Text = controlForm1.Inventario.GetProducto(10).GetNombrePrecioDispo();
            label12.Text = controlForm1.Inventario.GetProducto(11).GetNombrePrecioDispo();
            label13.Text = controlForm1.Inventario.GetProducto(12).GetNombrePrecioDispo();
            label14.Text = controlForm1.Inventario.GetProducto(13).GetNombrePrecioDispo();
            label15.Text = controlForm1.Inventario.GetProducto(14).GetNombrePrecioDispo();
            label16.Text = controlForm1.Inventario.GetProducto(15).GetNombrePrecioDispo();
            label17.Text = controlForm1.Inventario.GetProducto(16).GetNombrePrecioDispo();
            label18.Text = controlForm1.Inventario.GetProducto(17).GetNombrePrecioDispo();
            pictureBox1.Image = controlForm1.Inventario.GetProducto(0).Imagen;
            pictureBox2.Image = controlForm1.Inventario.GetProducto(1).Imagen;
            pictureBox3.Image = controlForm1.Inventario.GetProducto(2).Imagen;
            pictureBox4.Image = controlForm1.Inventario.GetProducto(3).Imagen;
            pictureBox5.Image = controlForm1.Inventario.GetProducto(4).Imagen;
            pictureBox6.Image = controlForm1.Inventario.GetProducto(5).Imagen;
            pictureBox7.Image = controlForm1.Inventario.GetProducto(6).Imagen;
            pictureBox8.Image = controlForm1.Inventario.GetProducto(7).Imagen;
            pictureBox9.Image = controlForm1.Inventario.GetProducto(8).Imagen;
            pictureBox10.Image = controlForm1.Inventario.GetProducto(9).Imagen;
            pictureBox11.Image = controlForm1.Inventario.GetProducto(10).Imagen;
            pictureBox12.Image = controlForm1.Inventario.GetProducto(11).Imagen;
            pictureBox13.Image = controlForm1.Inventario.GetProducto(12).Imagen;
            pictureBox14.Image = controlForm1.Inventario.GetProducto(13).Imagen;
            pictureBox15.Image = controlForm1.Inventario.GetProducto(14).Imagen;
            pictureBox16.Image = controlForm1.Inventario.GetProducto(15).Imagen;
            pictureBox17.Image = controlForm1.Inventario.GetProducto(16).Imagen;
            pictureBox18.Image = controlForm1.Inventario.GetProducto(17).Imagen;
        }

        private void ProductoDispon(int idProducto) {

            if (controlForm1.Inventario.GetProducto(idProducto).Existencias.PiezasInventario == 0)
            {
                MessageBox.Show("Articulo no Disponible", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else{
               VentanaDetalles ventanaDetalles = new VentanaDetalles();
                
                ventanaDetalles.FijarImagen(controlForm1.Inventario.GetProducto(idProducto).Imagen, idProducto,controlForm1.Inventario.GetProducto(idProducto).Existencias.PiezasInventario); 
                ventanaDetalles.FijarLabel(controlForm1.Inventario.GetProducto(idProducto).Descripcion.ToString());
                ventanaDetalles.Show();
            }
        } 
        private void RadioButton1_CheckedChanged(object sender, EventArgs e){tabControl1.SelectTab(0); }
        private void RadioButton2_CheckedChanged(object sender, EventArgs e){ tabControl1.SelectTab(1);}
        private void RadioButton3_CheckedChanged(object sender, EventArgs e){tabControl1.SelectTab(2); }
        private void RadioButton4_CheckedChanged(object sender, EventArgs e){tabControl1.SelectTab(3);  }
        private void RadioButton5_CheckedChanged(object sender, EventArgs e){tabControl1.SelectTab(4); }
        private void RadioButton6_CheckedChanged(object sender, EventArgs e){tabControl1.SelectTab(5); }

        private void PictureBox1_Click(object sender, EventArgs e){
            ProductoDispon(0);
        }
        private void PictureBox2_Click(object sender, EventArgs e){
            ProductoDispon(1);
        }
        private void PictureBox3_Click(object sender, EventArgs e){DatosProducto f2 = new DatosProducto();
            ProductoDispon(2);
        }
        private void PictureBox4_Click(object sender, EventArgs e){
            ProductoDispon(3);
        }
        private void PictureBox5_Click(object sender, EventArgs e) {
           ProductoDispon(4);
        }
        private void PictureBox6_Click(object sender, EventArgs e) {
            ProductoDispon(5);
        }
        private void PictureBox7_Click(object sender, EventArgs e) {
            ProductoDispon(6);
        } 
        private void PictureBox8_Click(object sender, EventArgs e){
            ProductoDispon(7);
        }
        private void PictureBox9_Click(object sender, EventArgs e){
            ProductoDispon(8);
        }
        private void PictureBox10_Click(object sender, EventArgs e){
            ProductoDispon(9);
        }
        private void PictureBox11_Click(object sender, EventArgs e){
            ProductoDispon(10);
        }
        private void PictureBox12_Click(object sender, EventArgs e){
            ProductoDispon(11);
        }
        private void PictureBox13_Click(object sender, EventArgs e){
            ProductoDispon(12);
        }
        private void PictureBox14_Click(object sender, EventArgs e) {
            ProductoDispon(13);
        }
        private void PictureBox15_Click(object sender, EventArgs e){
            ProductoDispon(14);
        }
        private void PictureBox16_Click(object sender, EventArgs e) {
            ProductoDispon(15);
        }
        private void PictureBox17_Click(object sender, EventArgs e){
            ProductoDispon(16);
        }
        private void PictureBox18_Click(object sender, EventArgs e){
            ProductoDispon(17);
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e){
        }
        private void TabControl1_TabIndexChanged(object sender, EventArgs e) { }
        private void TabPage1_Click(object sender, EventArgs e) { }    
        private void GroupBox1_TabIndexChanged(object sender, EventArgs e) { }
        private void Label1_Click(object sender, EventArgs e){}
        private void Label5_Click(object sender, EventArgs e){}
        private void PictureBox5_Click_1(object sender, EventArgs e) { }
        private void PictureBox5_Click_2(object sender, EventArgs e){ }
        private void PictureBox6_Click_1(object sender, EventArgs e) { }
        private void PictureBox7_Click_1(object sender, EventArgs e) { }
        private void PictureBox12_Click_1(object sender, EventArgs e) { }
        private void MenuItem1_Click(object sender, EventArgs e){}
        
        private void Button1_Click(object sender, EventArgs e) {
            VentanaCarrito ventanaCarrito = new VentanaCarrito();
            ventanaCarrito.Show();
        }
        private void Label1_Click_1(object sender, EventArgs e){}
        private void Form1_Activated(object sender, EventArgs e){}
        private void Form1_Leave(object sender, EventArgs e){}
        private void Label17_Click(object sender, EventArgs e){}
        private void groupBox1_Enter(object sender, EventArgs e){}
    }
}
