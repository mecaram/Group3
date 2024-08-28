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
            txtCiudadCliente = new TextBox();
            txtDireccionCliente = new TextBox();
            txtBuscarCliente = new TextBox();
            gridCliente = new DataGridView();
            btnModificarCliente = new Button();
            btnEliminarCliente = new Button();
            ((System.ComponentModel.ISupportInitialize)gridCliente).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 41);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 243);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 1;
            label2.Text = "Direccion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 197);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 2;
            label3.Text = "Ciudad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 156);
            label4.Name = "label4";
            label4.Size = new Size(35, 20);
            label4.TabIndex = 3;
            label4.Text = "DNI";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 117);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 4;
            label5.Text = "Apellido";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 81);
            label6.Name = "label6";
            label6.Size = new Size(64, 20);
            label6.TabIndex = 5;
            label6.Text = "Nombre";
            // 
            // btnCargarCliente
            // 
            btnCargarCliente.Location = new Point(13, 312);
            btnCargarCliente.Margin = new Padding(3, 4, 3, 4);
            btnCargarCliente.Name = "btnCargarCliente";
            btnCargarCliente.Size = new Size(86, 31);
            btnCargarCliente.TabIndex = 6;
            btnCargarCliente.Text = "Cargar";
            btnCargarCliente.UseVisualStyleBackColor = true;
            // 
            // txtIdCliente
            // 
            txtIdCliente.Location = new Point(85, 37);
            txtIdCliente.Margin = new Padding(3, 4, 3, 4);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(114, 27);
            txtIdCliente.TabIndex = 7;
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(85, 76);
            txtNombreCliente.Margin = new Padding(3, 4, 3, 4);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(114, 27);
            txtNombreCliente.TabIndex = 8;
            // 
            // txtApellidoCliente
            // 
            txtApellidoCliente.Location = new Point(85, 112);
            txtApellidoCliente.Margin = new Padding(3, 4, 3, 4);
            txtApellidoCliente.Name = "txtApellidoCliente";
            txtApellidoCliente.Size = new Size(114, 27);
            txtApellidoCliente.TabIndex = 9;
            // 
            // txtDniCliente
            // 
            txtDniCliente.Location = new Point(85, 149);
            txtDniCliente.Margin = new Padding(3, 4, 3, 4);
            txtDniCliente.Name = "txtDniCliente";
            txtDniCliente.Size = new Size(114, 27);
            txtDniCliente.TabIndex = 10;
            // 
            // txtCiudadCliente
            // 
            txtCiudadCliente.Location = new Point(85, 191);
            txtCiudadCliente.Margin = new Padding(3, 4, 3, 4);
            txtCiudadCliente.Name = "txtCiudadCliente";
            txtCiudadCliente.Size = new Size(114, 27);
            txtCiudadCliente.TabIndex = 11;
            // 
            // txtDireccionCliente
            // 
            txtDireccionCliente.Location = new Point(85, 241);
            txtDireccionCliente.Margin = new Padding(3, 4, 3, 4);
            txtDireccionCliente.Name = "txtDireccionCliente";
            txtDireccionCliente.Size = new Size(114, 27);
            txtDireccionCliente.TabIndex = 12;
            // 
            // txtBuscarCliente
            // 
            txtBuscarCliente.Location = new Point(289, 12);
            txtBuscarCliente.Margin = new Padding(3, 4, 3, 4);
            txtBuscarCliente.Name = "txtBuscarCliente";
            txtBuscarCliente.Size = new Size(571, 27);
            txtBuscarCliente.TabIndex = 13;
            // 
            // gridCliente
            // 
            gridCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridCliente.Location = new Point(291, 65);
            gridCliente.Margin = new Padding(3, 4, 3, 4);
            gridCliente.Name = "gridCliente";
            gridCliente.RowHeadersWidth = 51;
            gridCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridCliente.Size = new Size(569, 307);
            gridCliente.TabIndex = 14;
            gridCliente.SelectionChanged += gridCliente_SelectionChanged;
            // 
            // btnModificarCliente
            // 
            btnModificarCliente.Location = new Point(106, 313);
            btnModificarCliente.Margin = new Padding(3, 4, 3, 4);
            btnModificarCliente.Name = "btnModificarCliente";
            btnModificarCliente.Size = new Size(86, 31);
            btnModificarCliente.TabIndex = 15;
            btnModificarCliente.Text = "Modificar";
            btnModificarCliente.UseVisualStyleBackColor = true;
            // 
            // btnEliminarCliente
            // 
            btnEliminarCliente.Location = new Point(199, 313);
            btnEliminarCliente.Margin = new Padding(3, 4, 3, 4);
            btnEliminarCliente.Name = "btnEliminarCliente";
            btnEliminarCliente.Size = new Size(86, 31);
            btnEliminarCliente.TabIndex = 16;
            btnEliminarCliente.Text = "Eliminar";
            btnEliminarCliente.UseVisualStyleBackColor = true;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnEliminarCliente);
            Controls.Add(btnModificarCliente);
            Controls.Add(gridCliente);
            Controls.Add(txtBuscarCliente);
            Controls.Add(txtDireccionCliente);
            Controls.Add(txtCiudadCliente);
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
            Margin = new Padding(3, 4, 3, 4);
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
        private TextBox txtCiudadCliente;
        private TextBox txtDireccionCliente;
        private TextBox txtBuscarCliente;
        private DataGridView gridCliente;
        private Button btnModificarCliente;
        private Button btnEliminarCliente;
    }
}