namespace Gestion
{
    partial class VentasC
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            dtpFechaInicio = new DateTimePicker();
            dtpFechaFin = new DateTimePicker();
            label2 = new Label();
            btnBuscar = new Button();
            btnEliminar = new Button();
            btnComprobante = new Button();
            btnImprimir = new Button();
            chkEliminar = new CheckBox();
            dgvVentas = new DataGridView();
            lblTotalRegistros = new Label();
            cboClientes = new ComboBox();
            cboMedioPago = new ComboBox();
            labelCliente = new Label();
            labelMedioPago = new Label();

            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            SuspendLayout();

            // Label Fecha Inicio
            label1.AutoSize = true;
            label1.Location = new Point(17, 13);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "Fecha Inicio";

            // DateTimePicker Fecha Inicio
            dtpFechaInicio.Format = DateTimePickerFormat.Short;
            dtpFechaInicio.Location = new Point(14, 40);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(84, 23);
            dtpFechaInicio.TabIndex = 1;

            // DateTimePicker Fecha Fin
            dtpFechaFin.Format = DateTimePickerFormat.Short;
            dtpFechaFin.Location = new Point(114, 41);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(83, 23);
            dtpFechaFin.TabIndex = 2;

            // Label Fecha Fin
            label2.AutoSize = true;
            label2.Location = new Point(124, 12);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Fecha Fin";

            // ComboBox Clientes
            labelCliente.AutoSize = true;
            labelCliente.Location = new Point(17, 80);
            labelCliente.Name = "labelCliente";
            labelCliente.Size = new Size(47, 15);
            labelCliente.TabIndex = 11;
            labelCliente.Text = "Cliente";

            cboClientes.Location = new Point(70, 77);
            cboClientes.Name = "cboClientes";
            cboClientes.Size = new Size(150, 23);
            cboClientes.TabIndex = 12;

            // ComboBox Medio de Pago
            labelMedioPago.AutoSize = true;
            labelMedioPago.Location = new Point(250, 80);
            labelMedioPago.Name = "labelMedioPago";
            labelMedioPago.Size = new Size(82, 15);
            labelMedioPago.TabIndex = 13;
            labelMedioPago.Text = "Medio de Pago";

            cboMedioPago.Location = new Point(340, 77);
            cboMedioPago.Name = "cboMedioPago";
            cboMedioPago.Size = new Size(150, 23);
            cboMedioPago.TabIndex = 14;

            // Botón Buscar
            btnBuscar.Location = new Point(232, 43);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;

            // Botón Eliminar
            btnEliminar.Location = new Point(326, 44);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;

            // Botón Comprobante
            btnComprobante.Location = new Point(417, 44);
            btnComprobante.Name = "btnComprobante";
            btnComprobante.Size = new Size(95, 23);
            btnComprobante.TabIndex = 6;
            btnComprobante.Text = "Comprobante";
            btnComprobante.UseVisualStyleBackColor = true;

            // Botón Imprimir
            btnImprimir.Location = new Point(536, 44);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(75, 23);
            btnImprimir.TabIndex = 7;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;

            // CheckBox Eliminar
            chkEliminar.AutoSize = true;
            chkEliminar.Location = new Point(18, 120);
            chkEliminar.Name = "chkEliminar";
            chkEliminar.Size = new Size(69, 19);
            chkEliminar.TabIndex = 8;
            chkEliminar.Text = "Eliminar";
            chkEliminar.UseVisualStyleBackColor = true;

            // DataGridView Ventas
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Location = new Point(15, 150);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.Size = new Size(773, 260);
            dgvVentas.TabIndex = 9;

            // Label Total Registros
            lblTotalRegistros.AutoSize = true;
            lblTotalRegistros.Location = new Point(627, 120);
            lblTotalRegistros.Name = "lblTotalRegistros";
            lblTotalRegistros.Size = new Size(94, 15);
            lblTotalRegistros.TabIndex = 10;
            lblTotalRegistros.Text = "Total Articulos: 0";

            // VentasC Form
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTotalRegistros);
            Controls.Add(dgvVentas);
            Controls.Add(chkEliminar);
            Controls.Add(btnImprimir);
            Controls.Add(btnComprobante);
            Controls.Add(btnEliminar);
            Controls.Add(btnBuscar);
            Controls.Add(label2);
            Controls.Add(dtpFechaFin);
            Controls.Add(dtpFechaInicio);
            Controls.Add(label1);
            Controls.Add(labelCliente);
            Controls.Add(cboClientes);
            Controls.Add(labelMedioPago);
            Controls.Add(cboMedioPago);
            Name = "VentasC";
            Text = "VentasC";
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dtpFechaInicio;
        private DateTimePicker dtpFechaFin;
        private Label label2;
        private Button btnBuscar;
        private Button btnEliminar;
        private Button btnComprobante;
        private Button btnImprimir;
        private CheckBox chkEliminar;
        private DataGridView dgvVentas;
        private Label lblTotalRegistros;
        private ComboBox cboClientes;
        private ComboBox cboMedioPago;
        private Label labelCliente;
        private Label labelMedioPago;
    }
}
