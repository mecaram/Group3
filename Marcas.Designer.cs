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
            txtbuscar = new TextBox();
            gridMarcas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridMarcas).BeginInit();
            SuspendLayout();
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(56, 416);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 29);
            btnModificar.TabIndex = 0;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(163, 416);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(286, 416);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblIdMarcas
            // 
            lblIdMarcas.AutoSize = true;
            lblIdMarcas.Location = new Point(56, 138);
            lblIdMarcas.Name = "lblIdMarcas";
            lblIdMarcas.Size = new Size(70, 20);
            lblIdMarcas.TabIndex = 3;
            lblIdMarcas.Text = "Id Marca:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(56, 274);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre:";
            // 
            // txtIdMarca
            // 
            txtIdMarca.Location = new Point(132, 138);
            txtIdMarca.Name = "txtIdMarca";
            txtIdMarca.Size = new Size(125, 27);
            txtIdMarca.TabIndex = 5;
          
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(132, 274);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 6;
         
            // 
            // txtbuscar
            // 
            txtbuscar.Location = new Point(463, 73);
            txtbuscar.Name = "txtbuscar";
            txtbuscar.Size = new Size(473, 27);
            txtbuscar.TabIndex = 7;
        
            // 
            // gridMarcas
            // 
            gridMarcas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridMarcas.Location = new Point(470, 123);
            gridMarcas.Name = "gridMarcas";
            gridMarcas.RowHeadersWidth = 51;
            gridMarcas.Size = new Size(466, 322);
            gridMarcas.TabIndex = 8;
           
            // 
            // Marcas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1027, 472);
            Controls.Add(gridMarcas);
            Controls.Add(txtbuscar);
            Controls.Add(txtNombre);
            Controls.Add(txtIdMarca);
            Controls.Add(lblNombre);
            Controls.Add(lblIdMarcas);
            Controls.Add(btnAgregar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
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
        private TextBox txtbuscar;
        private DataGridView gridMarcas;
    }
}