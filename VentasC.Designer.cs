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
            btnVentas = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 13);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "Fecha Inicio";
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Format = DateTimePickerFormat.Short;
            dtpFechaInicio.Location = new Point(14, 40);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(84, 23);
            dtpFechaInicio.TabIndex = 1;
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Format = DateTimePickerFormat.Short;
            dtpFechaFin.Location = new Point(114, 41);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(83, 23);
            dtpFechaFin.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(124, 12);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Fecha Fin";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(232, 43);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(326, 44);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnComprobante
            // 
            btnComprobante.Location = new Point(417, 44);
            btnComprobante.Name = "btnComprobante";
            btnComprobante.Size = new Size(95, 23);
            btnComprobante.TabIndex = 6;
            btnComprobante.Text = "Comprobante";
            btnComprobante.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(536, 44);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(75, 23);
            btnImprimir.TabIndex = 7;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            // 
            // chkEliminar
            // 
            chkEliminar.AutoSize = true;
            chkEliminar.Location = new Point(18, 120);
            chkEliminar.Name = "chkEliminar";
            chkEliminar.Size = new Size(69, 19);
            chkEliminar.TabIndex = 8;
            chkEliminar.Text = "Eliminar";
            chkEliminar.UseVisualStyleBackColor = true;
            // 
            // dgvVentas
            // 
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Location = new Point(15, 150);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.Size = new Size(813, 260);
            dgvVentas.TabIndex = 9;
            // 
            // lblTotalRegistros
            // 
            lblTotalRegistros.AutoSize = true;
            lblTotalRegistros.Location = new Point(627, 120);
            lblTotalRegistros.Name = "lblTotalRegistros";
            lblTotalRegistros.Size = new Size(94, 15);
            lblTotalRegistros.TabIndex = 10;
            lblTotalRegistros.Text = "Total Articulos: 0";
            // 
            // cboClientes
            // 
            cboClientes.DropDownStyle = ComboBoxStyle.DropDownList;
            cboClientes.Location = new Point(70, 77);
            cboClientes.Name = "cboClientes";
            cboClientes.Size = new Size(150, 23);
            cboClientes.TabIndex = 12;
            // 
            // cboMedioPago
            // 
            cboMedioPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMedioPago.Location = new Point(340, 77);
            cboMedioPago.Name = "cboMedioPago";
            cboMedioPago.Size = new Size(150, 23);
            cboMedioPago.TabIndex = 14;
            // 
            // labelCliente
            // 
            labelCliente.AutoSize = true;
            labelCliente.Location = new Point(17, 80);
            labelCliente.Name = "labelCliente";
            labelCliente.Size = new Size(44, 15);
            labelCliente.TabIndex = 11;
            labelCliente.Text = "Cliente";
            // 
            // labelMedioPago
            // 
            labelMedioPago.AutoSize = true;
            labelMedioPago.Location = new Point(250, 80);
            labelMedioPago.Name = "labelMedioPago";
            labelMedioPago.Size = new Size(87, 15);
            labelMedioPago.TabIndex = 13;
            labelMedioPago.Text = "Medio de Pago";
            // 
            // btnVentas
            // 
            btnVentas.Location = new Point(692, 51);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(75, 23);
            btnVentas.TabIndex = 15;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click;
            // 
            // VentasC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(840, 450);
            Controls.Add(btnVentas);
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
        private Button btnVentas;
    }
}
