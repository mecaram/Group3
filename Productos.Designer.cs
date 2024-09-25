namespace Gestion
{
    partial class Productos
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
            gridProductos = new DataGridView();
            txtBuscarProductos = new TextBox();
            txtCodigoBarraProducto = new TextBox();
            txtNombreProducto = new TextBox();
            txtIdProducto = new TextBox();
            btnCargarProducto = new Button();
            lblNombre = new Label();
            lblMarca = new Label();
            lblProveedor = new Label();
            lblCodBarra = new Label();
            lblRubro = new Label();
            label1 = new Label();
            btnModificarProducto = new Button();
            txtStockActualProducto = new TextBox();
            txtStockMinimoProducto = new TextBox();
            txtPrecioDeCostoProducto = new TextBox();
            txtPorcentajeGananciaProducto = new TextBox();
            txtPrecioDeVentaProducto = new TextBox();
            btnEliminarProducto = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            lblPorcentajeGanancia = new Label();
            lblPreciodeVenta = new Label();
            cboMarca = new ComboBox();
            cboProveedor = new ComboBox();
            cboRubro = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)gridProductos).BeginInit();
            SuspendLayout();
            // 
            // gridProductos
            // 
            gridProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridProductos.Location = new Point(375, 129);
            gridProductos.Margin = new Padding(3, 4, 3, 4);
            gridProductos.Name = "gridProductos";
            gridProductos.RowHeadersWidth = 51;
            gridProductos.Size = new Size(569, 307);
            gridProductos.TabIndex = 29;
            // 
            // txtBuscarProductos
            // 
            txtBuscarProductos.Location = new Point(375, 79);
            txtBuscarProductos.Margin = new Padding(3, 4, 3, 4);
            txtBuscarProductos.Name = "txtBuscarProductos";
            txtBuscarProductos.Size = new Size(569, 27);
            txtBuscarProductos.TabIndex = 28;
            // 
            // txtCodigoBarraProducto
            // 
            txtCodigoBarraProducto.Location = new Point(199, 213);
            txtCodigoBarraProducto.Margin = new Padding(3, 4, 3, 4);
            txtCodigoBarraProducto.Name = "txtCodigoBarraProducto";
            txtCodigoBarraProducto.Size = new Size(114, 27);
            txtCodigoBarraProducto.TabIndex = 26;
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(199, 110);
            txtNombreProducto.Margin = new Padding(3, 4, 3, 4);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(114, 27);
            txtNombreProducto.TabIndex = 23;
            // 
            // txtIdProducto
            // 
            txtIdProducto.Enabled = false;
            txtIdProducto.Location = new Point(199, 75);
            txtIdProducto.Margin = new Padding(3, 4, 3, 4);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(114, 27);
            txtIdProducto.TabIndex = 22;
            // 
            // btnCargarProducto
            // 
            btnCargarProducto.Location = new Point(102, 487);
            btnCargarProducto.Margin = new Padding(3, 4, 3, 4);
            btnCargarProducto.Name = "btnCargarProducto";
            btnCargarProducto.Size = new Size(86, 31);
            btnCargarProducto.TabIndex = 21;
            btnCargarProducto.Text = "Cargar";
            btnCargarProducto.UseVisualStyleBackColor = true;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(131, 113);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 20;
            lblNombre.Text = "Nombre:";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(143, 147);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(53, 20);
            lblMarca.TabIndex = 19;
            lblMarca.Text = "Marca:";
            // 
            // lblProveedor
            // 
            lblProveedor.AutoSize = true;
            lblProveedor.Location = new Point(116, 181);
            lblProveedor.Name = "lblProveedor";
            lblProveedor.Size = new Size(80, 20);
            lblProveedor.TabIndex = 18;
            lblProveedor.Text = "Proveedor:";
            // 
            // lblCodBarra
            // 
            lblCodBarra.AutoSize = true;
            lblCodBarra.Location = new Point(112, 216);
            lblCodBarra.Name = "lblCodBarra";
            lblCodBarra.Size = new Size(81, 20);
            lblCodBarra.TabIndex = 17;
            lblCodBarra.Text = "Cod. Barra:";
            // 
            // lblRubro
            // 
            lblRubro.AutoSize = true;
            lblRubro.Location = new Point(138, 255);
            lblRubro.Name = "lblRubro";
            lblRubro.Size = new Size(52, 20);
            lblRubro.TabIndex = 16;
            lblRubro.Text = "Rubro:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(166, 82);
            label1.Name = "label1";
            label1.Size = new Size(27, 20);
            label1.TabIndex = 15;
            label1.Text = "ID:";
            // 
            // btnModificarProducto
            // 
            btnModificarProducto.Location = new Point(198, 487);
            btnModificarProducto.Margin = new Padding(3, 4, 3, 4);
            btnModificarProducto.Name = "btnModificarProducto";
            btnModificarProducto.Size = new Size(86, 31);
            btnModificarProducto.TabIndex = 30;
            btnModificarProducto.Text = "Modificar";
            btnModificarProducto.UseVisualStyleBackColor = true;
            // 
            // txtStockActualProducto
            // 
            txtStockActualProducto.Location = new Point(199, 282);
            txtStockActualProducto.Margin = new Padding(3, 4, 3, 4);
            txtStockActualProducto.Name = "txtStockActualProducto";
            txtStockActualProducto.Size = new Size(114, 27);
            txtStockActualProducto.TabIndex = 31;
            // 
            // txtStockMinimoProducto
            // 
            txtStockMinimoProducto.Location = new Point(199, 317);
            txtStockMinimoProducto.Margin = new Padding(3, 4, 3, 4);
            txtStockMinimoProducto.Name = "txtStockMinimoProducto";
            txtStockMinimoProducto.Size = new Size(114, 27);
            txtStockMinimoProducto.TabIndex = 32;
            // 
            // txtPrecioDeCostoProducto
            // 
            txtPrecioDeCostoProducto.Location = new Point(199, 352);
            txtPrecioDeCostoProducto.Margin = new Padding(3, 4, 3, 4);
            txtPrecioDeCostoProducto.Name = "txtPrecioDeCostoProducto";
            txtPrecioDeCostoProducto.Size = new Size(114, 27);
            txtPrecioDeCostoProducto.TabIndex = 33;
            // 
            // txtPorcentajeGananciaProducto
            // 
            txtPorcentajeGananciaProducto.Location = new Point(199, 387);
            txtPorcentajeGananciaProducto.Margin = new Padding(3, 4, 3, 4);
            txtPorcentajeGananciaProducto.Name = "txtPorcentajeGananciaProducto";
            txtPorcentajeGananciaProducto.Size = new Size(114, 27);
            txtPorcentajeGananciaProducto.TabIndex = 34;
            // 
            // txtPrecioDeVentaProducto
            // 
            txtPrecioDeVentaProducto.Location = new Point(199, 422);
            txtPrecioDeVentaProducto.Margin = new Padding(3, 4, 3, 4);
            txtPrecioDeVentaProducto.Name = "txtPrecioDeVentaProducto";
            txtPrecioDeVentaProducto.Size = new Size(114, 27);
            txtPrecioDeVentaProducto.TabIndex = 35;
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.Location = new Point(300, 487);
            btnEliminarProducto.Margin = new Padding(3, 4, 3, 4);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(86, 31);
            btnEliminarProducto.TabIndex = 36;
            btnEliminarProducto.Text = "Eliminar";
            btnEliminarProducto.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(102, 289);
            label7.Name = "label7";
            label7.Size = new Size(94, 20);
            label7.TabIndex = 37;
            label7.Text = "Stock Actual:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(93, 324);
            label8.Name = "label8";
            label8.Size = new Size(103, 20);
            label8.TabIndex = 38;
            label8.Text = "Stock Minimo:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(80, 359);
            label9.Name = "label9";
            label9.Size = new Size(116, 20);
            label9.TabIndex = 39;
            label9.Text = "Precio de Costo:";
            // 
            // lblPorcentajeGanancia
            // 
            lblPorcentajeGanancia.AutoSize = true;
            lblPorcentajeGanancia.Location = new Point(49, 394);
            lblPorcentajeGanancia.Name = "lblPorcentajeGanancia";
            lblPorcentajeGanancia.Size = new Size(146, 20);
            lblPorcentajeGanancia.TabIndex = 40;
            lblPorcentajeGanancia.Text = "Porcentaje Ganancia:";
            // 
            // lblPreciodeVenta
            // 
            lblPreciodeVenta.AutoSize = true;
            lblPreciodeVenta.Location = new Point(78, 429);
            lblPreciodeVenta.Name = "lblPreciodeVenta";
            lblPreciodeVenta.Size = new Size(115, 20);
            lblPreciodeVenta.TabIndex = 41;
            lblPreciodeVenta.Text = "Precio de Venta:";
            // 
            // cboMarca
            // 
            cboMarca.FormattingEnabled = true;
            cboMarca.Location = new Point(198, 144);
            cboMarca.Name = "cboMarca";
            cboMarca.Size = new Size(114, 28);
            cboMarca.TabIndex = 42;
            // 
            // cboProveedor
            // 
            cboProveedor.FormattingEnabled = true;
            cboProveedor.Location = new Point(199, 178);
            cboProveedor.Name = "cboProveedor";
            cboProveedor.Size = new Size(114, 28);
            cboProveedor.TabIndex = 43;
            // 
            // cboRubro
            // 
            cboRubro.FormattingEnabled = true;
            cboRubro.Location = new Point(198, 247);
            cboRubro.Name = "cboRubro";
            cboRubro.Size = new Size(114, 28);
            cboRubro.TabIndex = 44;
            // 
            // Productos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1086, 600);
            Controls.Add(cboRubro);
            Controls.Add(cboProveedor);
            Controls.Add(cboMarca);
            Controls.Add(lblPreciodeVenta);
            Controls.Add(lblPorcentajeGanancia);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(btnEliminarProducto);
            Controls.Add(txtPrecioDeVentaProducto);
            Controls.Add(txtPorcentajeGananciaProducto);
            Controls.Add(txtPrecioDeCostoProducto);
            Controls.Add(txtStockMinimoProducto);
            Controls.Add(txtStockActualProducto);
            Controls.Add(btnModificarProducto);
            Controls.Add(gridProductos);
            Controls.Add(txtBuscarProductos);
            Controls.Add(txtCodigoBarraProducto);
            Controls.Add(txtNombreProducto);
            Controls.Add(txtIdProducto);
            Controls.Add(btnCargarProducto);
            Controls.Add(lblNombre);
            Controls.Add(lblMarca);
            Controls.Add(lblProveedor);
            Controls.Add(lblCodBarra);
            Controls.Add(lblRubro);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Productos";
            Text = "Productos";
            Load += Productos_Load;
            ((System.ComponentModel.ISupportInitialize)gridProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridProductos;
        private TextBox txtBuscarProductos;
        private TextBox txtCodigoBarraProducto;
        private TextBox txtNombreProducto;
        private TextBox txtIdProducto;
        private Button btnCargarProducto;
        private Label lblNombre;
        private Label lblMarca;
        private Label lblProveedor;
        private Label lblCodBarra;
        private Label lblRubro;
        private Label label1;
        private Button btnModificarProducto;
        private TextBox txtStockActualProducto;
        private TextBox txtStockMinimoProducto;
        private TextBox txtPrecioDeCostoProducto;
        private TextBox txtPorcentajeGananciaProducto;
        private TextBox txtPrecioDeVentaProducto;
        private Button btnEliminarProducto;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label lblPorcentajeGanancia;
        private Label lblPreciodeVenta;
        private ComboBox cboMarca;
        private ComboBox cboProveedor;
        private ComboBox cboRubro;
    }
}