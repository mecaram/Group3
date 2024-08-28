namespace Gestion
{
    partial class Cierres
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
            lblIdCierre = new Label();
            lblApertura = new Label();
            lblCierre = new Label();
            lblCerrado = new Label();
            txtIdCierre = new TextBox();
            txtApertura = new TextBox();
            txtCierre = new TextBox();
            txtCerrado = new TextBox();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(55, 400);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 29);
            btnModificar.TabIndex = 0;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(170, 400);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(281, 400);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // lblIdCierre
            // 
            lblIdCierre.AutoSize = true;
            lblIdCierre.Location = new Point(55, 85);
            lblIdCierre.Name = "lblIdCierre";
            lblIdCierre.Size = new Size(68, 20);
            lblIdCierre.TabIndex = 3;
            lblIdCierre.Text = "Id Cierre:";
            // 
            // lblApertura
            // 
            lblApertura.AutoSize = true;
            lblApertura.Location = new Point(55, 165);
            lblApertura.Name = "lblApertura";
            lblApertura.Size = new Size(70, 20);
            lblApertura.TabIndex = 4;
            lblApertura.Text = "Apertura:";
            // 
            // lblCierre
            // 
            lblCierre.AutoSize = true;
            lblCierre.Location = new Point(55, 243);
            lblCierre.Name = "lblCierre";
            lblCierre.Size = new Size(51, 20);
            lblCierre.TabIndex = 5;
            lblCierre.Text = "Cierre:";
            // 
            // lblCerrado
            // 
            lblCerrado.AutoSize = true;
            lblCerrado.Location = new Point(55, 313);
            lblCerrado.Name = "lblCerrado";
            lblCerrado.Size = new Size(65, 20);
            lblCerrado.TabIndex = 6;
            lblCerrado.Text = "Cerrado:";
            // 
            // txtIdCierre
            // 
            txtIdCierre.Location = new Point(134, 87);
            txtIdCierre.Name = "txtIdCierre";
            txtIdCierre.Size = new Size(125, 27);
            txtIdCierre.TabIndex = 7;
            // 
            // txtApertura
            // 
            txtApertura.Location = new Point(139, 161);
            txtApertura.Name = "txtApertura";
            txtApertura.Size = new Size(125, 27);
            txtApertura.TabIndex = 8;
            // 
            // txtCierre
            // 
            txtCierre.Location = new Point(122, 240);
            txtCierre.Name = "txtCierre";
            txtCierre.Size = new Size(125, 27);
            txtCierre.TabIndex = 9;
            // 
            // txtCerrado
            // 
            txtCerrado.Location = new Point(126, 310);
            txtCerrado.Name = "txtCerrado";
            txtCerrado.Size = new Size(125, 27);
            txtCerrado.TabIndex = 10;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(362, 147);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(393, 220);
            dataGridView1.TabIndex = 11;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(362, 90);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(393, 27);
            textBox1.TabIndex = 12;
            // 
            // Cierres
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(txtCerrado);
            Controls.Add(txtCierre);
            Controls.Add(txtApertura);
            Controls.Add(txtIdCierre);
            Controls.Add(lblCerrado);
            Controls.Add(lblCierre);
            Controls.Add(lblApertura);
            Controls.Add(lblIdCierre);
            Controls.Add(btnAgregar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Name = "Cierres";
            Text = "Cierres";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnModificar;
        private Button btnEliminar;
        private Button btnAgregar;
        private Label lblIdCierre;
        private Label lblApertura;
        private Label lblCierre;
        private Label lblCerrado;
        private TextBox txtIdCierre;
        private TextBox txtApertura;
        private TextBox txtCierre;
        private TextBox txtCerrado;
        private DataGridView dataGridView1;
        private TextBox textBox1;
    }
}