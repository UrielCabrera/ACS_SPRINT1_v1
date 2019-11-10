namespace Catalogo
{
    partial class VentanaCarrito
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listViewCarrito = new System.Windows.Forms.ListView();
            this.columna1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columna2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columna3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columna4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columna5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.botonRealizarCompra = new System.Windows.Forms.Button();
            this.botonEliminar = new System.Windows.Forms.Button();
            this.labelResumenPedido = new System.Windows.Forms.Label();
            this.labelSeleccionar = new System.Windows.Forms.Label();
            this.labelTexto = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(60, 60);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // listViewCarrito
            // 
            this.listViewCarrito.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columna1,
            this.columna2,
            this.columna3,
            this.columna4,
            this.columna5});
            this.listViewCarrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewCarrito.HideSelection = false;
            this.listViewCarrito.Location = new System.Drawing.Point(34, 99);
            this.listViewCarrito.Name = "listViewCarrito";
            this.listViewCarrito.Size = new System.Drawing.Size(960, 487);
            this.listViewCarrito.SmallImageList = this.imageList1;
            this.listViewCarrito.TabIndex = 0;
            this.listViewCarrito.UseCompatibleStateImageBehavior = false;
            this.listViewCarrito.View = System.Windows.Forms.View.Details;
            this.listViewCarrito.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewCarrito_ItemSelectionChanged);
            this.listViewCarrito.SelectedIndexChanged += new System.EventHandler(this.listViewCarrito_SelectedIndexChanged);
            // 
            // columna1
            // 
            this.columna1.Text = "Articulo";
            this.columna1.Width = 146;
            // 
            // columna2
            // 
            this.columna2.Text = "Nombre";
            this.columna2.Width = 129;
            // 
            // columna3
            // 
            this.columna3.Text = "Precio";
            this.columna3.Width = 76;
            // 
            // columna4
            // 
            this.columna4.Text = "Numero de Piezas";
            this.columna4.Width = 146;
            // 
            // columna5
            // 
            this.columna5.Text = "SubTotal";
            this.columna5.Width = 112;
            // 
            // botonRealizarCompra
            // 
            this.botonRealizarCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonRealizarCompra.Location = new System.Drawing.Point(1064, 485);
            this.botonRealizarCompra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.botonRealizarCompra.Name = "botonRealizarCompra";
            this.botonRealizarCompra.Size = new System.Drawing.Size(105, 68);
            this.botonRealizarCompra.TabIndex = 1;
            this.botonRealizarCompra.Text = "Realizar Compra";
            this.botonRealizarCompra.UseVisualStyleBackColor = true;
            this.botonRealizarCompra.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // botonEliminar
            // 
            this.botonEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonEliminar.Location = new System.Drawing.Point(39, 618);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(105, 36);
            this.botonEliminar.TabIndex = 2;
            this.botonEliminar.Text = "Eliminar";
            this.botonEliminar.UseVisualStyleBackColor = true;
            this.botonEliminar.Click += new System.EventHandler(this.botonEliminar_Click);
            // 
            // labelResumenPedido
            // 
            this.labelResumenPedido.AutoSize = true;
            this.labelResumenPedido.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResumenPedido.Location = new System.Drawing.Point(385, 32);
            this.labelResumenPedido.Name = "labelResumenPedido";
            this.labelResumenPedido.Size = new System.Drawing.Size(271, 29);
            this.labelResumenPedido.TabIndex = 3;
            this.labelResumenPedido.Text = "Detalles del Pedido";
            // 
            // labelSeleccionar
            // 
            this.labelSeleccionar.AutoSize = true;
            this.labelSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeleccionar.Location = new System.Drawing.Point(35, 74);
            this.labelSeleccionar.Name = "labelSeleccionar";
            this.labelSeleccionar.Size = new System.Drawing.Size(104, 22);
            this.labelSeleccionar.TabIndex = 4;
            this.labelSeleccionar.Text = "Seleccionar";
            // 
            // labelTexto
            // 
            this.labelTexto.AutoSize = true;
            this.labelTexto.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTexto.Location = new System.Drawing.Point(1057, 135);
            this.labelTexto.Name = "labelTexto";
            this.labelTexto.Size = new System.Drawing.Size(112, 37);
            this.labelTexto.TabIndex = 5;
            this.labelTexto.Text = "TOTAL";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(1084, 204);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(64, 25);
            this.labelTotal.TabIndex = 6;
            this.labelTotal.Text = "label1";
            // 
            // VentanaCarrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 720);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelTexto);
            this.Controls.Add(this.labelSeleccionar);
            this.Controls.Add(this.labelResumenPedido);
            this.Controls.Add(this.botonEliminar);
            this.Controls.Add(this.botonRealizarCompra);
            this.Controls.Add(this.listViewCarrito);
            this.Name = "VentanaCarrito";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView listViewCarrito;
        private System.Windows.Forms.ColumnHeader columna1;
        private System.Windows.Forms.ColumnHeader columna2;
        private System.Windows.Forms.ColumnHeader columna3;
        private System.Windows.Forms.ColumnHeader columna4;
        private System.Windows.Forms.ColumnHeader columna5;
        private System.Windows.Forms.Button botonRealizarCompra;
        private System.Windows.Forms.Button botonEliminar;
        private System.Windows.Forms.Label labelResumenPedido;
        private System.Windows.Forms.Label labelSeleccionar;
        private System.Windows.Forms.Label labelTexto;
        private System.Windows.Forms.Label labelTotal;
    }
}