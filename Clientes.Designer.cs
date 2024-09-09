namespace Gestion
{
    partial class Clientes
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnCargarCliente = new Button();
            txtIdCliente = new TextBox();
            txtNombreCliente = new TextBox();
            txtApellidoCliente = new TextBox();
            txtDniCliente = new TextBox();
            txtDireccionCliente = new TextBox();
            txtBuscarCliente = new TextBox();
            gridCliente = new DataGridView();
            btnModificarCliente = new Button();
            btnEliminarCliente = new Button();
            cboCiudadCliente = new ComboBox();
            btnAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)gridCliente).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 31);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 182);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Direccion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 148);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 2;
            label3.Text = "Ciudad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 117);
            label4.Name = "label4";
            label4.Size = new Size(27, 15);
            label4.TabIndex = 3;
            label4.Text = "DNI";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 88);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 4;
            label5.Text = "Apellido";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 61);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 5;
            label6.Text = "Nombre";
            // 
            // btnCargarCliente
            // 
            btnCargarCliente.Location = new Point(11, 234);
            btnCargarCliente.Name = "btnCargarCliente";
            btnCargarCliente.Size = new Size(75, 23);
            btnCargarCliente.TabIndex = 6;
            btnCargarCliente.Text = "Cargar";
            btnCargarCliente.UseVisualStyleBackColor = true;
            btnCargarCliente.Click += btnCargarCliente_Click;
            // 
            // txtIdCliente
            // 
            txtIdCliente.Location = new Point(74, 28);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(100, 23);
            txtIdCliente.TabIndex = 7;
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(74, 57);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(100, 23);
            txtNombreCliente.TabIndex = 8;
            // 
            // txtApellidoCliente
            // 
            txtApellidoCliente.Location = new Point(74, 84);
            txtApellidoCliente.Name = "txtApellidoCliente";
            txtApellidoCliente.Size = new Size(100, 23);
            txtApellidoCliente.TabIndex = 9;
            // 
            // txtDniCliente
            // 
            txtDniCliente.Location = new Point(74, 112);
            txtDniCliente.Name = "txtDniCliente";
            txtDniCliente.Size = new Size(100, 23);
            txtDniCliente.TabIndex = 10;
            // 
            // txtDireccionCliente
            // 
            txtDireccionCliente.Location = new Point(74, 181);
            txtDireccionCliente.Name = "txtDireccionCliente";
            txtDireccionCliente.Size = new Size(100, 23);
            txtDireccionCliente.TabIndex = 12;
            // 
            // txtBuscarCliente
            // 
            txtBuscarCliente.Location = new Point(255, 12);
            txtBuscarCliente.Name = "txtBuscarCliente";
            txtBuscarCliente.Size = new Size(498, 23);
            txtBuscarCliente.TabIndex = 13;
            txtBuscarCliente.TextChanged += txtBuscarCliente_TextChanged;
            // 
            // gridCliente
            // 
            gridCliente.AllowUserToAddRows = false;
            gridCliente.AllowUserToDeleteRows = false;
            gridCliente.AllowUserToOrderColumns = true;
            gridCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridCliente.Location = new Point(255, 49);
            gridCliente.Name = "gridCliente";
            gridCliente.ReadOnly = true;
            gridCliente.RowHeadersWidth = 51;
            gridCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridCliente.Size = new Size(613, 230);
            gridCliente.TabIndex = 14;
            gridCliente.SelectionChanged += gridCliente_SelectionChanged;
            // 
            // btnModificarCliente
            // 
            btnModificarCliente.Location = new Point(93, 235);
            btnModificarCliente.Name = "btnModificarCliente";
            btnModificarCliente.Size = new Size(75, 23);
            btnModificarCliente.TabIndex = 15;
            btnModificarCliente.Text = "Modificar";
            btnModificarCliente.UseVisualStyleBackColor = true;
            btnModificarCliente.Click += btnModificarCliente_Click;
            // 
            // btnEliminarCliente
            // 
            btnEliminarCliente.Location = new Point(174, 235);
            btnEliminarCliente.Name = "btnEliminarCliente";
            btnEliminarCliente.Size = new Size(75, 23);
            btnEliminarCliente.TabIndex = 16;
            btnEliminarCliente.Text = "Eliminar";
            btnEliminarCliente.UseVisualStyleBackColor = true;
            btnEliminarCliente.Click += btnEliminarCliente_Click;
            // 
            // cboCiudadCliente
            // 
            cboCiudadCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCiudadCliente.FormattingEnabled = true;
            cboCiudadCliente.Location = new Point(76, 146);
            cboCiudadCliente.Name = "cboCiudadCliente";
            cboCiudadCliente.Size = new Size(98, 23);
            cboCiudadCliente.TabIndex = 17;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(93, 274);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 18;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(987, 450);
            Controls.Add(btnAgregar);
            Controls.Add(cboCiudadCliente);
            Controls.Add(btnEliminarCliente);
            Controls.Add(btnModificarCliente);
            Controls.Add(gridCliente);
            Controls.Add(txtBuscarCliente);
            Controls.Add(txtDireccionCliente);
            Controls.Add(txtDniCliente);
            Controls.Add(txtApellidoCliente);
            Controls.Add(txtNombreCliente);
            Controls.Add(txtIdCliente);
            Controls.Add(btnCargarCliente);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Clientes";
            Text = "Clientes";
            Load += Clientes_Load;
            ((System.ComponentModel.ISupportInitialize)gridCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnCargarCliente;
        private TextBox txtIdCliente;
        private TextBox txtNombreCliente;
        private TextBox txtApellidoCliente;
        private TextBox txtDniCliente;
        private TextBox txtDireccionCliente;
        private TextBox txtBuscarCliente;
        private DataGridView gridCliente;
        private Button btnModificarCliente;
        private Button btnEliminarCliente;
        private ComboBox cboCiudadCliente;
        private Button btnAgregar;
    }
}