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
            textBox3 = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(163, 416);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(286, 416);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
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
            // textBox3
            // 
            textBox3.Location = new Point(463, 73);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(473, 27);
            textBox3.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(470, 123);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(466, 322);
            dataGridView1.TabIndex = 8;
            // 
            // Marcas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1027, 472);
            Controls.Add(dataGridView1);
            Controls.Add(textBox3);
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private TextBox textBox3;
        private DataGridView dataGridView1;
    }
}