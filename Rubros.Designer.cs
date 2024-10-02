namespace Gestion
{
    partial class Rubros
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
            lblIdRubro = new Label();
            lblNombre = new Label();
            txtIdRubro = new TextBox();
            txtNombre = new TextBox();
            txtBuscar = new TextBox();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnAgregar = new Button();
            grdRubros = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)grdRubros).BeginInit();
            SuspendLayout();
            // 
            // lblIdRubro
            // 
            lblIdRubro.AutoSize = true;
            lblIdRubro.Location = new Point(32, 96);
            lblIdRubro.Name = "lblIdRubro";
            lblIdRubro.Size = new Size(69, 20);
            lblIdRubro.TabIndex = 0;
            lblIdRubro.Text = "Id Rubro:\r\n";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(32, 184);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // txtIdRubro
            // 
            txtIdRubro.Location = new Point(107, 96);
            txtIdRubro.Name = "txtIdRubro";
            txtIdRubro.Size = new Size(125, 27);
            txtIdRubro.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(107, 184);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 3;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(410, 93);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(374, 27);
            txtBuscar.TabIndex = 4;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(32, 386);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 29);
            btnModificar.TabIndex = 6;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(142, 386);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(254, 386);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // grdRubros
            // 
            grdRubros.AllowUserToAddRows = false;
            grdRubros.AllowUserToDeleteRows = false;
            grdRubros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdRubros.Location = new Point(414, 158);
            grdRubros.Name = "grdRubros";
            grdRubros.ReadOnly = true;
            grdRubros.RowHeadersWidth = 51;
            grdRubros.Size = new Size(300, 188);
            grdRubros.TabIndex = 9;
            // 
            // Rubros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 499);
            Controls.Add(grdRubros);
            Controls.Add(btnAgregar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(txtBuscar);
            Controls.Add(txtNombre);
            Controls.Add(txtIdRubro);
            Controls.Add(lblNombre);
            Controls.Add(lblIdRubro);
            Name = "Rubros";
            Text = "Rubros";
            Load += Rubros_Load;
            ((System.ComponentModel.ISupportInitialize)grdRubros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIdRubro;
        private Label lblNombre;
        private TextBox txtIdRubro;
        private TextBox txtNombre;
        private TextBox txtBuscar;
        private DataGridView gridRubro;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnAgregar;
        private DataGridView grdRubros;
    }
}