namespace Gestion
{
    partial class Rubros
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
            lblIdRubro = new Label();
            lblNombre = new Label();
            txtIdRubro = new TextBox();
            txtNombre = new TextBox();
            txtBuscar = new TextBox();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnAgregar = new Button();
            grdRubros = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)grdRubros).BeginInit();
            SuspendLayout();
            // 
            // lblIdRubro
            // 
            lblIdRubro.AutoSize = true;
            lblIdRubro.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIdRubro.Location = new Point(80, 130);
            lblIdRubro.Name = "lblIdRubro";
            lblIdRubro.Size = new Size(67, 18);
            lblIdRubro.TabIndex = 0;
            lblIdRubro.Text = "Id Rubro:\r\n";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(80, 204);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(65, 18);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // txtIdRubro
            // 
            txtIdRubro.BackColor = Color.Silver;
            txtIdRubro.Location = new Point(163, 130);
            txtIdRubro.Name = "txtIdRubro";
            txtIdRubro.Size = new Size(125, 26);
            txtIdRubro.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.Silver;
            txtNombre.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(163, 204);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 26);
            txtNombre.TabIndex = 3;
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = Color.Silver;
            txtBuscar.Location = new Point(418, 84);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(446, 26);
            txtBuscar.TabIndex = 4;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.Silver;
            btnModificar.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificar.Location = new Point(32, 347);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 26);
            btnModificar.TabIndex = 6;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Silver;
            btnEliminar.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(142, 347);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 26);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.Silver;
            btnAgregar.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(254, 347);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 26);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // grdRubros
            // 
            grdRubros.AllowUserToAddRows = false;
            grdRubros.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            grdRubros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            grdRubros.BackgroundColor = SystemColors.ScrollBar;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            grdRubros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            grdRubros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            grdRubros.DefaultCellStyle = dataGridViewCellStyle3;
            grdRubros.GridColor = Color.Gray;
            grdRubros.Location = new Point(418, 130);
            grdRubros.Name = "grdRubros";
            grdRubros.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            grdRubros.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            grdRubros.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            grdRubros.RowsDefaultCellStyle = dataGridViewCellStyle5;
            grdRubros.Size = new Size(446, 204);
            grdRubros.TabIndex = 9;
            grdRubros.SelectionChanged += grdRubros_SelectionChanged;
            // 
            // Rubros
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(978, 449);
            Controls.Add(grdRubros);
            Controls.Add(btnAgregar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(txtBuscar);
            Controls.Add(txtNombre);
            Controls.Add(txtIdRubro);
            Controls.Add(lblNombre);
            Controls.Add(lblIdRubro);
            Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Rubros";
            Text = "Rubros";
            Load += Rubros_Load;
            ((System.ComponentModel.ISupportInitialize)grdRubros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIdRubro;
        private Label lblNombre;
        private TextBox txtIdRubro;
        private TextBox txtNombre;
        private TextBox txtBuscar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnAgregar;
        private DataGridView grdRubros;
    }
}