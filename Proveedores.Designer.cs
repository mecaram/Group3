namespace Gestion
{
    partial class Proveedores
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
            gridProveedor = new DataGridView();
            txtBuscarProveedor = new TextBox();
            txtDireccionProveedor = new TextBox();
            txtTelefonoProveedor = new TextBox();
            txtCuitProveedor = new TextBox();
            txtRazonSocialProveedor = new TextBox();
            txtIdProveedor = new TextBox();
            btnCargarCliente = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtEliminarProveedor = new Button();
            btnModificarProveedor = new Button();
            cboCiudades = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)gridProveedor).BeginInit();
            SuspendLayout();
            // 
            // gridProveedor
            // 
            gridProveedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridProveedor.Location = new Point(273, 130);
            gridProveedor.Name = "gridProveedor";
            gridProveedor.Size = new Size(498, 230);
            gridProveedor.TabIndex = 29;
            gridProveedor.CellContentClick += gridProveedor_CellContentClick;
            // 
            // txtBuscarProveedor
            // 
            txtBuscarProveedor.Location = new Point(271, 90);
            txtBuscarProveedor.Name = "txtBuscarProveedor";
            txtBuscarProveedor.Size = new Size(500, 23);
            txtBuscarProveedor.TabIndex = 28;
            // 
            // txtDireccionProveedor
            // 
            txtDireccionProveedor.Location = new Point(92, 189);
            txtDireccionProveedor.Name = "txtDireccionProveedor";
            txtDireccionProveedor.Size = new Size(100, 23);
            txtDireccionProveedor.TabIndex = 27;
            // 
            // txtTelefonoProveedor
            // 
            txtTelefonoProveedor.Location = new Point(92, 151);
            txtTelefonoProveedor.Name = "txtTelefonoProveedor";
            txtTelefonoProveedor.Size = new Size(100, 23);
            txtTelefonoProveedor.TabIndex = 26;
            // 
            // txtCuitProveedor
            // 
            txtCuitProveedor.Location = new Point(92, 92);
            txtCuitProveedor.Name = "txtCuitProveedor";
            txtCuitProveedor.Size = new Size(100, 23);
            txtCuitProveedor.TabIndex = 24;
            // 
            // txtRazonSocialProveedor
            // 
            txtRazonSocialProveedor.Location = new Point(92, 65);
            txtRazonSocialProveedor.Name = "txtRazonSocialProveedor";
            txtRazonSocialProveedor.Size = new Size(100, 23);
            txtRazonSocialProveedor.TabIndex = 23;
            // 
            // txtIdProveedor
            // 
            txtIdProveedor.Location = new Point(92, 36);
            txtIdProveedor.Name = "txtIdProveedor";
            txtIdProveedor.Size = new Size(100, 23);
            txtIdProveedor.TabIndex = 22;
            // 
            // btnCargarCliente
            // 
            btnCargarCliente.Location = new Point(12, 315);
            btnCargarCliente.Name = "btnCargarCliente";
            btnCargarCliente.Size = new Size(75, 23);
            btnCargarCliente.TabIndex = 21;
            btnCargarCliente.Text = "Cargar";
            btnCargarCliente.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 68);
            label6.Name = "label6";
            label6.Size = new Size(73, 15);
            label6.TabIndex = 20;
            label6.Text = "Razon Social";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 96);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 19;
            label5.Text = "CUIT";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 125);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 18;
            label4.Text = "Ciudad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 156);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 17;
            label3.Text = "Telefono";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 190);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 16;
            label2.Text = "Direccion";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 39);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 15;
            label1.Text = "ID";
            // 
            // txtEliminarProveedor
            // 
            txtEliminarProveedor.Location = new Point(173, 315);
            txtEliminarProveedor.Name = "txtEliminarProveedor";
            txtEliminarProveedor.Size = new Size(75, 23);
            txtEliminarProveedor.TabIndex = 30;
            txtEliminarProveedor.Text = "Eliminar";
            txtEliminarProveedor.UseVisualStyleBackColor = true;
            // 
            // btnModificarProveedor
            // 
            btnModificarProveedor.Location = new Point(92, 315);
            btnModificarProveedor.Name = "btnModificarProveedor";
            btnModificarProveedor.Size = new Size(75, 23);
            btnModificarProveedor.TabIndex = 31;
            btnModificarProveedor.Text = "Modificar";
            btnModificarProveedor.UseVisualStyleBackColor = true;
            // 
            // cboCiudades
            // 
            cboCiudades.FormattingEnabled = true;
            cboCiudades.Location = new Point(92, 122);
            cboCiudades.Name = "cboCiudades";
            cboCiudades.Size = new Size(121, 23);
            cboCiudades.TabIndex = 32;
            // 
            // Proveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cboCiudades);
            Controls.Add(btnModificarProveedor);
            Controls.Add(txtEliminarProveedor);
            Controls.Add(gridProveedor);
            Controls.Add(txtBuscarProveedor);
            Controls.Add(txtDireccionProveedor);
            Controls.Add(txtTelefonoProveedor);
            Controls.Add(txtCuitProveedor);
            Controls.Add(txtRazonSocialProveedor);
            Controls.Add(txtIdProveedor);
            Controls.Add(btnCargarCliente);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Proveedores";
            Text = "Proveedores";
            Load += Proveedores_Load;
            ((System.ComponentModel.ISupportInitialize)gridProveedor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridProveedor;
        private TextBox txtBuscarProveedor;
        private TextBox txtDireccionProveedor;
        private TextBox txtTelefonoProveedor;
        private TextBox txtCuitProveedor;
        private TextBox txtRazonSocialProveedor;
        private TextBox txtIdProveedor;
        private Button btnCargarCliente;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button txtEliminarProveedor;
        private Button btnModificarProveedor;
        private ComboBox cboCiudades;
    }
}