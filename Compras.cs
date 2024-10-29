using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace Gestion
{
    public partial class Compras : Form
    {
        string conexionBD = ConfigurationManager.ConnectionStrings["conexionBD"].ToString();

        public Compras()
        {
            InitializeComponent();
        }

        // Método para cargar datos de compras al DataGridView
        private void CargarCompras()
        {
            using (MySqlConnection conexion = new MySqlConnection(conexionBD))
            {
                conexion.Open();
                MySqlDataAdapter daCompras = new MySqlDataAdapter("Select c.id_compra, c.id_producto, productos.nombre as producto, " +
                    "                                              c.id_proveedor, proveedores.razon_social, c.fecha_compra, c.precio_total, " +
                    "                                              c.cantidad_compra From compras c " +
                    "Left Join productos on c.id_producto = productos.id_producto " +
                    "Left join proveedores on c.id_proveedor = proveedores.id_proveedor order by c.id_compra desc", conexion);

                DataTable dtCompras = new DataTable();
                daCompras.Fill(dtCompras);

                gridCompras.DataSource = dtCompras;
            }
        }

        private void CargarProductos()
        {
            using (MySqlConnection conexion = new MySqlConnection(conexionBD))
            {
                conexion.Open();
                MySqlDataAdapter daProductos = new MySqlDataAdapter("Select * From Productos Order By Nombre", conexion);
                DataTable dtProductos = new DataTable();
                var registros = daProductos.Fill(dtProductos);
                if (registros > 0)
                {
                    cboIdProducto.DataSource = dtProductos;
                    cboIdProducto.ValueMember = "Id_Producto";
                    cboIdProducto.DisplayMember = "Nombre";
                }
                else
                    cboIdProducto.DataSource = null;
            }

        }

        private void CargarProveedor()
        {
            using (MySqlConnection conxion = new MySqlConnection(conexionBD))
            {
                conxion.Open();
                MySqlDataAdapter daProveedor = new MySqlDataAdapter("Select * From Proveedores Order By razon_social", conxion);
                DataTable dtProveedor = new DataTable();
                var registros = daProveedor.Fill(dtProveedor);
                if (registros > 0)
                {
                    cboIdProveedor.DataSource = dtProveedor;
                    cboIdProveedor.ValueMember = "Id_Proveedor";
                    cboIdProveedor.DisplayMember = "razon_social";
                }
                else
                    cboIdProveedor.DataSource = null;
            }
        }


        // Método que se ejecuta cuando el formulario carga
        private void Compras_Load(object sender, EventArgs e)
        {
            //desactivamos los textbox
            txtIdCompra.Enabled = false;
            txtIdCierre.Enabled = false;
            dateTimePicker1.Enabled = false;

            CargarProveedor();
            CargarProductos();
            CargarCompras();
        }

        // Agregar compra
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conexion = new MySqlConnection(conexionBD))
            {
                conexion.Open();
                string query = "INSERT INTO compras (id_producto, id_proveedor, fecha_compra, precio_total, cantidad_compra) " +
                               "VALUES (@id_producto, @id_proveedor, @fecha_compra, @precio_total, @cantidad_compra)";

                using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@id_producto", cboIdProducto.SelectedValue);
                    cmd.Parameters.AddWithValue("@id_proveedor", cboIdProveedor.SelectedValue);
                    cmd.Parameters.AddWithValue("@fecha_compra", DateTime.Now); // Puedes cambiar la fuente de la fecha
                    cmd.Parameters.AddWithValue("@precio_total", Convert.ToDecimal(txtPrecioCompra.Text));
                    cmd.Parameters.AddWithValue("@cantidad_compra", Convert.ToInt32(txtCantidadDeCompra.Text));

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Compra agregada exitosamente.");
                }
            }

            CargarCompras();
            LimpiarCampos();
        }

        // Modificar compra
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdCompra.Text))
            {
                MessageBox.Show("Seleccione una compra para modificar.");
                return;
            }

            using (MySqlConnection conexion = new MySqlConnection(conexionBD))
            {
                conexion.Open();
                string query = "UPDATE compras SET id_producto = @id_producto, id_proveedor = @id_proveedor, " +
                               "precio_total = @precio_total, cantidad_compra = @cantidad_compra WHERE id_compra = @id_compra";

                using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@id_compra", Convert.ToInt32(txtIdCompra.Text));
                    cmd.Parameters.AddWithValue("@id_producto", cboIdProducto.SelectedValue);
                    cmd.Parameters.AddWithValue("@id_proveedor", cboIdProveedor.SelectedValue);
                    cmd.Parameters.AddWithValue("@precio_total", Convert.ToDecimal(txtPrecioCompra.Text));
                    cmd.Parameters.AddWithValue("@cantidad_compra", Convert.ToInt32(txtCantidadDeCompra.Text));

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Compra modificada exitosamente.");
                }
            }

            CargarCompras();
            LimpiarCampos();
        }

        // Eliminar compra
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdCompra.Text))
            {
                MessageBox.Show("Seleccione una compra para eliminar.");
                return;
            }

            if (MessageBox.Show("¿Estás seguro de que deseas eliminar esta compra?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (MySqlConnection conexion = new MySqlConnection(conexionBD))
                {
                    conexion.Open();
                    string query = "DELETE FROM compras WHERE id_compra = @id_compra";

                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@id_compra", Convert.ToInt32(txtIdCompra.Text));
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Compra eliminada exitosamente.");
                    }
                }

                CargarCompras();
                LimpiarCampos();
            }
        }

        // Buscar compras
        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            using (MySqlConnection conexion = new MySqlConnection(conexionBD))
            {
                conexion.Open();
                string query = "Select c.id_compra, c.id_producto, productos.nombre as producto," +
                               "       c.id_proveedor, proveedores.razon_social, c.fecha_compra," +
                               "       c.precio_total, c.cantidad_compra " +
                               "From compras c" +
                               "Left Join productos on c.id_producto = productos.id_producto " +
                               "Left join proveedores on c.id_proveedor = proveedores.id_proveedor" +
                               "Where id_compra LIKE " +
                               "      OR id_producto LIKE @filtro";

                using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@filtro", "%" + txtBuscador.Text + "%");
                    MySqlDataAdapter daBuscar = new MySqlDataAdapter(cmd);

                    DataTable dtBuscar = new DataTable();
                    daBuscar.Fill(dtBuscar);

                    gridCompras.DataSource = dtBuscar;
                }
            }
        }

        // Selección de filas en la grilla para cargar los datos en los controles
        private void gridCompras_SelectionChanged(object sender, EventArgs e)
        {
            if (gridCompras.CurrentRow != null)
            {
                txtIdCompra.Text = gridCompras.CurrentRow.Cells["id_compra"].Value.ToString();
                cboIdProducto.SelectedValue = gridCompras.CurrentRow.Cells["id_producto"].Value.ToString();
                cboIdProveedor.SelectedValue = gridCompras.CurrentRow.Cells["id_proveedor"].Value.ToString();
                txtPrecioCompra.Text = gridCompras.CurrentRow.Cells["precio_total"].Value.ToString();
                txtCantidadDeCompra.Text = gridCompras.CurrentRow.Cells["cantidad_compra"].Value.ToString();
            }
        }

        // Método para limpiar los campos del formulario
        private void LimpiarCampos()
        {
            txtIdCompra.Clear();
            cboIdProducto.SelectedIndex = -1;
            cboIdProveedor.SelectedIndex = -1;
            txtPrecioCompra.Clear();
            txtCantidadDeCompra.Clear();
        }

        private void txtIdCompra_TextChanged(object sender, EventArgs e) { }
        private void cboIdProducto_SelectedIndexChanged(object sender, EventArgs e) { }
        private void cboIdProveedor_SelectedIndexChanged(object sender, EventArgs e) { }
        private void txtPrecioCompra_TextChanged(object sender, EventArgs e) { }
        private void txtCantidadDeCompra_TextChanged(object sender, EventArgs e) { }
        private void txtIdCierre_TextChanged(object sender, EventArgs e) { }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
