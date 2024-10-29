namespace Gestion
{
    partial class Proveedores
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
            gridProveedor = new DataGridView();
            txtBuscarProveedor = new TextBox();
            txtDireccionProveedor = new TextBox();
            txtTelefonoProveedor = new TextBox();
            txtCuitProveedor = new TextBox();
            txtRazonSocialProveedor = new TextBox();
            txtIdProveedor = new TextBox();
            btnCargarProveedor = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtEliminarProveedor = new Button();
            btnModificarProveedor = new Button();
            cboCiudades = new ComboBox();
            txtLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)gridProveedor).BeginInit();
            SuspendLayout();
            // 
            // gridProveedor
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            gridProveedor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            gridProveedor.BackgroundColor = SystemColors.ScrollBar;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            gridProveedor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            gridProveedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            gridProveedor.DefaultCellStyle = dataGridViewCellStyle3;
            gridProveedor.Location = new Point(312, 120);
            gridProveedor.Margin = new Padding(3, 4, 3, 4);
            gridProveedor.Name = "gridProveedor";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            gridProveedor.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            gridProveedor.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Bahnschrift SemiBold SemiConden", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            gridProveedor.RowsDefaultCellStyle = dataGridViewCellStyle5;
            gridProveedor.Size = new Size(569, 307);
            gridProveedor.TabIndex = 29;
            gridProveedor.CellClick += gridProveedor_CellClick;
            // 
            // txtBuscarProveedor
            // 
            txtBuscarProveedor.BackColor = Color.Silver;
            txtBuscarProveedor.Location = new Point(310, 56);
            txtBuscarProveedor.Margin = new Padding(3, 4, 3, 4);
            txtBuscarProveedor.Name = "txtBuscarProveedor";
            txtBuscarProveedor.Size = new Size(571, 27);
            txtBuscarProveedor.TabIndex = 28;
            txtBuscarProveedor.TextChanged += txtBuscarProveedor_TextChanged_1;
            // 
            // txtDireccionProveedor
            // 
            txtDireccionProveedor.BackColor = Color.Silver;
            txtDireccionProveedor.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDireccionProveedor.Location = new Point(117, 298);
            txtDireccionProveedor.Margin = new Padding(3, 4, 3, 4);
            txtDireccionProveedor.Name = "txtDireccionProveedor";
            txtDireccionProveedor.Size = new Size(114, 26);
            txtDireccionProveedor.TabIndex = 27;
            // 
            // txtTelefonoProveedor
            // 
            txtTelefonoProveedor.BackColor = Color.Silver;
            txtTelefonoProveedor.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTelefonoProveedor.Location = new Point(117, 250);
            txtTelefonoProveedor.Margin = new Padding(3, 4, 3, 4);
            txtTelefonoProveedor.Name = "txtTelefonoProveedor";
            txtTelefonoProveedor.Size = new Size(114, 26);
            txtTelefonoProveedor.TabIndex = 26;
            // 
            // txtCuitProveedor
            // 
            txtCuitProveedor.BackColor = Color.Silver;
            txtCuitProveedor.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCuitProveedor.Location = new Point(117, 150);
            txtCuitProveedor.Margin = new Padding(3, 4, 3, 4);
            txtCuitProveedor.Name = "txtCuitProveedor";
            txtCuitProveedor.Size = new Size(114, 26);
            txtCuitProveedor.TabIndex = 24;
            // 
            // txtRazonSocialProveedor
            // 
            txtRazonSocialProveedor.BackColor = Color.Silver;
            txtRazonSocialProveedor.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtRazonSocialProveedor.Location = new Point(117, 103);
            txtRazonSocialProveedor.Margin = new Padding(3, 4, 3, 4);
            txtRazonSocialProveedor.Name = "txtRazonSocialProveedor";
            txtRazonSocialProveedor.Size = new Size(114, 26);
            txtRazonSocialProveedor.TabIndex = 23;
            // 
            // txtIdProveedor
            // 
            txtIdProveedor.BackColor = Color.Silver;
            txtIdProveedor.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtIdProveedor.Location = new Point(117, 52);
            txtIdProveedor.Margin = new Padding(3, 4, 3, 4);
            txtIdProveedor.Name = "txtIdProveedor";
            txtIdProveedor.Size = new Size(114, 26);
            txtIdProveedor.TabIndex = 22;
            // 
            // btnCargarProveedor
            // 
            btnCargarProveedor.BackColor = Color.Silver;
            btnCargarProveedor.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCargarProveedor.Location = new Point(14, 420);
            btnCargarProveedor.Margin = new Padding(3, 4, 3, 4);
            btnCargarProveedor.Name = "btnCargarProveedor";
            btnCargarProveedor.Size = new Size(86, 31);
            btnCargarProveedor.TabIndex = 21;
            btnCargarProveedor.Text = "Cargar";
            btnCargarProveedor.UseVisualStyleBackColor = false;
            btnCargarProveedor.Click += btnCargarProveedor_Click_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(14, 103);
            label6.Name = "label6";
            label6.Size = new Size(96, 18);
            label6.TabIndex = 20;
            label6.Text = "Razon Social:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(67, 153);
            label5.Name = "label5";
            label5.Size = new Size(41, 18);
            label5.TabIndex = 19;
            label5.Text = "CUIT:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(51, 200);
            label4.Name = "label4";
            label4.Size = new Size(56, 18);
            label4.TabIndex = 18;
            label4.Text = "Ciudad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(40, 250);
            label3.Name = "label3";
            label3.Size = new Size(66, 18);
            label3.TabIndex = 17;
            label3.Text = "Telefono:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(35, 298);
            label2.Name = "label2";
            label2.Size = new Size(73, 18);
            label2.TabIndex = 16;
            label2.Text = "Direccion:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(78, 56);
            label1.Name = "label1";
            label1.Size = new Size(25, 18);
            label1.TabIndex = 15;
            label1.Text = "ID:";
            // 
            // txtEliminarProveedor
            // 
            txtEliminarProveedor.BackColor = Color.Silver;
            txtEliminarProveedor.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEliminarProveedor.Location = new Point(198, 420);
            txtEliminarProveedor.Margin = new Padding(3, 4, 3, 4);
            txtEliminarProveedor.Name = "txtEliminarProveedor";
            txtEliminarProveedor.Size = new Size(86, 31);
            txtEliminarProveedor.TabIndex = 30;
            txtEliminarProveedor.Text = "Eliminar";
            txtEliminarProveedor.UseVisualStyleBackColor = false;
            txtEliminarProveedor.Click += txtEliminarProveedor_Click;
            // 
            // btnModificarProveedor
            // 
            btnModificarProveedor.BackColor = Color.Silver;
            btnModificarProveedor.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificarProveedor.Location = new Point(105, 420);
            btnModificarProveedor.Margin = new Padding(3, 4, 3, 4);
            btnModificarProveedor.Name = "btnModificarProveedor";
            btnModificarProveedor.Size = new Size(86, 31);
            btnModificarProveedor.TabIndex = 31;
            btnModificarProveedor.Text = "Modificar";
            btnModificarProveedor.UseVisualStyleBackColor = false;
            btnModificarProveedor.Click += btnModificarProveedor_Click;
            // 
            // cboCiudades
            // 
            cboCiudades.BackColor = Color.Silver;
            cboCiudades.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cboCiudades.FormattingEnabled = true;
            cboCiudades.Location = new Point(117, 200);
            cboCiudades.Margin = new Padding(3, 4, 3, 4);
            cboCiudades.Name = "cboCiudades";
            cboCiudades.Size = new Size(138, 26);
            cboCiudades.TabIndex = 32;
            // 
            // txtLimpiar
            // 
            txtLimpiar.BackColor = Color.Silver;
            txtLimpiar.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtLimpiar.Location = new Point(105, 381);
            txtLimpiar.Margin = new Padding(3, 4, 3, 4);
            txtLimpiar.Name = "txtLimpiar";
            txtLimpiar.Size = new Size(86, 31);
            txtLimpiar.TabIndex = 33;
            txtLimpiar.Text = "Limpiar";
            txtLimpiar.UseVisualStyleBackColor = false;
            txtLimpiar.Click += txtLimpiar_Click;
            // 
            // Proveedores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(914, 600);
            Controls.Add(txtLimpiar);
            Controls.Add(cboCiudades);
            Controls.Add(btnModificarProveedor);
            Controls.Add(txtEliminarProveedor);
            Controls.Add(gridProveedor);
            Controls.Add(txtBuscarProveedor);
            Controls.Add(txtDireccionProveedor);
            Controls.Add(txtTelefonoProveedor);
            Controls.Add(txtCuitProveedor);
            Controls.Add(txtRazonSocialProveedor);
            Controls.Add(txtIdProveedor);
            Controls.Add(btnCargarProveedor);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Proveedores";
            Text = "Proveedores";
            Load += Proveedores_Load;
            ((System.ComponentModel.ISupportInitialize)gridProveedor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridProveedor;
        private TextBox txtBuscarProveedor;
        private TextBox txtDireccionProveedor;
        private TextBox txtTelefonoProveedor;
        private TextBox txtCuitProveedor;
        private TextBox txtRazonSocialProveedor;
        private TextBox txtIdProveedor;
        private Button btnCargarProveedor;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button txtEliminarProveedor;
        private Button btnModificarProveedor;
        private ComboBox cboCiudades;
        private Button txtLimpiar;
    }
}