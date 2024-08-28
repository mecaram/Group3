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
            txtIdRubroProducto = new TextBox();
            txtCodigoBarraProducto = new TextBox();
            txtIdProveedorProducto = new TextBox();
            txtMarcaProducto = new TextBox();
            txtNombreProducto = new TextBox();
            txtIdProducto = new TextBox();
            btnCargarProducto = new Button();
            lblNombre = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
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
            label10 = new Label();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)gridProductos).BeginInit();
            SuspendLayout();
            // 
            // gridProductos
            // 
            gridProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridProductos.Location = new Point(403, 213);
            gridProductos.Margin = new Padding(3, 4, 3, 4);
            gridProductos.Name = "gridProductos";
            gridProductos.RowHeadersWidth = 51;
            gridProductos.Size = new Size(569, 307);
            gridProductos.TabIndex = 29;
            // 
            // txtBuscarProductos
            // 
            txtBuscarProductos.Location = new Point(401, 160);
            txtBuscarProductos.Margin = new Padding(3, 4, 3, 4);
            txtBuscarProductos.Name = "txtBuscarProductos";
            txtBuscarProductos.Size = new Size(571, 27);
            txtBuscarProductos.TabIndex = 28;
            // 
            // txtIdRubroProducto
            // 
            txtIdRubroProducto.Location = new Point(191, 251);
            txtIdRubroProducto.Margin = new Padding(3, 4, 3, 4);
            txtIdRubroProducto.Name = "txtIdRubroProducto";
            txtIdRubroProducto.Size = new Size(114, 27);
            txtIdRubroProducto.TabIndex = 27;
            // 
            // txtCodigoBarraProducto
            // 
            txtCodigoBarraProducto.Location = new Point(191, 209);
            txtCodigoBarraProducto.Margin = new Padding(3, 4, 3, 4);
            txtCodigoBarraProducto.Name = "txtCodigoBarraProducto";
            txtCodigoBarraProducto.Size = new Size(114, 27);
            txtCodigoBarraProducto.TabIndex = 26;
            // 
            // txtIdProveedorProducto
            // 
            txtIdProveedorProducto.Location = new Point(191, 168);
            txtIdProveedorProducto.Margin = new Padding(3, 4, 3, 4);
            txtIdProveedorProducto.Name = "txtIdProveedorProducto";
            txtIdProveedorProducto.Size = new Size(114, 27);
            txtIdProveedorProducto.TabIndex = 25;
            // 
            // txtMarcaProducto
            // 
            txtMarcaProducto.Location = new Point(191, 131);
            txtMarcaProducto.Margin = new Padding(3, 4, 3, 4);
            txtMarcaProducto.Name = "txtMarcaProducto";
            txtMarcaProducto.Size = new Size(114, 27);
            txtMarcaProducto.TabIndex = 24;
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(191, 95);
            txtNombreProducto.Margin = new Padding(3, 4, 3, 4);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(114, 27);
            txtNombreProducto.TabIndex = 23;
            // 
            // txtIdProducto
            // 
            txtIdProducto.Enabled = false;
            txtIdProducto.Location = new Point(191, 56);
            txtIdProducto.Margin = new Padding(3, 4, 3, 4);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(114, 27);
            txtIdProducto.TabIndex = 22;
            // 
            // btnCargarProducto
            // 
            btnCargarProducto.Location = new Point(105, 489);
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
            lblNombre.Location = new Point(120, 105);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 20;
            lblNombre.Text = "Nombre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(120, 141);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 19;
            label5.Text = "Marca";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(120, 179);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 18;
            label4.Text = "Proveedor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(114, 220);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 17;
            label3.Text = "Cod. Barra";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(120, 255);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 16;
            label2.Text = "Rubro";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(120, 60);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 15;
            label1.Text = "ID";
            // 
            // btnModificarProducto
            // 
            btnModificarProducto.Location = new Point(198, 489);
            btnModificarProducto.Margin = new Padding(3, 4, 3, 4);
            btnModificarProducto.Name = "btnModificarProducto";
            btnModificarProducto.Size = new Size(86, 31);
            btnModificarProducto.TabIndex = 30;
            btnModificarProducto.Text = "Modificar";
            btnModificarProducto.UseVisualStyleBackColor = true;
            // 
            // txtStockActualProducto
            // 
            txtStockActualProducto.Location = new Point(191, 289);
            txtStockActualProducto.Margin = new Padding(3, 4, 3, 4);
            txtStockActualProducto.Name = "txtStockActualProducto";
            txtStockActualProducto.Size = new Size(114, 27);
            txtStockActualProducto.TabIndex = 31;
            // 
            // txtStockMinimoProducto
            // 
            txtStockMinimoProducto.Location = new Point(190, 328);
            txtStockMinimoProducto.Margin = new Padding(3, 4, 3, 4);
            txtStockMinimoProducto.Name = "txtStockMinimoProducto";
            txtStockMinimoProducto.Size = new Size(114, 27);
            txtStockMinimoProducto.TabIndex = 32;
            // 
            // txtPrecioDeCostoProducto
            // 
            txtPrecioDeCostoProducto.Location = new Point(190, 367);
            txtPrecioDeCostoProducto.Margin = new Padding(3, 4, 3, 4);
            txtPrecioDeCostoProducto.Name = "txtPrecioDeCostoProducto";
            txtPrecioDeCostoProducto.Size = new Size(114, 27);
            txtPrecioDeCostoProducto.TabIndex = 33;
            // 
            // txtPorcentajeGananciaProducto
            // 
            txtPorcentajeGananciaProducto.Location = new Point(191, 405);
            txtPorcentajeGananciaProducto.Margin = new Padding(3, 4, 3, 4);
            txtPorcentajeGananciaProducto.Name = "txtPorcentajeGananciaProducto";
            txtPorcentajeGananciaProducto.Size = new Size(114, 27);
            txtPorcentajeGananciaProducto.TabIndex = 34;
            // 
            // txtPrecioDeVentaProducto
            // 
            txtPrecioDeVentaProducto.Location = new Point(191, 444);
            txtPrecioDeVentaProducto.Margin = new Padding(3, 4, 3, 4);
            txtPrecioDeVentaProducto.Name = "txtPrecioDeVentaProducto";
            txtPrecioDeVentaProducto.Size = new Size(114, 27);
            txtPrecioDeVentaProducto.TabIndex = 35;
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.Location = new Point(290, 489);
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
            label7.Location = new Point(102, 300);
            label7.Name = "label7";
            label7.Size = new Size(91, 20);
            label7.TabIndex = 37;
            label7.Text = "Stock Actual";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(93, 332);
            label8.Name = "label8";
            label8.Size = new Size(100, 20);
            label8.TabIndex = 38;
            label8.Text = "Stock Minimo";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(80, 371);
            label9.Name = "label9";
            label9.Size = new Size(113, 20);
            label9.TabIndex = 39;
            label9.Text = "Precio de Costo";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(47, 416);
            label10.Name = "label10";
            label10.Size = new Size(143, 20);
            label10.TabIndex = 40;
            label10.Text = "Porcentaje Ganancia";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(78, 455);
            label11.Name = "label11";
            label11.Size = new Size(112, 20);
            label11.TabIndex = 41;
            label11.Text = "Precio de Venta";
            // 
            // Productos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(label11);
            Controls.Add(label10);
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
            Controls.Add(txtIdRubroProducto);
            Controls.Add(txtCodigoBarraProducto);
            Controls.Add(txtIdProveedorProducto);
            Controls.Add(txtMarcaProducto);
            Controls.Add(txtNombreProducto);
            Controls.Add(txtIdProducto);
            Controls.Add(btnCargarProducto);
            Controls.Add(lblNombre);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Productos";
            Text = "Productos";
            ((System.ComponentModel.ISupportInitialize)gridProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridProductos;
        private TextBox txtBuscarProductos;
        private TextBox txtIdRubroProducto;
        private TextBox txtCodigoBarraProducto;
        private TextBox txtIdProveedorProducto;
        private TextBox txtMarcaProducto;
        private TextBox txtNombreProducto;
        private TextBox txtIdProducto;
        private Button btnCargarProducto;
        private Label lblNombre;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
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
        private Label label10;
        private Label label11;
    }
}