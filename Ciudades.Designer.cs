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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnAgregar = new Button();
            lblIdCiudades = new Label();
            lblCiudad = new Label();
            lblCodPostal = new Label();
            gridCiudades = new DataGridView();
            txtIdCiudad = new TextBox();
            txtCiudad = new TextBox();
            txtCodPostal = new TextBox();
            txtBuscar = new TextBox();
            txtLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)gridCiudades).BeginInit();
            SuspendLayout();
            // 
            // btnModificar
            // 
            btnModificar.BackColor = SystemColors.ScrollBar;
            btnModificar.Location = new Point(40, 342);
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
            btnEliminar.Location = new Point(140, 342);
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
            btnAgregar.Location = new Point(240, 342);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 26);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblIdCiudades
            // 
            lblIdCiudades.AutoSize = true;
            lblIdCiudades.Location = new Point(58, 101);
            lblIdCiudades.Name = "lblIdCiudades";
            lblIdCiudades.Size = new Size(72, 18);
            lblIdCiudades.TabIndex = 3;
            lblIdCiudades.Text = "Id Ciudad:";
            // 
            // lblCiudad
            // 
            lblCiudad.AutoSize = true;
            lblCiudad.Location = new Point(75, 170);
            lblCiudad.Name = "lblCiudad";
            lblCiudad.Size = new Size(56, 18);
            lblCiudad.TabIndex = 4;
            lblCiudad.Text = "Ciudad:\r\n";
            // 
            // lblCodPostal
            // 
            lblCodPostal.AutoSize = true;
            lblCodPostal.Location = new Point(30, 245);
            lblCodPostal.Name = "lblCodPostal";
            lblCodPostal.Size = new Size(101, 18);
            lblCodPostal.TabIndex = 5;
            lblCodPostal.Text = "Codigo Postal:";
            // 
            // gridCiudades
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            gridCiudades.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            gridCiudades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            gridCiudades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            gridCiudades.DefaultCellStyle = dataGridViewCellStyle3;
            gridCiudades.Location = new Point(374, 130);
            gridCiudades.Name = "gridCiudades";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            gridCiudades.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            gridCiudades.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            gridCiudades.RowsDefaultCellStyle = dataGridViewCellStyle5;
            gridCiudades.Size = new Size(446, 186);
            gridCiudades.TabIndex = 6;
            gridCiudades.CellContentClick += gridCiudades_SelectionChanged;
            // 
            // txtIdCiudad
            // 
            txtIdCiudad.BackColor = Color.Silver;
            txtIdCiudad.Location = new Point(152, 94);
            txtIdCiudad.Name = "txtIdCiudad";
            txtIdCiudad.Size = new Size(125, 26);
            txtIdCiudad.TabIndex = 7;
            // 
            // txtCiudad
            // 
            txtCiudad.BackColor = Color.Silver;
            txtCiudad.Location = new Point(152, 167);
            txtCiudad.Name = "txtCiudad";
            txtCiudad.Size = new Size(125, 26);
            txtCiudad.TabIndex = 8;
            // 
            // txtCodPostal
            // 
            txtCodPostal.BackColor = Color.Silver;
            txtCodPostal.Location = new Point(153, 242);
            txtCodPostal.Name = "txtCodPostal";
            txtCodPostal.Size = new Size(125, 26);
            txtCodPostal.TabIndex = 9;
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = Color.Silver;
            txtBuscar.Location = new Point(374, 69);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(446, 26);
            txtBuscar.TabIndex = 10;
            // 
            // txtLimpiar
            // 
            txtLimpiar.BackColor = Color.Silver;
            txtLimpiar.Location = new Point(140, 385);
            txtLimpiar.Margin = new Padding(3, 4, 3, 4);
            txtLimpiar.Name = "txtLimpiar";
            txtLimpiar.Size = new Size(94, 26);
            txtLimpiar.TabIndex = 11;
            txtLimpiar.Text = "Limpiar";
            txtLimpiar.UseVisualStyleBackColor = false;
            txtLimpiar.Click += txtLimpiar_Click;
            // 
            // Ciudades
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(899, 446);
            Controls.Add(txtLimpiar);
            Controls.Add(txtBuscar);
            Controls.Add(txtCodPostal);
            Controls.Add(txtCiudad);
            Controls.Add(txtIdCiudad);
            Controls.Add(gridCiudades);
            Controls.Add(lblCodPostal);
            Controls.Add(lblCiudad);
            Controls.Add(lblIdCiudades);
            Controls.Add(btnAgregar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Ciudades";
            Text = "Ciudades";
            Load += Ciudades_Load;
            ((System.ComponentModel.ISupportInitialize)gridCiudades).EndInit();
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
        private DataGridView gridCiudades;
        private TextBox txtIdCiudad;
        private TextBox txtCiudad;
        private TextBox txtCodPostal;
        private TextBox txtBuscar;
        private Button txtLimpiar;
    }
}