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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
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
            btnModificar.BackColor = Color.Silver;
            btnModificar.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificar.Location = new Point(31, 439);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 29);
            btnModificar.TabIndex = 0;
            btnModificar.Text = "Modificar\r\n";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Silver;
            btnEliminar.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(150, 439);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.Silver;
            btnAgregar.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(270, 439);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblIdCompra
            // 
            lblIdCompra.AutoSize = true;
            lblIdCompra.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIdCompra.Location = new Point(119, 38);
            lblIdCompra.Name = "lblIdCompra";
            lblIdCompra.Size = new Size(79, 18);
            lblIdCompra.TabIndex = 3;
            lblIdCompra.Text = "Id Compra:";
            // 
            // lblIdProducto
            // 
            lblIdProducto.AutoSize = true;
            lblIdProducto.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIdProducto.Location = new Point(112, 86);
            lblIdProducto.Name = "lblIdProducto";
            lblIdProducto.Size = new Size(86, 18);
            lblIdProducto.TabIndex = 4;
            lblIdProducto.Text = "Id Producto:";
            // 
            // lblIdProveedor
            // 
            lblIdProveedor.AutoSize = true;
            lblIdProveedor.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIdProveedor.Location = new Point(104, 137);
            lblIdProveedor.Name = "lblIdProveedor";
            lblIdProveedor.Size = new Size(95, 18);
            lblIdProveedor.TabIndex = 5;
            lblIdProveedor.Text = "Id Proveedor:";
            // 
            // lblPrecioCompra
            // 
            lblPrecioCompra.AutoSize = true;
            lblPrecioCompra.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrecioCompra.Location = new Point(91, 239);
            lblPrecioCompra.Name = "lblPrecioCompra";
            lblPrecioCompra.Size = new Size(109, 18);
            lblPrecioCompra.TabIndex = 7;
            lblPrecioCompra.Text = "Precio Compra:";
            // 
            // lblCantidadDeCompra
            // 
            lblCantidadDeCompra.AutoSize = true;
            lblCantidadDeCompra.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCantidadDeCompra.Location = new Point(51, 293);
            lblCantidadDeCompra.Name = "lblCantidadDeCompra";
            lblCantidadDeCompra.Size = new Size(145, 18);
            lblCantidadDeCompra.TabIndex = 8;
            lblCantidadDeCompra.Text = "Cantidad de Compra:";
            // 
            // lblIdCierre
            // 
            lblIdCierre.AutoSize = true;
            lblIdCierre.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIdCierre.Location = new Point(133, 191);
            lblIdCierre.Name = "lblIdCierre";
            lblIdCierre.Size = new Size(68, 18);
            lblIdCierre.TabIndex = 9;
            lblIdCierre.Text = "Id Cierre:";
            // 
            // txtIdCompra
            // 
            txtIdCompra.BackColor = Color.Silver;
            txtIdCompra.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtIdCompra.Location = new Point(213, 35);
            txtIdCompra.Name = "txtIdCompra";
            txtIdCompra.Size = new Size(125, 26);
            txtIdCompra.TabIndex = 10;
            txtIdCompra.TextChanged += txtIdCompra_TextChanged;
            // 
            // txtPrecioCompra
            // 
            txtPrecioCompra.BackColor = Color.Silver;
            txtPrecioCompra.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPrecioCompra.Location = new Point(213, 239);
            txtPrecioCompra.Name = "txtPrecioCompra";
            txtPrecioCompra.Size = new Size(125, 26);
            txtPrecioCompra.TabIndex = 14;
            txtPrecioCompra.TextChanged += txtPrecioCompra_TextChanged;
            // 
            // txtCantidadDeCompra
            // 
            txtCantidadDeCompra.BackColor = Color.Silver;
            txtCantidadDeCompra.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCantidadDeCompra.Location = new Point(213, 293);
            txtCantidadDeCompra.Name = "txtCantidadDeCompra";
            txtCantidadDeCompra.Size = new Size(125, 26);
            txtCantidadDeCompra.TabIndex = 15;
            txtCantidadDeCompra.TextChanged += txtCantidadDeCompra_TextChanged;
            // 
            // txtIdCierre
            // 
            txtIdCierre.BackColor = Color.Silver;
            txtIdCierre.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtIdCierre.ForeColor = Color.Black;
            txtIdCierre.Location = new Point(213, 188);
            txtIdCierre.Name = "txtIdCierre";
            txtIdCierre.Size = new Size(125, 26);
            txtIdCierre.TabIndex = 16;
            txtIdCierre.TextChanged += txtIdCierre_TextChanged;
            // 
            // txtBuscador
            // 
            txtBuscador.BackColor = Color.Silver;
            txtBuscador.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBuscador.ForeColor = Color.Black;
            txtBuscador.Location = new Point(467, 59);
            txtBuscador.Name = "txtBuscador";
            txtBuscador.Size = new Size(432, 26);
            txtBuscador.TabIndex = 17;
            txtBuscador.TextChanged += txtBuscador_TextChanged;
            // 
            // gridCompras
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            gridCompras.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            gridCompras.BackgroundColor = SystemColors.ScrollBar;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Bahnschrift SemiBold SemiConden", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            gridCompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            gridCompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            gridCompras.DefaultCellStyle = dataGridViewCellStyle3;
            gridCompras.GridColor = Color.Gray;
            gridCompras.Location = new Point(467, 115);
            gridCompras.Name = "gridCompras";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            gridCompras.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            gridCompras.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            gridCompras.RowsDefaultCellStyle = dataGridViewCellStyle5;
            gridCompras.Size = new Size(432, 271);
            gridCompras.TabIndex = 18;
            gridCompras.SelectionChanged += gridCompras_SelectionChanged;
            // 
            // cboIdProducto
            // 
            cboIdProducto.BackColor = Color.Silver;
            cboIdProducto.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cboIdProducto.ForeColor = Color.Black;
            cboIdProducto.FormattingEnabled = true;
            cboIdProducto.Location = new Point(213, 83);
            cboIdProducto.Name = "cboIdProducto";
            cboIdProducto.Size = new Size(151, 26);
            cboIdProducto.TabIndex = 19;
            cboIdProducto.SelectedIndexChanged += cboIdProducto_SelectedIndexChanged;
            // 
            // cboIdProveedor
            // 
            cboIdProveedor.BackColor = Color.Silver;
            cboIdProveedor.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cboIdProveedor.ForeColor = Color.Black;
            cboIdProveedor.FormattingEnabled = true;
            cboIdProveedor.Location = new Point(213, 134);
            cboIdProveedor.Name = "cboIdProveedor";
            cboIdProveedor.Size = new Size(151, 26);
            cboIdProveedor.TabIndex = 20;
            cboIdProveedor.SelectedIndexChanged += cboIdProveedor_SelectedIndexChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.AccessibleRole = AccessibleRole.ScrollBar;
            dateTimePicker1.CalendarFont = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker1.CalendarForeColor = Color.Black;
            dateTimePicker1.CalendarMonthBackground = SystemColors.Control;
            dateTimePicker1.CalendarTitleForeColor = Color.Black;
            dateTimePicker1.CalendarTrailingForeColor = Color.Black;
            dateTimePicker1.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(156, 366);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(281, 26);
            dateTimePicker1.TabIndex = 21;
            // 
            // txtFechaCompra
            // 
            txtFechaCompra.AutoSize = true;
            txtFechaCompra.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFechaCompra.Location = new Point(22, 366);
            txtFechaCompra.Name = "txtFechaCompra";
            txtFechaCompra.Size = new Size(126, 18);
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
            BackColor = SystemColors.ControlDarkDark;
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