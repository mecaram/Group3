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
            btnModificar.Location = new Point(46, 285);
            btnModificar.Margin = new Padding(3, 2, 3, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(82, 22);
            btnModificar.TabIndex = 0;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
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
            // 
            // lblIdCiudades
            // 
            lblIdCiudades.AutoSize = true;
            lblIdCiudades.Location = new Point(54, 76);
            lblIdCiudades.Name = "lblIdCiudades";
            lblIdCiudades.Size = new Size(61, 15);
            lblIdCiudades.TabIndex = 3;
            lblIdCiudades.Text = "Id Ciudad:";
            // 
            // lblCiudad
            // 
            lblCiudad.AutoSize = true;
            lblCiudad.Location = new Point(54, 146);
            lblCiudad.Name = "lblCiudad";
            lblCiudad.Size = new Size(48, 15);
            lblCiudad.TabIndex = 4;
            lblCiudad.Text = "Ciudad:\r\n";
            // 
            // lblCodPostal
            // 
            lblCodPostal.AutoSize = true;
            lblCodPostal.Location = new Point(54, 205);
            lblCodPostal.Name = "lblCodPostal";
            lblCodPostal.Size = new Size(84, 15);
            lblCodPostal.TabIndex = 5;
            lblCodPostal.Text = "Codigo Postal:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(312, 110);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(360, 155);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtIdCiudad
            // 
            txtIdCiudad.Location = new Point(135, 77);
            txtIdCiudad.Margin = new Padding(3, 2, 3, 2);
            txtIdCiudad.Name = "txtIdCiudad";
            txtIdCiudad.Size = new Size(110, 23);
            txtIdCiudad.TabIndex = 7;
            // 
            // txtCiudad
            // 
            txtCiudad.Location = new Point(123, 146);
            txtCiudad.Margin = new Padding(3, 2, 3, 2);
            txtCiudad.Name = "txtCiudad";
            txtCiudad.Size = new Size(110, 23);
            txtCiudad.TabIndex = 8;
            // 
            // txtCodPostal
            // 
            txtCodPostal.Location = new Point(150, 202);
            txtCodPostal.Margin = new Padding(3, 2, 3, 2);
            txtCodPostal.Name = "txtCodPostal";
            txtCodPostal.Size = new Size(110, 23);
            txtCodPostal.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(312, 73);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(360, 23);
            textBox1.TabIndex = 10;
            // 
            // Ciudades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
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
            Margin = new Padding(3, 2, 3, 2);
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