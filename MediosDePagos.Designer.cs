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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
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
            btnModificar.BackColor = Color.Silver;
            btnModificar.Location = new Point(66, 342);
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
            btnEliminar.Location = new Point(166, 342);
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
            btnAgregar.Location = new Point(266, 342);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 26);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblMediosDePagos
            // 
            lblMediosDePagos.AutoSize = true;
            lblMediosDePagos.Location = new Point(35, 220);
            lblMediosDePagos.Name = "lblMediosDePagos";
            lblMediosDePagos.Size = new Size(124, 18);
            lblMediosDePagos.TabIndex = 3;
            lblMediosDePagos.Text = "Medios de Pagos:";
            // 
            // lblIdMedios
            // 
            lblIdMedios.AutoSize = true;
            lblIdMedios.Location = new Point(82, 114);
            lblIdMedios.Name = "lblIdMedios";
            lblIdMedios.Size = new Size(75, 18);
            lblIdMedios.TabIndex = 4;
            lblIdMedios.Text = "Id Medios:";
            // 
            // gridMediosDePagos
            // 
            gridMediosDePagos.AllowUserToAddRows = false;
            gridMediosDePagos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            gridMediosDePagos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            gridMediosDePagos.BackgroundColor = SystemColors.ScrollBar;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            gridMediosDePagos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            gridMediosDePagos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            gridMediosDePagos.DefaultCellStyle = dataGridViewCellStyle3;
            gridMediosDePagos.Location = new Point(406, 140);
            gridMediosDePagos.Name = "gridMediosDePagos";
            gridMediosDePagos.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Bahnschrift SemiBold SemiConden", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            gridMediosDePagos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            gridMediosDePagos.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            gridMediosDePagos.RowsDefaultCellStyle = dataGridViewCellStyle5;
            gridMediosDePagos.Size = new Size(390, 169);
            gridMediosDePagos.TabIndex = 5;
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = Color.Silver;
            txtBuscar.Location = new Point(406, 90);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(390, 26);
            txtBuscar.TabIndex = 6;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // txtIdMedios
            // 
            txtIdMedios.BackColor = Color.Silver;
            txtIdMedios.Location = new Point(166, 112);
            txtIdMedios.Name = "txtIdMedios";
            txtIdMedios.Size = new Size(125, 26);
            txtIdMedios.TabIndex = 7;
            // 
            // txtMediosdePagos
            // 
            txtMediosdePagos.BackColor = Color.Silver;
            txtMediosdePagos.Location = new Point(166, 217);
            txtMediosdePagos.Name = "txtMediosdePagos";
            txtMediosdePagos.Size = new Size(125, 26);
            txtMediosdePagos.TabIndex = 8;
            // 
            // MediosDePagos
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(875, 406);
            Controls.Add(txtMediosdePagos);
            Controls.Add(txtIdMedios);
            Controls.Add(txtBuscar);
            Controls.Add(gridMediosDePagos);
            Controls.Add(lblIdMedios);
            Controls.Add(lblMediosDePagos);
            Controls.Add(btnAgregar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
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