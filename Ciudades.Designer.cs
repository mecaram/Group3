namespace Gestion
{
    partial class Ciudades
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
            lblIdCiudades = new Label();
            lblCiudad = new Label();
            lblCodPostal = new Label();
            gridCiudades = new DataGridView();
            txtIdCiudad = new TextBox();
            txtCiudad = new TextBox();
            txtCodPostal = new TextBox();
            txtBuscar = new TextBox();
            txtLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)gridCiudades).BeginInit();
            SuspendLayout();
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(46, 285);
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
            btnEliminar.Location = new Point(133, 285);
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
            btnAgregar.Location = new Point(230, 286);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(82, 22);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblIdCiudades
            // 
            lblIdCiudades.AutoSize = true;
            lblIdCiudades.Location = new Point(38, 81);
            lblIdCiudades.Name = "lblIdCiudades";
            lblIdCiudades.Size = new Size(61, 15);
            lblIdCiudades.TabIndex = 3;
            lblIdCiudades.Text = "Id Ciudad:";
            // 
            // lblCiudad
            // 
            lblCiudad.AutoSize = true;
            lblCiudad.Location = new Point(38, 145);
            lblCiudad.Name = "lblCiudad";
            lblCiudad.Size = new Size(48, 15);
            lblCiudad.TabIndex = 4;
            lblCiudad.Text = "Ciudad:\r\n";
            // 
            // lblCodPostal
            // 
            lblCodPostal.AutoSize = true;
            lblCodPostal.Location = new Point(38, 207);
            lblCodPostal.Name = "lblCodPostal";
            lblCodPostal.Size = new Size(84, 15);
            lblCodPostal.TabIndex = 5;
            lblCodPostal.Text = "Codigo Postal:";
            // 
            // gridCiudades
            // 
            gridCiudades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridCiudades.Location = new Point(312, 110);
            gridCiudades.Margin = new Padding(3, 2, 3, 2);
            gridCiudades.Name = "gridCiudades";
            gridCiudades.RowHeadersWidth = 51;
            gridCiudades.Size = new Size(360, 155);
            gridCiudades.TabIndex = 6;
            gridCiudades.CellContentClick += gridCiudades_SelectionChanged;
            // 
            // txtIdCiudad
            // 
            txtIdCiudad.Location = new Point(109, 79);
            txtIdCiudad.Margin = new Padding(3, 2, 3, 2);
            txtIdCiudad.Name = "txtIdCiudad";
            txtIdCiudad.Size = new Size(110, 23);
            txtIdCiudad.TabIndex = 7;
            // 
            // txtCiudad
            // 
            txtCiudad.Location = new Point(94, 145);
            txtCiudad.Margin = new Padding(3, 2, 3, 2);
            txtCiudad.Name = "txtCiudad";
            txtCiudad.Size = new Size(110, 23);
            txtCiudad.TabIndex = 8;
            // 
            // txtCodPostal
            // 
            txtCodPostal.Location = new Point(134, 202);
            txtCodPostal.Margin = new Padding(3, 2, 3, 2);
            txtCodPostal.Name = "txtCodPostal";
            txtCodPostal.Size = new Size(110, 23);
            txtCodPostal.TabIndex = 9;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(312, 73);
            txtBuscar.Margin = new Padding(3, 2, 3, 2);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(360, 23);
            txtBuscar.TabIndex = 10;
            // 
            // txtLimpiar
            // 
            txtLimpiar.Location = new Point(327, 290);
            txtLimpiar.Name = "txtLimpiar";
            txtLimpiar.Size = new Size(75, 23);
            txtLimpiar.TabIndex = 11;
            txtLimpiar.Text = "Limpiar";
            txtLimpiar.UseVisualStyleBackColor = true;
            txtLimpiar.Click += txtLimpiar_Click;
            // 
            // Ciudades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(txtLimpiar);
            Controls.Add(txtBuscar);
            Controls.Add(txtCodPostal);
            Controls.Add(txtCiudad);
            Controls.Add(txtIdCiudad);
            Controls.Add(gridCiudades);
            Controls.Add(lblCodPostal);
            Controls.Add(lblCiudad);
            Controls.Add(lblIdCiudades);
            Controls.Add(btnAgregar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Ciudades";
            Text = "Ciudades";
            Load += Ciudades_Load;
            ((System.ComponentModel.ISupportInitialize)gridCiudades).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnModificar;
        private Button btnEliminar;
        private Button btnAgregar;
        private Label lblIdCiudades;
        private Label lblCiudad;
        private Label lblCodPostal;
        private DataGridView gridCiudades;
        private TextBox txtIdCiudad;
        private TextBox txtCiudad;
        private TextBox txtCodPostal;
        private TextBox txtBuscar;
        private Button txtLimpiar;
    }
}