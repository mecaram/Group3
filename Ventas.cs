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

        private int ultimaSeleccion = 1; // Almacena la última selección válida (variable utilizada en la funcion CargarProductos)
        private void CargarProductos(MySqlConnection conexion)
        {
            MySqlDataAdapter daProductos = new MySqlDataAdapter(
                "SELECT id_producto, nombre, precio_venta, stock_actual FROM productos", conexion);
            DataTable dtProductos = new DataTable();
            daProductos.Fill(dtProductos);

            // Agregar la opción "Seleccionar producto" como la primera fila
            DataRow rowDefault = dtProductos.NewRow();
            rowDefault["id_producto"] = -1; // ID ficticio para la opción por defecto
            rowDefault["nombre"] = "Seleccionar producto";
            rowDefault["precio_venta"] = 0; // Precio ficticio por defecto
            rowDefault["stock_actual"] = 0; // Stock ficticio por defecto
            dtProductos.Rows.InsertAt(rowDefault, 0);

            cboProductoNombre.DataSource = dtProductos;
            cboProductoNombre.DisplayMember = "nombre";
            cboProductoNombre.ValueMember = "id_producto";

            // Seleccionar la opción por defecto inicialmente
            cboProductoNombre.SelectedIndex = 0;

            // Manejador para evitar seleccionar la opción predeterminada nuevamente
            cboProductoNombre.SelectedIndexChanged += (s, e) =>
            {
                if (cboProductoNombre.SelectedIndex == 0) // Opción predeterminada
                {
                    // Volver automáticamente a la última selección válida
                    cboProductoNombre.SelectedIndex = ultimaSeleccion;
                }
                else
                {
                    // Actualizar la última selección válida
                    ultimaSeleccion = cboProductoNombre.SelectedIndex;
                }
            };
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

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo números (0-9) y la tecla de retroceso
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true; // No permite la entrada de caracteres no numéricos
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

                // Obtener el stock del producto seleccionado
                string queryStock = "SELECT stock_actual FROM productos WHERE id_producto = @id_producto";
                MySqlCommand cmdStock = new MySqlCommand(queryStock, conexion);
                cmdStock.Parameters.AddWithValue("@id_producto", cboProductoNombre.SelectedValue);
                object stockObj = cmdStock.ExecuteScalar();

                if (stockObj == null || Convert.ToInt32(stockObj) <= 0)
                {
                    MessageBox.Show("No hay stock disponible para este producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Salir del método si no hay stock disponible
                }

                int stockDisponible = Convert.ToInt32(stockObj);
                int cantidadSolicitada = int.Parse(txtCantidad.Text);

                if (cantidadSolicitada > stockDisponible)
                {
                    MessageBox.Show($"La cantidad solicitada excede el stock disponible. Stock disponible: {stockDisponible}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Salir del método si la cantidad solicitada excede el stock
                }

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

                // Actualizar el stock en la tabla productos
                string queryActualizarStock = "UPDATE productos SET stock_actual = stock_actual - @cantidad WHERE id_producto = @id_producto";
                using (MySqlCommand cmdActualizarStock = new MySqlCommand(queryActualizarStock, conexion))
                {
                    cmdActualizarStock.Parameters.AddWithValue("@cantidad", cantidadSolicitada);
                    cmdActualizarStock.Parameters.AddWithValue("@id_producto", cboProductoNombre.SelectedValue);
                    cmdActualizarStock.ExecuteNonQuery(); // Ejecutar actualización de stock
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
                    detalle_de_ventas.id_detalle,
                    detalle_de_ventas.id_venta,
                    productos.nombre AS producto,
                    detalle_de_ventas.cantidad,
                    detalle_de_ventas.precio_unitario,
                    detalle_de_ventas.subtotal
                FROM detalle_de_ventas
                LEFT JOIN productos ON detalle_de_ventas.id_producto = productos.id_producto
                WHERE detalle_de_ventas.id_venta = @id_venta
                ORDER BY detalle_de_ventas.id_detalle DESC";

                    MySqlDataAdapter da = new MySqlDataAdapter(query, conexion);
                    da.SelectCommand.Parameters.AddWithValue("@id_venta", txtIdVenta.Text); // Asegúrate de que txtIdVenta tiene el ID correcto
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Asigna los datos a la grilla
                    gridVenta.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los detalles de ventas en la grilla: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                // Filtro de búsqueda
                string sentencia = @"
            SELECT v.id_detalle, v.id_venta, v.id_producto, p.nombre AS producto, v.cantidad, v.precio_unitario, v.subtotal
            FROM detalle_de_ventas v
            JOIN productos p ON v.id_producto = p.id_producto
            WHERE v.id_venta = @id_venta";  // Siempre filtrar por id_venta

                // Agregar parámetros iniciales
                MySqlCommand cmdBuscar = new MySqlCommand(sentencia, conexion);
                cmdBuscar.Parameters.AddWithValue("@id_venta", txtIdVenta.Text);  // Filtro para id_venta

                // Verificar si txtBuscarVenta no está vacío y agregar filtros adicionales
                if (!string.IsNullOrWhiteSpace(txtBuscarVenta.Text))
                {
                    string filtro = "%" + txtBuscarVenta.Text + "%";  // Valor del filtro con comodines

                    sentencia += @"
                AND (p.nombre LIKE @producto OR v.cantidad LIKE @cantidad OR v.precio_unitario LIKE @precio_unitario)";  // Filtrar por nombre del producto, cantidad o precio unitario

                    cmdBuscar.CommandText = sentencia;
                    cmdBuscar.Parameters.AddWithValue("@producto", filtro);  // Filtro para el nombre del producto
                    cmdBuscar.Parameters.AddWithValue("@cantidad", filtro);  // Filtro para la cantidad
                    cmdBuscar.Parameters.AddWithValue("@precio_unitario", filtro);  // Filtro para el precio unitario
                }

                MySqlDataAdapter daBuscar = new MySqlDataAdapter(cmdBuscar);
                DataTable dtBuscar = new DataTable();
                daBuscar.Fill(dtBuscar);

                // Asignar los resultados de la búsqueda a la grilla
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




        private void ActualizarTotal()
        {
            using (MySqlConnection conexion = new MySqlConnection(conexionBD))
            {
                try
                {
                    conexion.Open();

                    // Calcular el total sumando los subtotales de detalle_de_ventas para la venta actual
                    string query = "SELECT SUM(subtotal) FROM detalle_de_ventas WHERE id_venta = @id_venta";

                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@id_venta", txtIdVenta.Text);
                        object resultado = cmd.ExecuteScalar();

                        // Si no hay productos en el detalle, el total será 0
                        decimal total = resultado != DBNull.Value ? Convert.ToDecimal(resultado) : 0;

                        // Actualizar el campo txtTotal con el nuevo total
                        txtTotal.Text = total.ToString("F2"); // Formato con 2 decimales
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al calcular el total: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



    }
}
