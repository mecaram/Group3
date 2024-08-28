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
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            txtIdAdministradores = new TextBox();
            txtNombre = new TextBox();
            txtContraseña = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            lblIdAdministradores.Click += label1_Click;
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(392, 135);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(429, 232);
            dataGridView1.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(392, 89);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(429, 27);
            textBox1.TabIndex = 7;
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
            // txtContraseña
            // 
            txtContraseña.Location = new Point(133, 297);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(125, 27);
            txtContraseña.TabIndex = 10;
            // 
            // Administradores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(852, 450);
            Controls.Add(txtContraseña);
            Controls.Add(txtNombre);
            Controls.Add(txtIdAdministradores);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(lblContraseña);
            Controls.Add(lblNombre);
            Controls.Add(lblIdAdministradores);
            Controls.Add(btnAgregar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Name = "Administradores";
            Text = "Administradores";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private TextBox txtIdAdministradores;
        private TextBox txtNombre;
        private TextBox txtContraseña;
    }
}