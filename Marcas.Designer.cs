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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnAgregar = new Button();
            lblIdMarcas = new Label();
            lblNombre = new Label();
            txtIdMarca = new TextBox();
            txtNombre = new TextBox();
            txtBuscar = new TextBox();
            gridMarcas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridMarcas).BeginInit();
            SuspendLayout();
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.Silver;
            btnModificar.Location = new Point(56, 374);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 26);
            btnModificar.TabIndex = 0;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Silver;
            btnEliminar.Location = new Point(156, 374);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 26);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.Silver;
            btnAgregar.Location = new Point(256, 375);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 26);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblIdMarcas
            // 
            lblIdMarcas.AutoSize = true;
            lblIdMarcas.Location = new Point(93, 128);
            lblIdMarcas.Name = "lblIdMarcas";
            lblIdMarcas.Size = new Size(68, 18);
            lblIdMarcas.TabIndex = 3;
            lblIdMarcas.Text = "Id Marca:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(93, 241);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(65, 18);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre:";
            // 
            // txtIdMarca
            // 
            txtIdMarca.BackColor = Color.Silver;
            txtIdMarca.Location = new Point(176, 125);
            txtIdMarca.Name = "txtIdMarca";
            txtIdMarca.Size = new Size(125, 26);
            txtIdMarca.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.Silver;
            txtNombre.Location = new Point(176, 238);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 26);
            txtNombre.TabIndex = 6;
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = Color.Silver;
            txtBuscar.Location = new Point(463, 66);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(473, 26);
            txtBuscar.TabIndex = 7;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // gridMarcas
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            gridMarcas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            gridMarcas.BackgroundColor = SystemColors.ScrollBar;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            gridMarcas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            gridMarcas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            gridMarcas.DefaultCellStyle = dataGridViewCellStyle3;
            gridMarcas.Location = new Point(470, 111);
            gridMarcas.Name = "gridMarcas";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            gridMarcas.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            gridMarcas.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            gridMarcas.RowsDefaultCellStyle = dataGridViewCellStyle5;
            gridMarcas.Size = new Size(466, 291);
            gridMarcas.TabIndex = 8;
            // 
            // Marcas
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1027, 453);
            Controls.Add(gridMarcas);
            Controls.Add(txtBuscar);
            Controls.Add(txtNombre);
            Controls.Add(txtIdMarca);
            Controls.Add(lblNombre);
            Controls.Add(lblIdMarcas);
            Controls.Add(btnAgregar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
        private TextBox txtBuscar;
        private DataGridView gridMarcas;
    }
}