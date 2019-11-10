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
    public partial class DatosProducto : Form
    {
        public DatosProducto()
        {
            InitializeComponent();
        }

        public DatosProducto(String text)
        {
            InitializeComponent();
            
            textBox1.Text =text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double cantidad = Convert.ToDouble(textBox2.Text);
                string nombre = textBox1.Text;
                string direccion = textBox3.Text;
                int telefono = Convert.ToInt32(textBox5.Text);
                double precio = Convert.ToDouble(textBox6.Text);
                double total = cantidad * precio;

                dataGridView1.Rows.Add(cantidad, nombre, direccion, telefono,precio, total);
            }
            catch
            {
                MessageBox.Show("Error en los datos capturados");
            }
            finally
            {
                textBox2.Clear();
                textBox1.Clear();
                textBox3.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox4.Clear();
            }
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            btnagregar.Enabled = true;
            btnquitar.Enabled = true;
            btnfinalizar.Enabled = true;

            textBox2.Clear();
            textBox1.Clear();
            textBox3.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void btnquitar_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow != null)
            {
                int posicion = dataGridView1.CurrentRow.Index;
                dataGridView1.Rows.RemoveAt(posicion);
            }

            }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnfinalizar_Click(object sender, EventArgs e)
        {
            int j;
            double sub=0;
            int cuantosrenglones = dataGridView1.Rows.Count;
            if(cuantosrenglones == 0)
            {
                MessageBox.Show("No hay articulos para totalizar");
                return;
            }
            for(j=0; j<=cuantosrenglones - 1; j++)
            {
                sub = sub + Convert.ToDouble(dataGridView1[5,j].Value);
            }
            double iva = sub * 0.16;
            double total = sub + iva;

            dataGridView1.Rows.Add("", "", "TOTAL:", sub);
            dataGridView1.Rows.Add("", "", "IVA:", total);
            btnfinalizar.Enabled = false;
            btnquitar.Enabled = false;
            btnagregar.Enabled = false;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }

