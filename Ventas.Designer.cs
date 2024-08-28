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
            txtIdCliente = new TextBox();
            txtFechaDeVenta = new TextBox();
            txtTotal = new TextBox();
            txtIdMedio = new TextBox();
            textBox6 = new TextBox();
            dataGridView1 = new DataGridView();
            lblIdCierre = new Label();
            txtIdCierre = new TextBox();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblIdVenta
            // 
            lblIdVenta.AutoSize = true;
            lblIdVenta.Location = new Point(34, 57);
            lblIdVenta.Name = "lblIdVenta";
            lblIdVenta.Size = new Size(66, 20);
            lblIdVenta.TabIndex = 0;
            lblIdVenta.Text = "Id Venta:\r\n";
            // 
            // lblIdCliente
            // 
            lblIdCliente.AutoSize = true;
            lblIdCliente.Location = new Point(37, 135);
            lblIdCliente.Name = "lblIdCliente";
            lblIdCliente.Size = new Size(75, 20);
            lblIdCliente.TabIndex = 1;
            lblIdCliente.Text = "Id Cliente:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 203);
            label3.Name = "label3";
            label3.Size = new Size(112, 20);
            label3.TabIndex = 2;
            label3.Text = "Fecha de Venta:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(37, 273);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(45, 20);
            lblTotal.TabIndex = 3;
            lblTotal.Text = "Total:";
            lblTotal.Click += lblTotal_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 331);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 4;
            label5.Text = "Id Medio:\r\n";
            // 
            // txtIdVenta
            // 
            txtIdVenta.Location = new Point(131, 57);
            txtIdVenta.Name = "txtIdVenta";
            txtIdVenta.Size = new Size(125, 27);
            txtIdVenta.TabIndex = 5;
            // 
            // txtIdCliente
            // 
            txtIdCliente.Location = new Point(131, 132);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(125, 27);
            txtIdCliente.TabIndex = 6;
            // 
            // txtFechaDeVenta
            // 
            txtFechaDeVenta.Location = new Point(177, 196);
            txtFechaDeVenta.Name = "txtFechaDeVenta";
            txtFechaDeVenta.Size = new Size(125, 27);
            txtFechaDeVenta.TabIndex = 7;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(131, 270);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(125, 27);
            txtTotal.TabIndex = 8;
            // 
            // txtIdMedio
            // 
            txtIdMedio.Location = new Point(131, 328);
            txtIdMedio.Name = "txtIdMedio";
            txtIdMedio.Size = new Size(125, 27);
            txtIdMedio.TabIndex = 9;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(432, 90);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(514, 27);
            textBox6.TabIndex = 10;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(432, 167);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(514, 287);
            dataGridView1.TabIndex = 11;
            // 
            // lblIdCierre
            // 
            lblIdCierre.AutoSize = true;
            lblIdCierre.Location = new Point(37, 397);
            lblIdCierre.Name = "lblIdCierre";
            lblIdCierre.Size = new Size(68, 20);
            lblIdCierre.TabIndex = 12;
            lblIdCierre.Text = "Id Cierre:";
            // 
            // txtIdCierre
            // 
            txtIdCierre.Location = new Point(131, 394);
            txtIdCierre.Name = "txtIdCierre";
            txtIdCierre.Size = new Size(125, 27);
            txtIdCierre.TabIndex = 13;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(37, 479);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 29);
            btnModificar.TabIndex = 14;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(155, 479);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 15;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(277, 479);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 16;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // Ventas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 542);
            Controls.Add(btnAgregar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(txtIdCierre);
            Controls.Add(lblIdCierre);
            Controls.Add(dataGridView1);
            Controls.Add(textBox6);
            Controls.Add(txtIdMedio);
            Controls.Add(txtTotal);
            Controls.Add(txtFechaDeVenta);
            Controls.Add(txtIdCliente);
            Controls.Add(txtIdVenta);
            Controls.Add(label5);
            Controls.Add(lblTotal);
            Controls.Add(label3);
            Controls.Add(lblIdCliente);
            Controls.Add(lblIdVenta);
            Name = "Ventas";
            Text = "Ventas";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private TextBox txtIdCliente;
        private TextBox txtFechaDeVenta;
        private TextBox txtTotal;
        private TextBox txtIdMedio;
        private TextBox textBox6;
        private DataGridView dataGridView1;
        private Label lblIdCierre;
        private TextBox txtIdCierre;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnAgregar;
    }
}