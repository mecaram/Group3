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
            label6 = new Label();
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
            gridProductos.Location = new Point(353, 160);
            gridProductos.Name = "gridProductos";
            gridProductos.Size = new Size(498, 230);
            gridProductos.TabIndex = 29;
            // 
            // txtBuscarProductos
            // 
            txtBuscarProductos.Location = new Point(351, 120);
            txtBuscarProductos.Name = "txtBuscarProductos";
            txtBuscarProductos.Size = new Size(500, 23);
            txtBuscarProductos.TabIndex = 28;
            // 
            // txtIdRubroProducto
            // 
            txtIdRubroProducto.Location = new Point(167, 188);
            txtIdRubroProducto.Name = "txtIdRubroProducto";
            txtIdRubroProducto.Size = new Size(100, 23);
            txtIdRubroProducto.TabIndex = 27;
            // 
            // txtCodigoBarraProducto
            // 
            txtCodigoBarraProducto.Location = new Point(167, 157);
            txtCodigoBarraProducto.Name = "txtCodigoBarraProducto";
            txtCodigoBarraProducto.Size = new Size(100, 23);
            txtCodigoBarraProducto.TabIndex = 26;
            // 
            // txtIdProveedorProducto
            // 
            txtIdProveedorProducto.Location = new Point(167, 126);
            txtIdProveedorProducto.Name = "txtIdProveedorProducto";
            txtIdProveedorProducto.Size = new Size(100, 23);
            txtIdProveedorProducto.TabIndex = 25;
            // 
            // txtMarcaProducto
            // 
            txtMarcaProducto.Location = new Point(167, 98);
            txtMarcaProducto.Name = "txtMarcaProducto";
            txtMarcaProducto.Size = new Size(100, 23);
            txtMarcaProducto.TabIndex = 24;
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(167, 71);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(100, 23);
            txtNombreProducto.TabIndex = 23;
            // 
            // txtIdProducto
            // 
            txtIdProducto.Location = new Point(167, 42);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(100, 23);
            txtIdProducto.TabIndex = 22;
            // 
            // btnCargarProducto
            // 
            btnCargarProducto.Location = new Point(92, 367);
            btnCargarProducto.Name = "btnCargarProducto";
            btnCargarProducto.Size = new Size(75, 23);
            btnCargarProducto.TabIndex = 21;
            btnCargarProducto.Text = "Cargar";
            btnCargarProducto.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(105, 79);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 20;
            label6.Text = "Nombre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(105, 106);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 19;
            label5.Text = "Marca";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(105, 134);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 18;
            label4.Text = "Proveedor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(100, 165);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 17;
            label3.Text = "Cod. Barra";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(105, 191);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 16;
            label2.Text = "Rubro";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 45);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 15;
            label1.Text = "ID";
            // 
            // btnModificarProducto
            // 
            btnModificarProducto.Location = new Point(173, 367);
            btnModificarProducto.Name = "btnModificarProducto";
            btnModificarProducto.Size = new Size(75, 23);
            btnModificarProducto.TabIndex = 30;
            btnModificarProducto.Text = "Modificar";
            btnModificarProducto.UseVisualStyleBackColor = true;
            // 
            // txtStockActualProducto
            // 
            txtStockActualProducto.Location = new Point(167, 217);
            txtStockActualProducto.Name = "txtStockActualProducto";
            txtStockActualProducto.Size = new Size(100, 23);
            txtStockActualProducto.TabIndex = 31;
            // 
            // txtStockMinimoProducto
            // 
            txtStockMinimoProducto.Location = new Point(166, 246);
            txtStockMinimoProducto.Name = "txtStockMinimoProducto";
            txtStockMinimoProducto.Size = new Size(100, 23);
            txtStockMinimoProducto.TabIndex = 32;
            // 
            // txtPrecioDeCostoProducto
            // 
            txtPrecioDeCostoProducto.Location = new Point(166, 275);
            txtPrecioDeCostoProducto.Name = "txtPrecioDeCostoProducto";
            txtPrecioDeCostoProducto.Size = new Size(100, 23);
            txtPrecioDeCostoProducto.TabIndex = 33;
            // 
            // txtPorcentajeGananciaProducto
            // 
            txtPorcentajeGananciaProducto.Location = new Point(167, 304);
            txtPorcentajeGananciaProducto.Name = "txtPorcentajeGananciaProducto";
            txtPorcentajeGananciaProducto.Size = new Size(100, 23);
            txtPorcentajeGananciaProducto.TabIndex = 34;
            // 
            // txtPrecioDeVentaProducto
            // 
            txtPrecioDeVentaProducto.Location = new Point(167, 333);
            txtPrecioDeVentaProducto.Name = "txtPrecioDeVentaProducto";
            txtPrecioDeVentaProducto.Size = new Size(100, 23);
            txtPrecioDeVentaProducto.TabIndex = 35;
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.Location = new Point(254, 367);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(75, 23);
            btnEliminarProducto.TabIndex = 36;
            btnEliminarProducto.Text = "Eliminar";
            btnEliminarProducto.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(89, 225);
            label7.Name = "label7";
            label7.Size = new Size(73, 15);
            label7.TabIndex = 37;
            label7.Text = "Stock Actual";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(81, 249);
            label8.Name = "label8";
            label8.Size = new Size(81, 15);
            label8.TabIndex = 38;
            label8.Text = "Stock Minimo";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(70, 278);
            label9.Name = "label9";
            label9.Size = new Size(90, 15);
            label9.TabIndex = 39;
            label9.Text = "Precio de Costo";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(41, 312);
            label10.Name = "label10";
            label10.Size = new Size(115, 15);
            label10.TabIndex = 40;
            label10.Text = "Porcentaje Ganancia";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(68, 341);
            label11.Name = "label11";
            label11.Size = new Size(88, 15);
            label11.TabIndex = 41;
            label11.Text = "Precio de Venta";
            // 
            // Productos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private Label label6;
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