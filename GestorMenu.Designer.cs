namespace Gestion
{
    partial class GestorMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnClientes = new Button();
            btnProveedores = new Button();
            btnProductos = new Button();
            btnCiudades = new Button();
            btnMediosDePagos = new Button();
            btnMarcas = new Button();
            btnCompras = new Button();
            btnRubros = new Button();
            btnVentas = new Button();
            btnCierres = new Button();
            btnAdministradores = new Button();
            SuspendLayout();
            // 
            // btnClientes
            // 
            btnClientes.Location = new Point(74, 33);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(90, 44);
            btnClientes.TabIndex = 0;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnProveedores
            // 
            btnProveedores.Location = new Point(296, 33);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Size = new Size(90, 44);
            btnProveedores.TabIndex = 1;
            btnProveedores.Text = "Proveedores";
            btnProveedores.UseVisualStyleBackColor = true;
            btnProveedores.Click += btnProveedores_Click;
            // 
            // btnProductos
            // 
            btnProductos.Location = new Point(508, 33);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(90, 44);
            btnProductos.TabIndex = 2;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnCiudades
            // 
            btnCiudades.Location = new Point(508, 207);
            btnCiudades.Margin = new Padding(3, 2, 3, 2);
            btnCiudades.Name = "btnCiudades";
            btnCiudades.Size = new Size(90, 44);
            btnCiudades.TabIndex = 3;
            btnCiudades.Text = "Ciudades";
            btnCiudades.UseVisualStyleBackColor = true;
            btnCiudades.Click += btnCiudades_Click;
            // 
            // btnMediosDePagos
            // 
            btnMediosDePagos.Location = new Point(483, 298);
            btnMediosDePagos.Margin = new Padding(3, 2, 3, 2);
            btnMediosDePagos.Name = "btnMediosDePagos";
            btnMediosDePagos.Size = new Size(159, 44);
            btnMediosDePagos.TabIndex = 5;
            btnMediosDePagos.Text = "Medios de Pagos";
            btnMediosDePagos.UseVisualStyleBackColor = true;
            btnMediosDePagos.Click += btnMediosDePagos_Click;
            // 
            // btnMarcas
            // 
            btnMarcas.Location = new Point(508, 112);
            btnMarcas.Margin = new Padding(3, 2, 3, 2);
            btnMarcas.Name = "btnMarcas";
            btnMarcas.Size = new Size(90, 44);
            btnMarcas.TabIndex = 6;
            btnMarcas.Text = "Marcas";
            btnMarcas.UseVisualStyleBackColor = true;
            btnMarcas.Click += btnMarcas_Click;
            // 
            // btnCompras
            // 
            btnCompras.Location = new Point(74, 112);
            btnCompras.Margin = new Padding(3, 2, 3, 2);
            btnCompras.Name = "btnCompras";
            btnCompras.Size = new Size(89, 44);
            btnCompras.TabIndex = 7;
            btnCompras.Text = "Compras";
            btnCompras.UseVisualStyleBackColor = true;
            btnCompras.Click += btnCompras_Click;
            // 
            // btnRubros
            // 
            btnRubros.Location = new Point(296, 207);
            btnRubros.Margin = new Padding(3, 2, 3, 2);
            btnRubros.Name = "btnRubros";
            btnRubros.Size = new Size(90, 44);
            btnRubros.TabIndex = 8;
            btnRubros.Text = "Rubros";
            btnRubros.UseVisualStyleBackColor = true;
            btnRubros.Click += btnRubros_Click;
            // 
            // btnVentas
            // 
            btnVentas.Location = new Point(74, 207);
            btnVentas.Margin = new Padding(3, 2, 3, 2);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(90, 44);
            btnVentas.TabIndex = 9;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnCierres
            // 
            btnCierres.Location = new Point(296, 112);
            btnCierres.Margin = new Padding(3, 2, 3, 2);
            btnCierres.Name = "btnCierres";
            btnCierres.Size = new Size(90, 44);
            btnCierres.TabIndex = 10;
            btnCierres.Text = "Cierres";
            btnCierres.UseVisualStyleBackColor = true;
            btnCierres.Click += btnCierres_Click;
            // 
            // btnAdministradores
            // 
            btnAdministradores.Location = new Point(272, 298);
            btnAdministradores.Margin = new Padding(3, 2, 3, 2);
            btnAdministradores.Name = "btnAdministradores";
            btnAdministradores.Size = new Size(142, 44);
            btnAdministradores.TabIndex = 11;
            btnAdministradores.Text = "Administradores";
            btnAdministradores.UseVisualStyleBackColor = true;
            btnAdministradores.Click += btnAdministradores_Click;
            // 
            // GestorMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAdministradores);
            Controls.Add(btnCierres);
            Controls.Add(btnVentas);
            Controls.Add(btnRubros);
            Controls.Add(btnCompras);
            Controls.Add(btnMarcas);
            Controls.Add(btnMediosDePagos);
            Controls.Add(btnCiudades);
            Controls.Add(btnProductos);
            Controls.Add(btnProveedores);
            Controls.Add(btnClientes);
            Name = "GestorMenu";
            Text = "Menú Principal - Gestion";
            Load += GestorMenu_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnClientes;
        private Button btnProveedores;
        private Button btnProductos;
        private Button btnCiudades;
        private Button btnMediosDePagos;
        private Button btnMarcas;
        private Button btnCompras;
        private Button btnRubros;
        private Button btnVentas;
        private Button btnCierres;
        private Button btnAdministradores;
    }
}
