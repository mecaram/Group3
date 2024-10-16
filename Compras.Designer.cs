namespace Gestion
{
    partial class Compras
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
            btnModificar = new Button();
            btnEliminar = new Button();
            btnAgregar = new Button();
            lblIdCompra = new Label();
            lblIdProducto = new Label();
            lblIdProveedor = new Label();
            lblPrecioCompra = new Label();
            lblCantidadDeCompra = new Label();
            lblIdCierre = new Label();
            txtIdCompra = new TextBox();
            txtPrecioCompra = new TextBox();
            txtCantidadDeCompra = new TextBox();
            txtIdCierre = new TextBox();
            txtBuscador = new TextBox();
            gridCompras = new DataGridView();
            cboIdProducto = new ComboBox();
            cboIdProveedor = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            txtFechaCompra = new Label();
            btnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)gridCompras).BeginInit();
            SuspendLayout();
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(31, 439);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 29);
            btnModificar.TabIndex = 0;
            btnModificar.Text = "Modificar\r\n";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(150, 439);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(270, 439);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblIdCompra
            // 
            lblIdCompra.AutoSize = true;
            lblIdCompra.Location = new Point(37, 26);
            lblIdCompra.Name = "lblIdCompra";
            lblIdCompra.Size = new Size(82, 20);
            lblIdCompra.TabIndex = 3;
            lblIdCompra.Text = "Id Compra:";
            // 
            // lblIdProducto
            // 
            lblIdProducto.AutoSize = true;
            lblIdProducto.Location = new Point(37, 83);
            lblIdProducto.Name = "lblIdProducto";
            lblIdProducto.Size = new Size(89, 20);
            lblIdProducto.TabIndex = 4;
            lblIdProducto.Text = "Id Producto:";
            // 
            // lblIdProveedor
            // 
            lblIdProveedor.AutoSize = true;
            lblIdProveedor.Location = new Point(36, 143);
            lblIdProveedor.Name = "lblIdProveedor";
            lblIdProveedor.Size = new Size(97, 20);
            lblIdProveedor.TabIndex = 5;
            lblIdProveedor.Text = "Id Proveedor:";
            // 
            // lblPrecioCompra
            // 
            lblPrecioCompra.AutoSize = true;
            lblPrecioCompra.Location = new Point(37, 249);
            lblPrecioCompra.Name = "lblPrecioCompra";
            lblPrecioCompra.Size = new Size(110, 20);
            lblPrecioCompra.TabIndex = 7;
            lblPrecioCompra.Text = "Precio Compra:";
            // 
            // lblCantidadDeCompra
            // 
            lblCantidadDeCompra.AutoSize = true;
            lblCantidadDeCompra.Location = new Point(37, 307);
            lblCantidadDeCompra.Name = "lblCantidadDeCompra";
            lblCantidadDeCompra.Size = new Size(150, 20);
            lblCantidadDeCompra.TabIndex = 8;
            lblCantidadDeCompra.Text = "Cantidad de Compra:";
            // 
            // lblIdCierre
            // 
            lblIdCierre.AutoSize = true;
            lblIdCierre.Location = new Point(37, 192);
            lblIdCierre.Name = "lblIdCierre";
            lblIdCierre.Size = new Size(68, 20);
            lblIdCierre.TabIndex = 9;
            lblIdCierre.Text = "Id Cierre:";
            // 
            // txtIdCompra
            // 
            txtIdCompra.Location = new Point(125, 23);
            txtIdCompra.Name = "txtIdCompra";
            txtIdCompra.Size = new Size(125, 27);
            txtIdCompra.TabIndex = 10;
            txtIdCompra.TextChanged += txtIdCompra_TextChanged;
            // 
            // txtPrecioCompra
            // 
            txtPrecioCompra.Location = new Point(153, 246);
            txtPrecioCompra.Name = "txtPrecioCompra";
            txtPrecioCompra.Size = new Size(125, 27);
            txtPrecioCompra.TabIndex = 14;
            txtPrecioCompra.TextChanged += txtPrecioCompra_TextChanged;
            // 
            // txtCantidadDeCompra
            // 
            txtCantidadDeCompra.Location = new Point(193, 307);
            txtCantidadDeCompra.Name = "txtCantidadDeCompra";
            txtCantidadDeCompra.Size = new Size(125, 27);
            txtCantidadDeCompra.TabIndex = 15;
            txtCantidadDeCompra.TextChanged += txtCantidadDeCompra_TextChanged;
            // 
            // txtIdCierre
            // 
            txtIdCierre.Location = new Point(111, 189);
            txtIdCierre.Name = "txtIdCierre";
            txtIdCierre.Size = new Size(125, 27);
            txtIdCierre.TabIndex = 16;
            txtIdCierre.TextChanged += txtIdCierre_TextChanged;
            // 
            // txtBuscador
            // 
            txtBuscador.Location = new Point(467, 83);
            txtBuscador.Name = "txtBuscador";
            txtBuscador.Size = new Size(432, 27);
            txtBuscador.TabIndex = 17;
            txtBuscador.TextChanged += txtBuscador_TextChanged;
            // 
            // gridCompras
            // 
            gridCompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridCompras.Location = new Point(467, 155);
            gridCompras.Name = "gridCompras";
            gridCompras.RowHeadersWidth = 51;
            gridCompras.Size = new Size(432, 271);
            gridCompras.TabIndex = 18;
            gridCompras.SelectionChanged += gridCompras_SelectionChanged;
            // 
            // cboIdProducto
            // 
            cboIdProducto.FormattingEnabled = true;
            cboIdProducto.Location = new Point(144, 82);
            cboIdProducto.Name = "cboIdProducto";
            cboIdProducto.Size = new Size(151, 28);
            cboIdProducto.TabIndex = 19;
            cboIdProducto.SelectedIndexChanged += cboIdProducto_SelectedIndexChanged;
            // 
            // cboIdProveedor
            // 
            cboIdProveedor.FormattingEnabled = true;
            cboIdProveedor.Location = new Point(144, 140);
            cboIdProveedor.Name = "cboIdProveedor";
            cboIdProveedor.Size = new Size(151, 28);
            cboIdProveedor.TabIndex = 20;
            cboIdProveedor.SelectedIndexChanged += cboIdProveedor_SelectedIndexChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(171, 366);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(281, 27);
            dateTimePicker1.TabIndex = 21;
            // 
            // txtFechaCompra
            // 
            txtFechaCompra.AutoSize = true;
            txtFechaCompra.Location = new Point(37, 366);
            txtFechaCompra.Name = "txtFechaCompra";
            txtFechaCompra.Size = new Size(128, 20);
            txtFechaCompra.TabIndex = 22;
            txtFechaCompra.Text = "Fecha de Compra:";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(393, 450);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 23;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // Compras
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 509);
            Controls.Add(btnLimpiar);
            Controls.Add(txtFechaCompra);
            Controls.Add(dateTimePicker1);
            Controls.Add(cboIdProveedor);
            Controls.Add(cboIdProducto);
            Controls.Add(gridCompras);
            Controls.Add(txtBuscador);
            Controls.Add(txtIdCierre);
            Controls.Add(txtCantidadDeCompra);
            Controls.Add(txtPrecioCompra);
            Controls.Add(txtIdCompra);
            Controls.Add(lblIdCierre);
            Controls.Add(lblCantidadDeCompra);
            Controls.Add(lblPrecioCompra);
            Controls.Add(lblIdProveedor);
            Controls.Add(lblIdProducto);
            Controls.Add(lblIdCompra);
            Controls.Add(btnAgregar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Name = "Compras";
            Text = "Compras";
            Load += Compras_Load;
            ((System.ComponentModel.ISupportInitialize)gridCompras).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnModificar;
        private Button btnEliminar;
        private Button btnAgregar;
        private Label lblIdCompra;
        private Label lblIdProducto;
        private Label lblIdProveedor;
        private Label lblFechaDeCompra;
        private Label lblPrecioCompra;
        private Label lblCantidadDeCompra;
        private Label lblIdCierre;
        private TextBox txtIdCompra;
        private TextBox txtPrecioCompra;
        private TextBox txtCantidadDeCompra;
        private TextBox txtIdCierre;
        private TextBox txtBuscador;
        private DataGridView gridCompras;
        private ComboBox cboIdProducto;
        private ComboBox cboIdProveedor;
        private DateTimePicker dateTimePicker1;
        private Label txtFechaCompra;
        private Button btnLimpiar;
    }
}