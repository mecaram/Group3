namespace Gestion
{
    partial class DetallesDeVentas
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
            btngAgregar = new Button();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            lblIdVenta = new Label();
            lblIdProducto = new Label();
            lblPrecioUnitario = new Label();
            lblCantidad = new Label();
            lblSubTotal = new Label();
            txtIdVenta = new TextBox();
            txtIdProducto = new TextBox();
            txtPrecioUnitario = new TextBox();
            txtCantidad = new TextBox();
            txtSubTotal = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(31, 406);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 29);
            btnModificar.TabIndex = 0;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(136, 406);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btngAgregar
            // 
            btngAgregar.Location = new Point(236, 406);
            btngAgregar.Name = "btngAgregar";
            btngAgregar.Size = new Size(94, 29);
            btngAgregar.TabIndex = 2;
            btngAgregar.Text = "Agregar";
            btngAgregar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(394, 113);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(511, 276);
            dataGridView1.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(394, 51);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(511, 27);
            textBox1.TabIndex = 4;
            // 
            // lblIdVenta
            // 
            lblIdVenta.AutoSize = true;
            lblIdVenta.Location = new Point(37, 69);
            lblIdVenta.Name = "lblIdVenta";
            lblIdVenta.Size = new Size(66, 20);
            lblIdVenta.TabIndex = 5;
            lblIdVenta.Text = "Id Venta:";
            // 
            // lblIdProducto
            // 
            lblIdProducto.AutoSize = true;
            lblIdProducto.Location = new Point(37, 136);
            lblIdProducto.Name = "lblIdProducto";
            lblIdProducto.Size = new Size(89, 20);
            lblIdProducto.TabIndex = 6;
            lblIdProducto.Text = "Id Producto:";
            // 
            // lblPrecioUnitario
            // 
            lblPrecioUnitario.AutoSize = true;
            lblPrecioUnitario.Location = new Point(37, 200);
            lblPrecioUnitario.Name = "lblPrecioUnitario";
            lblPrecioUnitario.Size = new Size(110, 20);
            lblPrecioUnitario.TabIndex = 7;
            lblPrecioUnitario.Text = "Precio Unitario:";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(36, 260);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(72, 20);
            lblCantidad.TabIndex = 8;
            lblCantidad.Text = "Cantidad:";
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.Location = new Point(36, 325);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(71, 20);
            lblSubTotal.TabIndex = 9;
            lblSubTotal.Text = "SubTotal ";
            // 
            // txtIdVenta
            // 
            txtIdVenta.Location = new Point(109, 62);
            txtIdVenta.Name = "txtIdVenta";
            txtIdVenta.Size = new Size(125, 27);
            txtIdVenta.TabIndex = 10;
            // 
            // txtIdProducto
            // 
            txtIdProducto.Location = new Point(132, 129);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(125, 27);
            txtIdProducto.TabIndex = 11;
            // 
            // txtPrecioUnitario
            // 
            txtPrecioUnitario.Location = new Point(153, 193);
            txtPrecioUnitario.Name = "txtPrecioUnitario";
            txtPrecioUnitario.Size = new Size(125, 27);
            txtPrecioUnitario.TabIndex = 12;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(114, 260);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(125, 27);
            txtCantidad.TabIndex = 13;
            // 
            // txtSubTotal
            // 
            txtSubTotal.Location = new Point(114, 318);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.Size = new Size(125, 27);
            txtSubTotal.TabIndex = 14;
            // 
            // DetallesDeVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 468);
            Controls.Add(txtSubTotal);
            Controls.Add(txtCantidad);
            Controls.Add(txtPrecioUnitario);
            Controls.Add(txtIdProducto);
            Controls.Add(txtIdVenta);
            Controls.Add(lblSubTotal);
            Controls.Add(lblCantidad);
            Controls.Add(lblPrecioUnitario);
            Controls.Add(lblIdProducto);
            Controls.Add(lblIdVenta);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(btngAgregar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Name = "DetallesDeVentas";
            Text = "DetallesDeVentas";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnModificar;
        private Button btnEliminar;
        private Button btngAgregar;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Label lblIdVenta;
        private Label lblIdProducto;
        private Label lblPrecioUnitario;
        private Label lblCantidad;
        private Label lblSubTotal;
        private TextBox txtIdVenta;
        private TextBox txtIdProducto;
        private TextBox txtPrecioUnitario;
        private TextBox txtCantidad;
        private TextBox txtSubTotal;
    }
}