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
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            txtIdMedios = new TextBox();
            textBox3 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(35, 401);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 29);
            btnModificar.TabIndex = 0;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(152, 399);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(266, 399);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // lblMediosDePagos
            // 
            lblMediosDePagos.AutoSize = true;
            lblMediosDePagos.Location = new Point(35, 244);
            lblMediosDePagos.Name = "lblMediosDePagos";
            lblMediosDePagos.Size = new Size(125, 20);
            lblMediosDePagos.TabIndex = 3;
            lblMediosDePagos.Text = "Medios de Pagos:";
            // 
            // lblIdMedios
            // 
            lblIdMedios.AutoSize = true;
            lblIdMedios.Location = new Point(51, 124);
            lblIdMedios.Name = "lblIdMedios";
            lblIdMedios.Size = new Size(78, 20);
            lblIdMedios.TabIndex = 4;
            lblIdMedios.Text = "Id Medios:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(420, 174);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(375, 188);
            dataGridView1.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(420, 120);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(375, 27);
            textBox1.TabIndex = 6;
            // 
            // txtIdMedios
            // 
            txtIdMedios.Location = new Point(152, 117);
            txtIdMedios.Name = "txtIdMedios";
            txtIdMedios.Size = new Size(125, 27);
            txtIdMedios.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(166, 237);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 8;
            // 
            // MediosDePagos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(876, 450);
            Controls.Add(textBox3);
            Controls.Add(txtIdMedios);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(lblIdMedios);
            Controls.Add(lblMediosDePagos);
            Controls.Add(btnAgregar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Name = "MediosDePagos";
            Text = "MediosDePagos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnModificar;
        private Button btnEliminar;
        private Button btnAgregar;
        private Label lblMediosDePagos;
        private Label lblIdMedios;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private TextBox txtIdMedios;
        private TextBox textBox3;
    }
}