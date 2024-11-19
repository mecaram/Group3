namespace Gestion
{
    partial class Ventas
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
            lblIdVenta = new Label();
            lblIdCliente = new Label();
            label3 = new Label();
            lblTotal = new Label();
            label5 = new Label();
            txtIdVenta = new TextBox();
            txtFechaDeVenta = new TextBox();
            txtTotal = new TextBox();
            txtBuscarVenta = new TextBox();
            gridVenta = new DataGridView();
            lblIdCierre = new Label();
            txtIdCierre = new TextBox();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnAgregar = new Button();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label6 = new Label();
            txtPrecioUnitario = new TextBox();
            txtCantidad = new TextBox();
            txtSubTotal = new TextBox();
            cboClientes = new ComboBox();
            cboMedioPago = new ComboBox();
            cboProductoNombre = new ComboBox();
            btnFormCliente = new Button();
            btnLimpiar = new Button();
            btnCargarVenta = new Button();
            btnCancelarVenta = new Button();
            ((System.ComponentModel.ISupportInitialize)gridVenta).BeginInit();
            SuspendLayout();
            // 
            // lblIdVenta
            // 
            lblIdVenta.AutoSize = true;
            lblIdVenta.Location = new Point(32, 9);
            lblIdVenta.Name = "lblIdVenta";
            lblIdVenta.Size = new Size(52, 15);
            lblIdVenta.TabIndex = 0;
            lblIdVenta.Text = "Id Venta:\r\n";
            // 
            // lblIdCliente
            // 
            lblIdCliente.AutoSize = true;
            lblIdCliente.Location = new Point(32, 36);
            lblIdCliente.Name = "lblIdCliente";
            lblIdCliente.Size = new Size(47, 15);
            lblIdCliente.TabIndex = 1;
            lblIdCliente.Text = "Cliente:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 68);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 2;
            label3.Text = "Fecha de Venta:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(32, 98);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(35, 15);
            lblTotal.TabIndex = 3;
            lblTotal.Text = "Total:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 125);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 4;
            label5.Text = "Medio:\r\n";
            // 
            // txtIdVenta
            // 
            txtIdVenta.Location = new Point(115, 9);
            txtIdVenta.Margin = new Padding(3, 2, 3, 2);
            txtIdVenta.Name = "txtIdVenta";
            txtIdVenta.Size = new Size(110, 23);
            txtIdVenta.TabIndex = 5;
            // 
            // txtFechaDeVenta
            // 
            txtFechaDeVenta.Location = new Point(115, 66);
            txtFechaDeVenta.Margin = new Padding(3, 2, 3, 2);
            txtFechaDeVenta.Name = "txtFechaDeVenta";
            txtFechaDeVenta.Size = new Size(110, 23);
            txtFechaDeVenta.TabIndex = 7;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(115, 98);
            txtTotal.Margin = new Padding(3, 2, 3, 2);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(110, 23);
            txtTotal.TabIndex = 8;
            // 
            // txtBuscarVenta
            // 
            txtBuscarVenta.Location = new Point(378, 68);
            txtBuscarVenta.Margin = new Padding(3, 2, 3, 2);
            txtBuscarVenta.Name = "txtBuscarVenta";
            txtBuscarVenta.Size = new Size(450, 23);
            txtBuscarVenta.TabIndex = 10;
            // 
            // gridVenta
            // 
            gridVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridVenta.Location = new Point(378, 124);
            gridVenta.Margin = new Padding(3, 2, 3, 2);
            gridVenta.Name = "gridVenta";
            gridVenta.RowHeadersWidth = 51;
            gridVenta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridVenta.Size = new Size(450, 215);
            gridVenta.TabIndex = 11;
            // 
            // lblIdCierre
            // 
            lblIdCierre.AutoSize = true;
            lblIdCierre.Location = new Point(27, 156);
            lblIdCierre.Name = "lblIdCierre";
            lblIdCierre.Size = new Size(54, 15);
            lblIdCierre.TabIndex = 12;
            lblIdCierre.Text = "Id Cierre:";
            // 
            // txtIdCierre
            // 
            txtIdCierre.Location = new Point(115, 156);
            txtIdCierre.Margin = new Padding(3, 2, 3, 2);
            txtIdCierre.Name = "txtIdCierre";
            txtIdCierre.Size = new Size(110, 23);
            txtIdCierre.TabIndex = 13;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(32, 359);
            btnModificar.Margin = new Padding(3, 2, 3, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(82, 22);
            btnModificar.TabIndex = 14;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(136, 359);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(82, 22);
            btnEliminar.TabIndex = 15;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(242, 359);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(82, 22);
            btnAgregar.TabIndex = 16;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 195);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 17;
            label1.Text = "Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 221);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 18;
            label2.Text = "Precio Unitario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 252);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 19;
            label4.Text = "Cantidad";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 284);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 20;
            label6.Text = "Subtotal";
            // 
            // txtPrecioUnitario
            // 
            txtPrecioUnitario.Location = new Point(121, 217);
            txtPrecioUnitario.Name = "txtPrecioUnitario";
            txtPrecioUnitario.Size = new Size(100, 23);
            txtPrecioUnitario.TabIndex = 25;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(121, 247);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 26;
            txtCantidad.TextChanged += txtCantidad_TextChanged;
            // 
            // txtSubTotal
            // 
            txtSubTotal.Location = new Point(125, 280);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.Size = new Size(100, 23);
            txtSubTotal.TabIndex = 27;
            // 
            // cboClientes
            // 
            cboClientes.FormattingEnabled = true;
            cboClientes.Location = new Point(115, 38);
            cboClientes.Name = "cboClientes";
            cboClientes.Size = new Size(121, 23);
            cboClientes.TabIndex = 28;
            // 
            // cboMedioPago
            // 
            cboMedioPago.FormattingEnabled = true;
            cboMedioPago.Location = new Point(114, 127);
            cboMedioPago.Name = "cboMedioPago";
            cboMedioPago.Size = new Size(121, 23);
            cboMedioPago.TabIndex = 29;
            // 
            // cboProductoNombre
            // 
            cboProductoNombre.FormattingEnabled = true;
            cboProductoNombre.Location = new Point(121, 189);
            cboProductoNombre.Name = "cboProductoNombre";
            cboProductoNombre.Size = new Size(121, 23);
            cboProductoNombre.TabIndex = 30;
            cboProductoNombre.SelectedIndexChanged += cboProductoNombre_SelectedIndexChanged;
            // 
            // btnFormCliente
            // 
            btnFormCliente.Location = new Point(242, 38);
            btnFormCliente.Margin = new Padding(3, 2, 3, 2);
            btnFormCliente.Name = "btnFormCliente";
            btnFormCliente.Size = new Size(25, 22);
            btnFormCliente.TabIndex = 31;
            btnFormCliente.Text = "...";
            btnFormCliente.UseVisualStyleBackColor = true;
            btnFormCliente.Click += btnFormCliente_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(258, 324);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 32;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCargarVenta
            // 
            btnCargarVenta.Location = new Point(403, 359);
            btnCargarVenta.Name = "btnCargarVenta";
            btnCargarVenta.Size = new Size(75, 23);
            btnCargarVenta.TabIndex = 33;
            btnCargarVenta.Text = "CARGAR";
            btnCargarVenta.UseVisualStyleBackColor = true;
            btnCargarVenta.Click += btnCargarVenta_Click;
            // 
            // btnCancelarVenta
            // 
            btnCancelarVenta.Location = new Point(493, 359);
            btnCancelarVenta.Name = "btnCancelarVenta";
            btnCancelarVenta.Size = new Size(75, 23);
            btnCancelarVenta.TabIndex = 34;
            btnCancelarVenta.Text = "CANCELAR";
            btnCancelarVenta.UseVisualStyleBackColor = true;
            btnCancelarVenta.Click += btnCancelarVenta_Click;
            // 
            // Ventas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 406);
            Controls.Add(btnCancelarVenta);
            Controls.Add(btnCargarVenta);
            Controls.Add(btnLimpiar);
            Controls.Add(btnFormCliente);
            Controls.Add(cboProductoNombre);
            Controls.Add(cboMedioPago);
            Controls.Add(cboClientes);
            Controls.Add(txtSubTotal);
            Controls.Add(txtCantidad);
            Controls.Add(txtPrecioUnitario);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAgregar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(txtIdCierre);
            Controls.Add(lblIdCierre);
            Controls.Add(gridVenta);
            Controls.Add(txtBuscarVenta);
            Controls.Add(txtTotal);
            Controls.Add(txtFechaDeVenta);
            Controls.Add(txtIdVenta);
            Controls.Add(label5);
            Controls.Add(lblTotal);
            Controls.Add(label3);
            Controls.Add(lblIdCliente);
            Controls.Add(lblIdVenta);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Ventas";
            Text = "Ventas";
            Load += Ventas_Load;
            ((System.ComponentModel.ISupportInitialize)gridVenta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIdVenta;
        private Label lblIdCliente;
        private Label label3;
        private Label lblTotal;
        private Label label5;
        private TextBox txtIdVenta;
        private TextBox txtFechaDeVenta;
        private TextBox txtTotal;
        private TextBox txtBuscarVenta;
        private DataGridView gridVenta;
        private Label lblIdCierre;
        private TextBox txtIdCierre;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnAgregar;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label6;
        private TextBox txtPrecioUnitario;
        private TextBox txtCantidad;
        private TextBox txtSubTotal;
        private ComboBox cboClientes;
        private ComboBox cboMedioPago;
        private ComboBox cboProductoNombre;
        private Button btnFormCliente;
        private Button btnLimpiar;
        private Button btnCargarVenta;
        private Button btnCancelarVenta;
    }
}