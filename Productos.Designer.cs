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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            gridProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            gridProductos.BackgroundColor = SystemColors.ScrollBar;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            gridProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            gridProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            gridProductos.DefaultCellStyle = dataGridViewCellStyle3;
            gridProductos.GridColor = SystemColors.InactiveCaptionText;
            gridProductos.Location = new Point(375, 116);
            gridProductos.Margin = new Padding(3, 4, 3, 4);
            gridProductos.Name = "gridProductos";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            gridProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            gridProductos.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Bahnschrift SemiBold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            gridProductos.RowsDefaultCellStyle = dataGridViewCellStyle5;
            gridProductos.Size = new Size(569, 276);
            gridProductos.TabIndex = 29;
            gridProductos.SelectionChanged += gridProductos_SelectionChanged_1;
            // 
            // txtBuscarProductos
            // 
            txtBuscarProductos.Location = new Point(375, 71);
            txtBuscarProductos.Margin = new Padding(3, 4, 3, 4);
            txtBuscarProductos.Name = "txtBuscarProductos";
            txtBuscarProductos.Size = new Size(569, 26);
            txtBuscarProductos.TabIndex = 28;
            // 
            // txtCodigoBarraProducto
            // 
            txtCodigoBarraProducto.Location = new Point(199, 192);
            txtCodigoBarraProducto.Margin = new Padding(3, 4, 3, 4);
            txtCodigoBarraProducto.Name = "txtCodigoBarraProducto";
            txtCodigoBarraProducto.Size = new Size(114, 26);
            txtCodigoBarraProducto.TabIndex = 26;
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(199, 99);
            txtNombreProducto.Margin = new Padding(3, 4, 3, 4);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(114, 26);
            txtNombreProducto.TabIndex = 23;
            // 
            // txtIdProducto
            // 
            txtIdProducto.Enabled = false;
            txtIdProducto.Location = new Point(199, 68);
            txtIdProducto.Margin = new Padding(3, 4, 3, 4);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(114, 26);
            txtIdProducto.TabIndex = 22;
            // 
            // btnCargarProducto
            // 
            btnCargarProducto.Location = new Point(102, 438);
            btnCargarProducto.Margin = new Padding(3, 4, 3, 4);
            btnCargarProducto.Name = "btnCargarProducto";
            btnCargarProducto.Size = new Size(86, 28);
            btnCargarProducto.TabIndex = 21;
            btnCargarProducto.Text = "Cargar";
            btnCargarProducto.UseVisualStyleBackColor = true;
            btnCargarProducto.Click += btnCargarProducto_Click_1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(131, 102);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(65, 18);
            lblNombre.TabIndex = 20;
            lblNombre.Text = "Nombre:";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(143, 132);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(52, 18);
            lblMarca.TabIndex = 19;
            lblMarca.Text = "Marca:";
            // 
            // lblProveedor
            // 
            lblProveedor.AutoSize = true;
            lblProveedor.Location = new Point(116, 163);
            lblProveedor.Name = "lblProveedor";
            lblProveedor.Size = new Size(79, 18);
            lblProveedor.TabIndex = 18;
            lblProveedor.Text = "Proveedor:";
            // 
            // lblCodBarra
            // 
            lblCodBarra.AutoSize = true;
            lblCodBarra.Location = new Point(112, 194);
            lblCodBarra.Name = "lblCodBarra";
            lblCodBarra.Size = new Size(81, 18);
            lblCodBarra.TabIndex = 17;
            lblCodBarra.Text = "Cod. Barra:";
            // 
            // lblRubro
            // 
            lblRubro.AutoSize = true;
            lblRubro.Location = new Point(138, 230);
            lblRubro.Name = "lblRubro";
            lblRubro.Size = new Size(51, 18);
            lblRubro.TabIndex = 16;
            lblRubro.Text = "Rubro:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(166, 74);
            label1.Name = "label1";
            label1.Size = new Size(25, 18);
            label1.TabIndex = 15;
            label1.Text = "ID:";
            // 
            // btnModificarProducto
            // 
            btnModificarProducto.Location = new Point(198, 438);
            btnModificarProducto.Margin = new Padding(3, 4, 3, 4);
            btnModificarProducto.Name = "btnModificarProducto";
            btnModificarProducto.Size = new Size(86, 28);
            btnModificarProducto.TabIndex = 30;
            btnModificarProducto.Text = "Modificar";
            btnModificarProducto.UseVisualStyleBackColor = true;
            btnModificarProducto.Click += btnModificarProducto_Click_1;
            // 
            // txtStockActualProducto
            // 
            txtStockActualProducto.Location = new Point(199, 254);
            txtStockActualProducto.Margin = new Padding(3, 4, 3, 4);
            txtStockActualProducto.Name = "txtStockActualProducto";
            txtStockActualProducto.Size = new Size(114, 26);
            txtStockActualProducto.TabIndex = 31;
            // 
            // txtStockMinimoProducto
            // 
            txtStockMinimoProducto.Location = new Point(199, 285);
            txtStockMinimoProducto.Margin = new Padding(3, 4, 3, 4);
            txtStockMinimoProducto.Name = "txtStockMinimoProducto";
            txtStockMinimoProducto.Size = new Size(114, 26);
            txtStockMinimoProducto.TabIndex = 32;
            // 
            // txtPrecioDeCostoProducto
            // 
            txtPrecioDeCostoProducto.Location = new Point(199, 317);
            txtPrecioDeCostoProducto.Margin = new Padding(3, 4, 3, 4);
            txtPrecioDeCostoProducto.Name = "txtPrecioDeCostoProducto";
            txtPrecioDeCostoProducto.Size = new Size(114, 26);
            txtPrecioDeCostoProducto.TabIndex = 33;
            txtPrecioDeCostoProducto.Leave += txtPrecioDeCostoProducto_Leave;
            // 
            // txtPorcentajeGananciaProducto
            // 
            txtPorcentajeGananciaProducto.Location = new Point(199, 348);
            txtPorcentajeGananciaProducto.Margin = new Padding(3, 4, 3, 4);
            txtPorcentajeGananciaProducto.Name = "txtPorcentajeGananciaProducto";
            txtPorcentajeGananciaProducto.Size = new Size(114, 26);
            txtPorcentajeGananciaProducto.TabIndex = 34;
            txtPorcentajeGananciaProducto.Leave += txtPorcentajeGananciaProducto_Leave;
            // 
            // txtPrecioDeVentaProducto
            // 
            txtPrecioDeVentaProducto.Location = new Point(199, 380);
            txtPrecioDeVentaProducto.Margin = new Padding(3, 4, 3, 4);
            txtPrecioDeVentaProducto.Name = "txtPrecioDeVentaProducto";
            txtPrecioDeVentaProducto.Size = new Size(114, 26);
            txtPrecioDeVentaProducto.TabIndex = 35;
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.Location = new Point(300, 438);
            btnEliminarProducto.Margin = new Padding(3, 4, 3, 4);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(86, 28);
            btnEliminarProducto.TabIndex = 36;
            btnEliminarProducto.Text = "Eliminar";
            btnEliminarProducto.UseVisualStyleBackColor = true;
            btnEliminarProducto.Click += btnEliminarProducto_Click_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(102, 260);
            label7.Name = "label7";
            label7.Size = new Size(94, 18);
            label7.TabIndex = 37;
            label7.Text = "Stock Actual:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(93, 292);
            label8.Name = "label8";
            label8.Size = new Size(101, 18);
            label8.TabIndex = 38;
            label8.Text = "Stock Minimo:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(80, 323);
            label9.Name = "label9";
            label9.Size = new Size(115, 18);
            label9.TabIndex = 39;
            label9.Text = "Precio de Costo:";
            // 
            // lblPorcentajeGanancia
            // 
            lblPorcentajeGanancia.AutoSize = true;
            lblPorcentajeGanancia.Location = new Point(49, 355);
            lblPorcentajeGanancia.Name = "lblPorcentajeGanancia";
            lblPorcentajeGanancia.Size = new Size(146, 18);
            lblPorcentajeGanancia.TabIndex = 40;
            lblPorcentajeGanancia.Text = "Porcentaje Ganancia:";
            // 
            // lblPreciodeVenta
            // 
            lblPreciodeVenta.AutoSize = true;
            lblPreciodeVenta.Location = new Point(78, 386);
            lblPreciodeVenta.Name = "lblPreciodeVenta";
            lblPreciodeVenta.Size = new Size(114, 18);
            lblPreciodeVenta.TabIndex = 41;
            lblPreciodeVenta.Text = "Precio de Venta:";
            // 
            // cboMarca
            // 
            cboMarca.FormattingEnabled = true;
            cboMarca.Location = new Point(198, 130);
            cboMarca.Name = "cboMarca";
            cboMarca.Size = new Size(114, 26);
            cboMarca.TabIndex = 42;
            // 
            // cboProveedor
            // 
            cboProveedor.FormattingEnabled = true;
            cboProveedor.Location = new Point(199, 160);
            cboProveedor.Name = "cboProveedor";
            cboProveedor.Size = new Size(114, 26);
            cboProveedor.TabIndex = 43;
            // 
            // cboRubro
            // 
            cboRubro.FormattingEnabled = true;
            cboRubro.Location = new Point(198, 222);
            cboRubro.Name = "cboRubro";
            cboRubro.Size = new Size(114, 26);
            cboRubro.TabIndex = 44;
            // 
            // Productos
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1086, 540);
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
            Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
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