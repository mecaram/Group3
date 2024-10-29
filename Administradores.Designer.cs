
namespace Gestion
{
    partial class Administradores
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
            btnAgregarAdministrador = new Button();
            lblIdAdministradores = new Label();
            lblNombre = new Label();
            lblContraseña = new Label();
            gridAdministradores = new DataGridView();
            txtBuscar = new TextBox();
            txtIdAdministradores = new TextBox();
            txtNombre = new TextBox();
            txtContrasena = new TextBox();
            txtLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)gridAdministradores).BeginInit();
            SuspendLayout();
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.Silver;
            btnModificar.Location = new Point(38, 331);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 26);
            btnModificar.TabIndex = 0;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click_1;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Silver;
            btnEliminar.Location = new Point(138, 331);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 26);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // btnAgregarAdministrador
            // 
            btnAgregarAdministrador.BackColor = Color.Silver;
            btnAgregarAdministrador.Location = new Point(238, 331);
            btnAgregarAdministrador.Name = "btnAgregarAdministrador";
            btnAgregarAdministrador.Size = new Size(94, 26);
            btnAgregarAdministrador.TabIndex = 2;
            btnAgregarAdministrador.Text = "Agregar";
            btnAgregarAdministrador.UseVisualStyleBackColor = false;
            btnAgregarAdministrador.Click += btnAgregarAdministrador_Click;
            // 
            // lblIdAdministradores
            // 
            lblIdAdministradores.AutoSize = true;
            lblIdAdministradores.Location = new Point(30, 120);
            lblIdAdministradores.Name = "lblIdAdministradores";
            lblIdAdministradores.Size = new Size(139, 18);
            lblIdAdministradores.TabIndex = 3;
            lblIdAdministradores.Text = "Id Administradores:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(101, 180);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(65, 18);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre:";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(82, 235);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(87, 18);
            lblContraseña.TabIndex = 5;
            lblContraseña.Text = "Contraseña:";
            // 
            // gridAdministradores
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            gridAdministradores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            gridAdministradores.BackgroundColor = SystemColors.ScrollBar;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            gridAdministradores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            gridAdministradores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            gridAdministradores.DefaultCellStyle = dataGridViewCellStyle3;
            gridAdministradores.Location = new Point(392, 95);
            gridAdministradores.Name = "gridAdministradores";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            gridAdministradores.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            gridAdministradores.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            gridAdministradores.RowsDefaultCellStyle = dataGridViewCellStyle5;
            gridAdministradores.Size = new Size(429, 209);
            gridAdministradores.TabIndex = 6;
            gridAdministradores.CellClick += gridAdministradores_CellClick;
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = Color.Silver;
            txtBuscar.Location = new Point(392, 49);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(429, 26);
            txtBuscar.TabIndex = 7;
            txtBuscar.TextChanged += txtBuscar_TextChanged_1;
            // 
            // txtIdAdministradores
            // 
            txtIdAdministradores.BackColor = Color.Silver;
            txtIdAdministradores.Location = new Point(174, 113);
            txtIdAdministradores.Name = "txtIdAdministradores";
            txtIdAdministradores.Size = new Size(125, 26);
            txtIdAdministradores.TabIndex = 8;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.Silver;
            txtNombre.Location = new Point(174, 174);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 26);
            txtNombre.TabIndex = 9;
            // 
            // txtContrasena
            // 
            txtContrasena.BackColor = Color.Silver;
            txtContrasena.Location = new Point(174, 232);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(125, 26);
            txtContrasena.TabIndex = 10;
            // 
            // txtLimpiar
            // 
            txtLimpiar.BackColor = Color.Silver;
            txtLimpiar.Location = new Point(138, 376);
            txtLimpiar.Name = "txtLimpiar";
            txtLimpiar.Size = new Size(94, 26);
            txtLimpiar.TabIndex = 11;
            txtLimpiar.Text = "Limpiar";
            txtLimpiar.UseVisualStyleBackColor = false;
            txtLimpiar.Click += txtLimpiar_Click;
            // 
            // Administradores
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(917, 448);
            Controls.Add(txtLimpiar);
            Controls.Add(txtContrasena);
            Controls.Add(txtNombre);
            Controls.Add(txtIdAdministradores);
            Controls.Add(txtBuscar);
            Controls.Add(gridAdministradores);
            Controls.Add(lblContraseña);
            Controls.Add(lblNombre);
            Controls.Add(lblIdAdministradores);
            Controls.Add(btnAgregarAdministrador);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Administradores";
            Text = "Administradores";
            Load += Administradores_Load;
            ((System.ComponentModel.ISupportInitialize)gridAdministradores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Button btnModificar;
        private Button btnEliminar;
        private Button btnAgregarAdministrador;
        private Label lblIdAdministradores;
        private Label lblNombre;
        private Label lblContraseña;
        private DataGridView gridAdministradores;
        private TextBox txtBuscar;
        private TextBox txtIdAdministradores;
        private TextBox txtNombre;
        private TextBox txtContrasena;
        private Button txtLimpiar;
    }
}