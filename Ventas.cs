using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace Gestion
{
    public partial class Ventas : Form
    {
        string conexionBD = ConfigurationManager.ConnectionStrings["conexionBD"].ToString();
        decimal precioUnitario;

        public Ventas()
        {
            InitializeComponent();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            // Configurar la grilla
            gridVenta.ReadOnly = true;
            gridVenta.MultiSelect = false;
            gridVenta.CurrentCell = null;
            txtIdVenta.Enabled = false;
            txtFechaDeVenta.Enabled = false;
            txtTotal.Enabled = false;
            txtIdCierre.Enabled = false;
            txtPrecioUnitario.Enabled = false;
            txtSubTotal.Enabled = false;

            //para mayor comodidad, poner por defecto 1 solo producto
            txtCantidad.Text = "1";



            // Conectar a la base de datos y cargar las ventas
            using (MySqlConnection conexion = new MySqlConnection(conexionBD))
            {
                CargarNuevaVenta();
                CargarVentasEnGrid();
                CargarClientes(conexion);
                CargarProductos(conexion);
                CargarMediosPago(conexion);
                CargarUltimoIdCierre(conexion);

            }
        }


        private void CargarClientes(MySqlConnection conexion)
        {
            MySqlDataAdapter daClientes = new MySqlDataAdapter(
                "SELECT id_cliente, CONCAT(nombre, ' ', apellido) AS nombre_completo FROM clientes", conexion);
            DataTable dtClientes = new DataTable();
            daClientes.Fill(dtClientes);

            cboClientes.DataSource = dtClientes.Rows.Count > 0 ? dtClientes : null;
            cboClientes.DisplayMember = "nombre_completo";
            cboClientes.ValueMember = "id_cliente";
        }

        private void CargarMediosPago(MySqlConnection conexion)
        {
            MySqlDataAdapter daMediosPago = new MySqlDataAdapter(
                "SELECT id_medio, medios_de_pago FROM medios_de_pagos", conexion);
            DataTable dtMediosPago = new DataTable();
            daMediosPago.Fill(dtMediosPago);

            cboMedioPago.DataSource = dtMediosPago.Rows.Count > 0 ? dtMediosPago : null;
            cboMedioPago.DisplayMember = "medios_de_pago";
            cboMedioPago.ValueMember = "id_medio";
        }

        private void CargarProductos(MySqlConnection conexion)
        {
            MySqlDataAdapter daProductos = new MySqlDataAdapter(
                "SELECT id_producto, nombre, precio_venta FROM productos", conexion);
            DataTable dtProductos = new DataTable();
            daProductos.Fill(dtProductos);

            // Agregar la opción "Seleccionar producto" como la primera fila
            DataRow rowDefault = dtProductos.NewRow();
            rowDefault["id_producto"] = 0; // ID ficticio para la opción por defecto
            rowDefault["nombre"] = "Seleccionar producto";
            rowDefault["precio_venta"] = 0; // Precio ficticio por defecto
            dtProductos.Rows.InsertAt(rowDefault, 0);

            cboProductoNombre.DataSource = dtProductos;
            cboProductoNombre.DisplayMember = "nombre";
            cboProductoNombre.ValueMember = "id_producto";

            // Seleccionar la opción por defecto
            cboProductoNombre.SelectedIndex = 0;
        }


        private void CargarUltimoIdCierre(MySqlConnection conexion)
        {
            string query = "SELECT MAX(id_cierre) FROM cierres";

            using (MySqlCommand cmd = new MySqlCommand(query, conexion))
            {
                conexion.Open();

                var result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    txtIdCierre.Text = result.ToString();
                }
                else
                {
                    txtIdCierre.Text = "1"; // Valor predeterminado si no se encuentra ningún id_cierre
                }

                conexion.Close();
            }
        }

        private void cboProductoNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProductoNombre.SelectedValue != null && cboProductoNombre.SelectedValue != DBNull.Value && cboProductoNombre.SelectedIndex != 0)
            {
                DataRowView selectedProduct = (DataRowView)cboProductoNombre.SelectedItem;
                if (selectedProduct != null)
                {
                    precioUnitario = Convert.ToDecimal(selectedProduct["precio_venta"]);
                    txtPrecioUnitario.Text = precioUnitario.ToString("0.00");
                    CalcularSubTotal();
                }
            }
        }

        private void CalcularSubTotal()
        {
            if (int.TryParse(txtCantidad.Text, out int cantidad))
            {
                decimal subtotal = precioUnitario * cantidad;
                txtSubTotal.Text = subtotal.ToString("0.00");
            }
            else
            {
                txtSubTotal.Text = "0.00";
            }
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            CalcularSubTotal();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            // Validar si el subtotal es 0
            if (decimal.TryParse(txtSubTotal.Text, out decimal subtotal) && subtotal == 0)
            {
                MessageBox.Show("El subtotal no puede ser 0. Verifique los datos ingresados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método
            }

            using (MySqlConnection conexion = new MySqlConnection(conexionBD))
            {
                conexion.Open();


                // Código para insertar en la tabla detalle_de_ventas
                string queryDetalle = @"INSERT INTO detalle_de_ventas (id_venta, id_producto, cantidad, precio_unitario, subtotal)
                    VALUES (@id_venta, @id_producto, @cantidad, @precio_unitario, @subtotal)";
                using (MySqlCommand cmdDetalle = new MySqlCommand(queryDetalle, conexion))
                {
                    cmdDetalle.Parameters.AddWithValue("@id_venta", txtIdVenta.Text); // Usar el id de la venta recién creada
                    cmdDetalle.Parameters.AddWithValue("@id_producto", cboProductoNombre.SelectedValue); // ID del producto seleccionado
                    cmdDetalle.Parameters.AddWithValue("@cantidad", int.Parse(txtCantidad.Text)); // Cantidad ingresada
                    cmdDetalle.Parameters.AddWithValue("@precio_unitario", precioUnitario); // Precio unitario del producto
                    cmdDetalle.Parameters.AddWithValue("@subtotal", decimal.Parse(txtSubTotal.Text)); // Subtotal calculado

                    cmdDetalle.ExecuteNonQuery(); // Ejecutar inserción en detalle_de_ventas
                }

                CargarVentasEnGrid();
                txtTotal.Text = Convert.ToString(CalcularTotalVenta());

                // Deshabilitar los ComboBox
                cboClientes.Enabled = false;
                cboMedioPago.Enabled = false;

            }

        }


        private void CargarNuevaVenta()
        {

            using (MySqlConnection conexion = new MySqlConnection(conexionBD))
            {
                conexion.Open();

                /// Código para insertar en la tabla Ventas
                string queryVentas = @"INSERT INTO ventas (fecha_venta) VALUES (@fecha_venta)";
                using (MySqlCommand cmdVentas = new MySqlCommand(queryVentas, conexion))
                {
                    cmdVentas.Parameters.AddWithValue("@fecha_venta", DateTime.Now);  // Almacena fecha y hora actual

                    cmdVentas.ExecuteNonQuery();
                    int idVenta = (int)cmdVentas.LastInsertedId; // Captura el id de la venta recién insertada

                    txtIdVenta.Text = idVenta.ToString();
                    txtFechaDeVenta.Text = DateTime.Now.ToShortDateString();
                }
            }

        }

        private void CargarVentasEnGrid()
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(conexionBD))
                {
                    conexion.Open();
                    string query = @"
            SELECT 
                detalle_de_ventas.id_venta,
                productos.nombre AS producto,
                detalle_de_ventas.cantidad,
                detalle_de_ventas.precio_unitario,
                detalle_de_ventas.subtotal
            FROM detalle_de_ventas
            LEFT JOIN productos ON detalle_de_ventas.id_producto = productos.id_producto
            WHERE detalle_de_ventas.Id_Venta = " + txtIdVenta.Text;

                    MySqlDataAdapter da = new MySqlDataAdapter(query, conexion);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    gridVenta.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los detalles de ventas en la grilla: " + ex.Message);
            }
        }

        private double CalcularTotalVenta()
        {
            double totalVenta = 0;
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(conexionBD))
                {
                    conexion.Open();
                    string query = @"
            SELECT Sum(subtotal) as total
            FROM detalle_de_ventas
            WHERE detalle_de_ventas.Id_Venta = " + txtIdVenta.Text;

                    MySqlDataAdapter da = new MySqlDataAdapter(query, conexion);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    totalVenta = Convert.ToDouble(dt.Rows[0]["total"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los detalles de ventas en la grilla: " + ex.Message);
            }

            return totalVenta;
        }

        private void btnFormCliente_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            clientes.ShowDialog();
        }

        // Evento para limpiar todos los TextBox y ComboBox
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarTextBox();
        }

        private void LimpiarTextBox()
        {
            txtIdVenta.Clear();
            txtTotal.Clear();
            cboClientes.SelectedIndex = -1;
            cboMedioPago.SelectedIndex = -1;
            txtFechaDeVenta.Text = DateTime.Now.ToShortDateString();


        }



        private void gridVenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica que el índice de fila es válido (para evitar errores al hacer clic en una fila vacía)
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = gridVenta.Rows[e.RowIndex];

                // Asigna los valores de la fila seleccionada a los TextBox correspondientes
                txtIdVenta.Text = row.Cells["id_venta"].Value.ToString();
                cboClientes.Text = row.Cells["nombre_cliente"].Value.ToString();
                txtFechaDeVenta.Text = Convert.ToDateTime(row.Cells["fecha_venta"].Value).ToString("yyyy-MM-dd") + " " + DateTime.Now.ToString("HH:mm:ss");

                txtTotal.Text = row.Cells["total"].Value.ToString();
                cboMedioPago.Text = row.Cells["medio_de_pago"].Value.ToString();
                cboProductoNombre.Text = row.Cells["producto"].Value.ToString();
                txtCantidad.Text = row.Cells["cantidad"].Value.ToString();
                txtIdCierre.Text = row.Cells["id_cierre"].Value.ToString();

                // Calcular el precio unitario en base al total y cantidad, si está disponible
                if (decimal.TryParse(row.Cells["total"].Value.ToString(), out decimal total) &&
                    int.TryParse(row.Cells["cantidad"].Value.ToString(), out int cantidad) && cantidad > 0)
                {
                    precioUnitario = total / cantidad;
                    txtPrecioUnitario.Text = precioUnitario.ToString("0.00");
                    txtSubTotal.Text = (precioUnitario * cantidad).ToString("0.00");
                }
            }
        }

        private void txtBuscarVenta_TextChanged(object sender, EventArgs e)
        {
            using (MySqlConnection conexion = new MySqlConnection(conexionBD))
            {
                conexion.Open();
                string sentencia = @"SELECT v.id_venta, v.total, v.fecha_venta, c.nombre AS cliente, m.medios_de_pago 
                                     FROM ventas v
                                     JOIN clientes c ON v.id_cliente = c.id_cliente
                                     JOIN medios_de_pagos m ON v.id_medio_de_pago = m.id_medio
                                     WHERE c.nombre LIKE @filtro OR 
                                           v.total LIKE @filtro OR 
                                           m.medios_de_pago LIKE @filtro";

                MySqlCommand cmdBuscar = new MySqlCommand(sentencia, conexion);
                cmdBuscar.Parameters.AddWithValue("@filtro", "%" + txtBuscarVenta.Text + "%");

                MySqlDataAdapter daBuscar = new MySqlDataAdapter(cmdBuscar);
                DataTable dtBuscar = new DataTable();
                daBuscar.Fill(dtBuscar);

                gridVenta.DataSource = dtBuscar.Rows.Count > 0 ? dtBuscar : null;
            }
        }

        private void btnCancelarVenta_Click(object sender, EventArgs e)
        {
            //cerrar form
            this.Close();
        }

        private void btnCargarVenta_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conexion = new MySqlConnection(conexionBD))
            {
                try
                {
                    conexion.Open();

                    // Obtener el último id_cierre de la tabla cierres
                    string queryUltimoCierre = "SELECT MAX(id_cierre) FROM cierres";
                    int idUltimoCierre = 0;

                    using (MySqlCommand cmdUltimoCierre = new MySqlCommand(queryUltimoCierre, conexion))
                    {
                        object resultado = cmdUltimoCierre.ExecuteScalar();
                        idUltimoCierre = resultado != DBNull.Value ? Convert.ToInt32(resultado) : 1; // Si no hay registros, usa 1 por defecto
                    }

                    // Actualizar la tabla ventas con el id_cliente, total, id_medio_de_pago e id_cierre
                    string queryUpdateVentas = @"UPDATE ventas 
                                         SET id_cliente = @id_cliente, 
                                             total = @total, 
                                             id_medio_de_pago = @id_medio_pago, 
                                             id_cierre = @id_cierre 
                                         WHERE id_venta = @id_venta";

                    using (MySqlCommand cmdUpdate = new MySqlCommand(queryUpdateVentas, conexion))
                    {
                        cmdUpdate.Parameters.AddWithValue("@id_cliente", cboClientes.SelectedValue); // ID del cliente seleccionado
                        cmdUpdate.Parameters.AddWithValue("@total", decimal.Parse(txtTotal.Text)); // Total calculado
                        cmdUpdate.Parameters.AddWithValue("@id_medio_pago", cboMedioPago.SelectedValue); // ID del medio de pago seleccionado
                        cmdUpdate.Parameters.AddWithValue("@id_cierre", idUltimoCierre); // Último ID de cierre obtenido
                        cmdUpdate.Parameters.AddWithValue("@id_venta", txtIdVenta.Text); // ID de la venta actual

                        cmdUpdate.ExecuteNonQuery();
                    }

                    MessageBox.Show("Venta cargada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la venta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



    }
}
