namespace Gestion
{
    partial class Administradores
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
            lblIdAdministradores = new Label();
            lblNombre = new Label();
            lblContraseña = new Label();
            gridAdministradores = new DataGridView();
            txtBuscar = new TextBox();
            txtIdAdministradores = new TextBox();
            txtNombre = new TextBox();
            txtContrasenia = new TextBox();
            txtLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)gridAdministradores).BeginInit();
            SuspendLayout();
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(43, 393);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 29);
            btnModificar.TabIndex = 0;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(164, 393);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(282, 393);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // lblIdAdministradores
            // 
            lblIdAdministradores.AutoSize = true;
            lblIdAdministradores.Location = new Point(43, 147);
            lblIdAdministradores.Name = "lblIdAdministradores";
            lblIdAdministradores.Size = new Size(138, 20);
            lblIdAdministradores.TabIndex = 3;
            lblIdAdministradores.Text = "Id Administradores:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(43, 230);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre:";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(43, 300);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(86, 20);
            lblContraseña.TabIndex = 5;
            lblContraseña.Text = "Contraseña:";
            // 
            // gridAdministradores
            // 
            gridAdministradores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridAdministradores.Location = new Point(392, 135);
            gridAdministradores.Name = "gridAdministradores";
            gridAdministradores.RowHeadersWidth = 51;
            gridAdministradores.Size = new Size(429, 232);
            gridAdministradores.TabIndex = 6;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(392, 89);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(429, 27);
            txtBuscar.TabIndex = 7;
            // 
            // txtIdAdministradores
            // 
            txtIdAdministradores.Location = new Point(193, 140);
            txtIdAdministradores.Name = "txtIdAdministradores";
            txtIdAdministradores.Size = new Size(125, 27);
            txtIdAdministradores.TabIndex = 8;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(116, 223);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 9;
            // 
            // txtContrasenia
            // 
            txtContrasenia.Location = new Point(133, 297);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.Size = new Size(125, 27);
            txtContrasenia.TabIndex = 10;
            // 
            // txtLimpiar
            // 
            txtLimpiar.Location = new Point(392, 393);
            txtLimpiar.Name = "txtLimpiar";
            txtLimpiar.Size = new Size(94, 29);
            txtLimpiar.TabIndex = 11;
            txtLimpiar.Text = "Limpiar";
            txtLimpiar.UseVisualStyleBackColor = true;
            txtLimpiar.Click += txtLimpiar_Click;
            // 
            // Administradores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(852, 450);
            Controls.Add(txtLimpiar);
            Controls.Add(txtContrasenia);
            Controls.Add(txtNombre);
            Controls.Add(txtIdAdministradores);
            Controls.Add(txtBuscar);
            Controls.Add(gridAdministradores);
            Controls.Add(lblContraseña);
            Controls.Add(lblNombre);
            Controls.Add(lblIdAdministradores);
            Controls.Add(btnAgregar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Name = "Administradores";
            Text = "Administradores";
            Load += Administradores_Load;
            ((System.ComponentModel.ISupportInitialize)gridAdministradores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnModificar;
        private Button btnEliminar;
        private Button btnAgregar;
        private Label lblIdAdministradores;
        private Label lblNombre;
        private Label lblContraseña;
        private DataGridView gridAdministradores;
        private TextBox txtBuscar;
        private TextBox txtIdAdministradores;
        private TextBox txtNombre;
        private TextBox txtContrasenia;
        private Button txtLimpiar;
    }
}