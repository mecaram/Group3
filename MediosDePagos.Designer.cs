namespace Gestion
{
    partial class MediosDePagos
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
            lblMediosDePagos = new Label();
            lblIdMedios = new Label();
            gridMediosDePagos = new DataGridView();
            txtBuscar = new TextBox();
            txtIdMedios = new TextBox();
            txtMediosdePagos = new TextBox();
            ((System.ComponentModel.ISupportInitialize)gridMediosDePagos).BeginInit();
            SuspendLayout();
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(31, 301);
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
            btnEliminar.Location = new Point(133, 299);
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
            btnAgregar.Location = new Point(233, 299);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(82, 22);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblMediosDePagos
            // 
            lblMediosDePagos.AutoSize = true;
            lblMediosDePagos.Location = new Point(31, 183);
            lblMediosDePagos.Name = "lblMediosDePagos";
            lblMediosDePagos.Size = new Size(100, 15);
            lblMediosDePagos.TabIndex = 3;
            lblMediosDePagos.Text = "Medios de Pagos:";
            // 
            // lblIdMedios
            // 
            lblIdMedios.AutoSize = true;
            lblIdMedios.Location = new Point(45, 93);
            lblIdMedios.Name = "lblIdMedios";
            lblIdMedios.Size = new Size(62, 15);
            lblIdMedios.TabIndex = 4;
            lblIdMedios.Text = "Id Medios:";
            // 
            // gridMediosDePagos
            // 
            gridMediosDePagos.AllowUserToAddRows = false;
            gridMediosDePagos.AllowUserToDeleteRows = false;
            gridMediosDePagos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridMediosDePagos.Location = new Point(368, 130);
            gridMediosDePagos.Margin = new Padding(3, 2, 3, 2);
            gridMediosDePagos.Name = "gridMediosDePagos";
            gridMediosDePagos.ReadOnly = true;
            gridMediosDePagos.RowHeadersWidth = 51;
            gridMediosDePagos.Size = new Size(328, 141);
            gridMediosDePagos.TabIndex = 5;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(368, 90);
            txtBuscar.Margin = new Padding(3, 2, 3, 2);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(329, 23);
            txtBuscar.TabIndex = 6;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // txtIdMedios
            // 
            txtIdMedios.Location = new Point(133, 88);
            txtIdMedios.Margin = new Padding(3, 2, 3, 2);
            txtIdMedios.Name = "txtIdMedios";
            txtIdMedios.Size = new Size(110, 23);
            txtIdMedios.TabIndex = 7;
            // 
            // txtMediosdePagos
            // 
            txtMediosdePagos.Location = new Point(145, 178);
            txtMediosdePagos.Margin = new Padding(3, 2, 3, 2);
            txtMediosdePagos.Name = "txtMediosdePagos";
            txtMediosdePagos.Size = new Size(110, 23);
            txtMediosdePagos.TabIndex = 8;
            // 
            // MediosDePagos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(766, 338);
            Controls.Add(txtMediosdePagos);
            Controls.Add(txtIdMedios);
            Controls.Add(txtBuscar);
            Controls.Add(gridMediosDePagos);
            Controls.Add(lblIdMedios);
            Controls.Add(lblMediosDePagos);
            Controls.Add(btnAgregar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MediosDePagos";
            Text = "MediosDePagos";
            Load += MediosDePagos_Load;
            ((System.ComponentModel.ISupportInitialize)gridMediosDePagos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnModificar;
        private Button btnEliminar;
        private Button btnAgregar;
        private Label lblMediosDePagos;
        private Label lblIdMedios;
        private DataGridView gridMediosDePagos;
        private TextBox txtBuscar;
        private TextBox txtIdMedios;
        private TextBox txtMediosdePagos;
    }
}