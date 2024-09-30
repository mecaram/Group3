namespace Gestion
{
    partial class Marcas
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
            lblIdMarcas = new Label();
            lblNombre = new Label();
            txtIdMarca = new TextBox();
            txtNombre = new TextBox();
            txtBuscar = new TextBox();
            gridMarcas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridMarcas).BeginInit();
            SuspendLayout();
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(49, 312);
            btnModificar.Margin = new Padding(3, 2, 3, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(82, 22);
            btnModificar.TabIndex = 0;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(143, 312);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(82, 22);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(250, 312);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(82, 22);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblIdMarcas
            // 
            lblIdMarcas.AutoSize = true;
            lblIdMarcas.Location = new Point(49, 104);
            lblIdMarcas.Name = "lblIdMarcas";
            lblIdMarcas.Size = new Size(56, 15);
            lblIdMarcas.TabIndex = 3;
            lblIdMarcas.Text = "Id Marca:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(49, 206);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre:";
            // 
            // txtIdMarca
            // 
            txtIdMarca.Location = new Point(116, 104);
            txtIdMarca.Margin = new Padding(3, 2, 3, 2);
            txtIdMarca.Name = "txtIdMarca";
            txtIdMarca.Size = new Size(110, 23);
            txtIdMarca.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(116, 206);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(110, 23);
            txtNombre.TabIndex = 6;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(405, 55);
            txtBuscar.Margin = new Padding(3, 2, 3, 2);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(414, 23);
            txtBuscar.TabIndex = 7;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // gridMarcas
            // 
            gridMarcas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridMarcas.Location = new Point(411, 92);
            gridMarcas.Margin = new Padding(3, 2, 3, 2);
            gridMarcas.Name = "gridMarcas";
            gridMarcas.RowHeadersWidth = 51;
            gridMarcas.Size = new Size(408, 242);
            gridMarcas.TabIndex = 8;
            // 
            // Marcas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 354);
            Controls.Add(gridMarcas);
            Controls.Add(txtBuscar);
            Controls.Add(txtNombre);
            Controls.Add(txtIdMarca);
            Controls.Add(lblNombre);
            Controls.Add(lblIdMarcas);
            Controls.Add(btnAgregar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Marcas";
            Text = "Marcas";
            Load += Marcas_Load;
            ((System.ComponentModel.ISupportInitialize)gridMarcas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnModificar;
        private Button btnEliminar;
        private Button btnAgregar;
        private Label lblIdMarcas;
        private Label lblNombre;
        private TextBox txtIdMarca;
        private TextBox txtNombre;
        private TextBox txtBuscar;
        private DataGridView gridMarcas;
    }
}