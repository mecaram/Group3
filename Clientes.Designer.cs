namespace Gestion
{
    partial class Clientes
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnCargarCliente = new Button();
            txtIdCliente = new TextBox();
            txtNombreCliente = new TextBox();
            txtApellidoCliente = new TextBox();
            txtDniCliente = new TextBox();
            txtDireccionCliente = new TextBox();
            txtBuscarCliente = new TextBox();
            gridCliente = new DataGridView();
            btnModificarCliente = new Button();
            btnEliminarCliente = new Button();
            cboCiudadCliente = new ComboBox();
            btnLimpiarCampos = new Button();
            btnAgregarCiudad = new Button();
            ((System.ComponentModel.ISupportInitialize)gridCliente).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(79, 37);
            label1.Name = "label1";
            label1.Size = new Size(25, 18);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(31, 272);
            label2.Name = "label2";
            label2.Size = new Size(73, 18);
            label2.TabIndex = 1;
            label2.Text = "Direccion:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(47, 224);
            label3.Name = "label3";
            label3.Size = new Size(56, 18);
            label3.TabIndex = 2;
            label3.Text = "Ciudad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(68, 177);
            label4.Name = "label4";
            label4.Size = new Size(36, 18);
            label4.TabIndex = 3;
            label4.Text = "DNI:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(37, 133);
            label5.Name = "label5";
            label5.Size = new Size(65, 18);
            label5.TabIndex = 4;
            label5.Text = "Apellido:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(39, 84);
            label6.Name = "label6";
            label6.Size = new Size(65, 18);
            label6.TabIndex = 5;
            label6.Text = "Nombre:";
            // 
            // btnCargarCliente
            // 
            btnCargarCliente.BackColor = Color.Silver;
            btnCargarCliente.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCargarCliente.ForeColor = Color.Black;
            btnCargarCliente.Location = new Point(20, 392);
            btnCargarCliente.Margin = new Padding(3, 4, 3, 4);
            btnCargarCliente.Name = "btnCargarCliente";
            btnCargarCliente.Size = new Size(86, 31);
            btnCargarCliente.TabIndex = 6;
            btnCargarCliente.Text = "Cargar";
            btnCargarCliente.UseVisualStyleBackColor = false;
            btnCargarCliente.Click += btnCargarCliente_Click;
            // 
            // txtIdCliente
            // 
            txtIdCliente.BackColor = Color.Silver;
            txtIdCliente.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtIdCliente.Location = new Point(112, 34);
            txtIdCliente.Margin = new Padding(3, 4, 3, 4);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(114, 26);
            txtIdCliente.TabIndex = 7;
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.BackColor = Color.Silver;
            txtNombreCliente.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombreCliente.Location = new Point(112, 81);
            txtNombreCliente.Margin = new Padding(3, 4, 3, 4);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(114, 26);
            txtNombreCliente.TabIndex = 8;
            // 
            // txtApellidoCliente
            // 
            txtApellidoCliente.BackColor = Color.Silver;
            txtApellidoCliente.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtApellidoCliente.Location = new Point(112, 130);
            txtApellidoCliente.Margin = new Padding(3, 4, 3, 4);
            txtApellidoCliente.Name = "txtApellidoCliente";
            txtApellidoCliente.Size = new Size(114, 26);
            txtApellidoCliente.TabIndex = 9;
            // 
            // txtDniCliente
            // 
            txtDniCliente.BackColor = Color.Silver;
            txtDniCliente.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDniCliente.Location = new Point(112, 177);
            txtDniCliente.Margin = new Padding(3, 4, 3, 4);
            txtDniCliente.Name = "txtDniCliente";
            txtDniCliente.Size = new Size(114, 26);
            txtDniCliente.TabIndex = 10;
            // 
            // txtDireccionCliente
            // 
            txtDireccionCliente.BackColor = Color.FromArgb(224, 224, 224);
            txtDireccionCliente.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDireccionCliente.Location = new Point(112, 272);
            txtDireccionCliente.Margin = new Padding(3, 4, 3, 4);
            txtDireccionCliente.Name = "txtDireccionCliente";
            txtDireccionCliente.Size = new Size(114, 26);
            txtDireccionCliente.TabIndex = 12;
            // 
            // txtBuscarCliente
            // 
            txtBuscarCliente.BackColor = Color.Silver;
            txtBuscarCliente.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBuscarCliente.Location = new Point(347, 34);
            txtBuscarCliente.Margin = new Padding(3, 4, 3, 4);
            txtBuscarCliente.Name = "txtBuscarCliente";
            txtBuscarCliente.Size = new Size(701, 26);
            txtBuscarCliente.TabIndex = 13;
            txtBuscarCliente.TextChanged += txtBuscarCliente_TextChanged;
            // 
            // gridCliente
            // 
            gridCliente.AllowUserToAddRows = false;
            gridCliente.AllowUserToDeleteRows = false;
            gridCliente.AllowUserToOrderColumns = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            gridCliente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            gridCliente.BackgroundColor = SystemColors.ScrollBar;
            gridCliente.BorderStyle = BorderStyle.Fixed3D;
            gridCliente.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            gridCliente.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            gridCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            gridCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Control;
            dataGridViewCellStyle8.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            gridCliente.DefaultCellStyle = dataGridViewCellStyle8;
            gridCliente.GridColor = Color.Silver;
            gridCliente.Location = new Point(347, 81);
            gridCliente.Margin = new Padding(3, 4, 3, 4);
            gridCliente.Name = "gridCliente";
            gridCliente.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            gridCliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            gridCliente.RowHeadersWidth = 51;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.Control;
            dataGridViewCellStyle10.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle10.ForeColor = Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            gridCliente.RowsDefaultCellStyle = dataGridViewCellStyle10;
            gridCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridCliente.Size = new Size(701, 307);
            gridCliente.TabIndex = 14;
            gridCliente.SelectionChanged += gridCliente_SelectionChanged;
            // 
            // btnModificarCliente
            // 
            btnModificarCliente.BackColor = Color.Silver;
            btnModificarCliente.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificarCliente.ForeColor = Color.Black;
            btnModificarCliente.Location = new Point(204, 392);
            btnModificarCliente.Margin = new Padding(3, 4, 3, 4);
            btnModificarCliente.Name = "btnModificarCliente";
            btnModificarCliente.Size = new Size(86, 31);
            btnModificarCliente.TabIndex = 15;
            btnModificarCliente.Text = "Modificar";
            btnModificarCliente.UseVisualStyleBackColor = false;
            btnModificarCliente.Click += btnModificarCliente_Click;
            // 
            // btnEliminarCliente
            // 
            btnEliminarCliente.BackColor = Color.Silver;
            btnEliminarCliente.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarCliente.ForeColor = Color.Black;
            btnEliminarCliente.Location = new Point(112, 392);
            btnEliminarCliente.Margin = new Padding(3, 4, 3, 4);
            btnEliminarCliente.Name = "btnEliminarCliente";
            btnEliminarCliente.Size = new Size(86, 31);
            btnEliminarCliente.TabIndex = 16;
            btnEliminarCliente.Text = "Eliminar";
            btnEliminarCliente.UseVisualStyleBackColor = false;
            btnEliminarCliente.Click += btnEliminarCliente_Click;
            // 
            // cboCiudadCliente
            // 
            cboCiudadCliente.BackColor = Color.Silver;
            cboCiudadCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCiudadCliente.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cboCiudadCliente.ForeColor = Color.Silver;
            cboCiudadCliente.FormattingEnabled = true;
            cboCiudadCliente.Location = new Point(112, 224);
            cboCiudadCliente.Margin = new Padding(3, 4, 3, 4);
            cboCiudadCliente.Name = "cboCiudadCliente";
            cboCiudadCliente.Size = new Size(111, 26);
            cboCiudadCliente.TabIndex = 17;
            // 
            // btnLimpiarCampos
            // 
            btnLimpiarCampos.BackColor = Color.Silver;
            btnLimpiarCampos.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiarCampos.ForeColor = Color.Black;
            btnLimpiarCampos.Location = new Point(112, 341);
            btnLimpiarCampos.Margin = new Padding(3, 4, 3, 4);
            btnLimpiarCampos.Name = "btnLimpiarCampos";
            btnLimpiarCampos.Size = new Size(86, 31);
            btnLimpiarCampos.TabIndex = 18;
            btnLimpiarCampos.Text = "Limpiar";
            btnLimpiarCampos.UseVisualStyleBackColor = false;
            btnLimpiarCampos.Click += btnLimpiarCampos_Click;
            // 
            // btnAgregarCiudad
            // 
            btnAgregarCiudad.BackColor = Color.Silver;
            btnAgregarCiudad.Location = new Point(229, 224);
            btnAgregarCiudad.Margin = new Padding(3, 4, 3, 4);
            btnAgregarCiudad.Name = "btnAgregarCiudad";
            btnAgregarCiudad.Size = new Size(45, 26);
            btnAgregarCiudad.TabIndex = 19;
            btnAgregarCiudad.Text = "...";
            btnAgregarCiudad.UseVisualStyleBackColor = false;
            btnAgregarCiudad.Click += btnAgregarCiudad_Click;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1128, 600);
            Controls.Add(btnAgregarCiudad);
            Controls.Add(btnLimpiarCampos);
            Controls.Add(cboCiudadCliente);
            Controls.Add(btnEliminarCliente);
            Controls.Add(btnModificarCliente);
            Controls.Add(gridCliente);
            Controls.Add(txtBuscarCliente);
            Controls.Add(txtDireccionCliente);
            Controls.Add(txtDniCliente);
            Controls.Add(txtApellidoCliente);
            Controls.Add(txtNombreCliente);
            Controls.Add(txtIdCliente);
            Controls.Add(btnCargarCliente);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.FromArgb(64, 64, 64);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Clientes";
            Text = "Clientes";
            TransparencyKey = Color.FromArgb(64, 64, 64);
            Load += Clientes_Load;
            ((System.ComponentModel.ISupportInitialize)gridCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnCargarCliente;
        private TextBox txtIdCliente;
        private TextBox txtNombreCliente;
        private TextBox txtApellidoCliente;
        private TextBox txtDniCliente;
        private TextBox txtDireccionCliente;
        private TextBox txtBuscarCliente;
        private DataGridView gridCliente;
        private Button btnModificarCliente;
        private Button btnEliminarCliente;
        private ComboBox cboCiudadCliente;
        private Button btnLimpiarCampos;
        private Button btnAgregarCiudad;
    }
}