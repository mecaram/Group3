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
            dataGridView1 = new DataGridView();
            txtIdCiudad = new TextBox();
            txtCiudad = new TextBox();
            txtCodPostal = new TextBox();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(53, 380);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 29);
            btnModificar.TabIndex = 0;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(152, 380);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(263, 381);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // lblIdCiudades
            // 
            lblIdCiudades.AutoSize = true;
            lblIdCiudades.Location = new Point(43, 108);
            lblIdCiudades.Name = "lblIdCiudades";
            lblIdCiudades.Size = new Size(76, 20);
            lblIdCiudades.TabIndex = 3;
            lblIdCiudades.Text = "Id Ciudad:";
            // 
            // lblCiudad
            // 
            lblCiudad.AutoSize = true;
            lblCiudad.Location = new Point(43, 193);
            lblCiudad.Name = "lblCiudad";
            lblCiudad.Size = new Size(59, 20);
            lblCiudad.TabIndex = 4;
            lblCiudad.Text = "Ciudad:\r\n";
            // 
            // lblCodPostal
            // 
            lblCodPostal.AutoSize = true;
            lblCodPostal.Location = new Point(43, 276);
            lblCodPostal.Name = "lblCodPostal";
            lblCodPostal.Size = new Size(104, 20);
            lblCodPostal.TabIndex = 5;
            lblCodPostal.Text = "Codigo Postal:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(357, 147);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(411, 207);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtIdCiudad
            // 
            txtIdCiudad.Location = new Point(125, 105);
            txtIdCiudad.Name = "txtIdCiudad";
            txtIdCiudad.Size = new Size(125, 27);
            txtIdCiudad.TabIndex = 7;
            // 
            // txtCiudad
            // 
            txtCiudad.Location = new Point(108, 193);
            txtCiudad.Name = "txtCiudad";
            txtCiudad.Size = new Size(125, 27);
            txtCiudad.TabIndex = 8;
            // 
            // txtCodPostal
            // 
            txtCodPostal.Location = new Point(153, 269);
            txtCodPostal.Name = "txtCodPostal";
            txtCodPostal.Size = new Size(125, 27);
            txtCodPostal.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(357, 97);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(411, 27);
            textBox1.TabIndex = 10;
            // 
            // Ciudades
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(textBox1);
            Controls.Add(txtCodPostal);
            Controls.Add(txtCiudad);
            Controls.Add(txtIdCiudad);
            Controls.Add(dataGridView1);
            Controls.Add(lblCodPostal);
            Controls.Add(lblCiudad);
            Controls.Add(lblIdCiudades);
            Controls.Add(btnAgregar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Name = "Ciudades";
            Text = "Ciudades";
            Load += Ciudades_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridView dataGridView1;
        private TextBox txtIdCiudad;
        private TextBox txtCiudad;
        private TextBox txtCodPostal;
        private TextBox textBox1;
    }
}