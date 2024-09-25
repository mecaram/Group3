using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace Gestion
{
    public partial class Productos : Form
    {
        string conexionBD = ConfigurationManager.ConnectionStrings["conexionBD"].ToString();

        public Productos()
        {
            InitializeComponent();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            // Deshabilitar edición en la grilla y selección múltiple
            gridProductos.ReadOnly = true;
            gridProductos.MultiSelect = false;

            // Deshabilitar el campo de ID
            txtIdProducto.Enabled = false;

            // Cargar datos iniciales
            CargarCombos();
            CargarProductos();
        }

        // Método para cargar los datos en la grilla de productos
        private void CargarProductos()
        {
            using (MySqlConnection conexion = new MySqlConnection(conexionBD))
            {
                string query = @"SELECT p.id_producto, p.nombre, p.stock_actual, p.stock_minimo, 
                                        p.precio_de_costo, p.precio_ganancia, p.precio_venta,
                                        m.nombre AS marca, r.nombre AS rubro, pr.razon_social AS proveedor
                                 FROM productos p
                                 JOIN marcas m ON p.id_marca = m.id_marca
                                 JOIN rubros r ON p.id_rubro = r.id_rubro
                                 JOIN proveedores pr ON p.id_proveedor = pr.id_proveedor";

                MySqlDataAdapter daProductos = new MySqlDataAdapter(query, conexion);
                DataTable dtProductos = new DataTable();
                daProductos.Fill(dtProductos);

                gridProductos.DataSource = dtProductos;
            }
        }

        // Método para cargar los datos de los combos
        private void CargarCombos()
        {
            using (MySqlConnection conexion = new MySqlConnection(conexionBD))
            {
                // Cargar Combo de Marcas
                MySqlDataAdapter daMarcas = new MySqlDataAdapter("SELECT id_marca, nombre FROM marcas", conexion);
                DataTable dtMarcas = new DataTable();
                daMarcas.Fill(dtMarcas);
                cboMarca.DataSource = dtMarcas;
                cboMarca.DisplayMember = "nombre";
                cboMarca.ValueMember = "id_marca";

                // Cargar Combo de Rubros
                MySqlDataAdapter daRubros = new MySqlDataAdapter("SELECT id_rubro, nombre FROM rubros", conexion);
                DataTable dtRubros = new DataTable();
                daRubros.Fill(dtRubros);
                cboRubro.DataSource = dtRubros;
                cboRubro.DisplayMember = "nombre";
                cboRubro.ValueMember = "id_rubro";

                // Cargar Combo de Proveedores
                MySqlDataAdapter daProveedores = new MySqlDataAdapter("SELECT id_proveedor, razon_social FROM proveedores", conexion);
                DataTable dtProveedores = new DataTable();
                daProveedores.Fill(dtProveedores);
                cboProveedor.DataSource = dtProveedores;
                cboProveedor.DisplayMember = "razon_social";
                cboProveedor.ValueMember = "id_proveedor";
            }
        }

        // Evento para seleccionar un producto en la grilla
        private void gridProductos_SelectionChanged(object sender, EventArgs e)
        {
            if (gridProductos.SelectedRows.Count > 0 && gridProductos.CurrentRow != null)
            {
                // Cargar los datos en los TextBox y ComboBox
                txtIdProducto.Text = gridProductos.CurrentRow.Cells["id_producto"].Value.ToString();
                txtNombreProducto.Text = gridProductos.CurrentRow.Cells["nombre"].Value.ToString();
                txtStockActualProducto.Text = gridProductos.CurrentRow.Cells["stock_actual"].Value.ToString();
                txtStockMinimoProducto.Text = gridProductos.CurrentRow.Cells["stock_minimo"].Value.ToString();
                txtPrecioDeCostoProducto.Text = gridProductos.CurrentRow.Cells["precio_costo"].Value.ToString();
                txtPorcentajeGananciaProducto.Text = gridProductos.CurrentRow.Cells["precio_ganancia"].Value.ToString();
                txtPrecioDeVentaProducto.Text = gridProductos.CurrentRow.Cells["precio_venta"].Value.ToString();

                // Seleccionar los valores correctos en los ComboBox
                cboMarca.Text = gridProductos.CurrentRow.Cells["marca"].Value.ToString();
                cboRubro.Text = gridProductos.CurrentRow.Cells["rubro"].Value.ToString();
                cboProveedor.Text = gridProductos.CurrentRow.Cells["proveedor"].Value.ToString();
            }
        }

        // Evento para el botón Cargar Producto
        private void btnCargarProducto_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conexion = new MySqlConnection(conexionBD))
            {
                conexion.Open();

                string insertProducto = @"INSERT INTO productos 
                                          (nombre, id_marca, id_rubro, id_proveedor, stock_actual, stock_minimo, precio_costo, precio_ganancia, precio_venta)
                                          VALUES (@nombre, @id_marca, @id_rubro, @id_proveedor, @stock_actual, @stock_minimo, @precio_costo, @precio_ganancia, @precio_venta)";

                MySqlCommand cmd = new MySqlCommand(insertProducto, conexion);
                cmd.Parameters.AddWithValue("@nombre", txtNombreProducto.Text);
                cmd.Parameters.AddWithValue("@id_marca", cboMarca.SelectedValue);
                cmd.Parameters.AddWithValue("@id_rubro", cboRubro.SelectedValue);
                cmd.Parameters.AddWithValue("@id_proveedor", cboProveedor.SelectedValue);
                cmd.Parameters.AddWithValue("@stock_actual", txtStockActualProducto.Text);
                cmd.Parameters.AddWithValue("@stock_minimo", txtStockMinimoProducto.Text);
                cmd.Parameters.AddWithValue("@precio_costo", txtPrecioDeCostoProducto.Text);
                cmd.Parameters.AddWithValue("@precio_ganancia", txtPorcentajeGananciaProducto.Text);
                cmd.Parameters.AddWithValue("@precio_venta", txtPrecioDeVentaProducto.Text);

                int filasAfectadas = cmd.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Producto cargado exitosamente.");
                    CargarProductos();  // Recargar los datos de productos
                }
                else
                {
                    MessageBox.Show("No se pudo cargar el producto.");
                }
            }
        }

        // Evento para el botón Modificar Producto
        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdProducto.Text))
            {
                MessageBox.Show("Seleccione un producto para modificar.");
                return;
            }

            using (MySqlConnection conexion = new MySqlConnection(conexionBD))
            {
                conexion.Open();

                string updateProducto = @"UPDATE productos 
                                          SET nombre = @nombre, id_marca = @id_marca, id_rubro = @id_rubro, 
                                              id_proveedor = @id_proveedor, stock_actual = @stock_actual, 
                                              stock_minimo = @stock_minimo, precio_costo = @precio_costo, 
                                              precio_ganancia = @precio_ganancia, precio_venta = @precio_venta
                                          WHERE id_producto = @id_producto";

                MySqlCommand cmd = new MySqlCommand(updateProducto, conexion);
                cmd.Parameters.AddWithValue("@nombre", txtNombreProducto.Text);
                cmd.Parameters.AddWithValue("@id_marca", cboMarca.SelectedValue);
                cmd.Parameters.AddWithValue("@id_rubro", cboRubro.SelectedValue);
                cmd.Parameters.AddWithValue("@id_proveedor", cboProveedor.SelectedValue);
                cmd.Parameters.AddWithValue("@stock_actual", txtStockActualProducto.Text);
                cmd.Parameters.AddWithValue("@stock_minimo", txtStockMinimoProducto.Text);
                cmd.Parameters.AddWithValue("@precio_costo", txtPrecioDeCostoProducto.Text);
                cmd.Parameters.AddWithValue("@precio_ganancia", txtPorcentajeGananciaProducto.Text);
                cmd.Parameters.AddWithValue("@precio_venta", txtPrecioDeVentaProducto.Text);
                cmd.Parameters.AddWithValue("@id_producto", txtIdProducto.Text);

                int filasAfectadas = cmd.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Producto modificado exitosamente.");
                    CargarProductos();  // Recargar los datos de productos
                }
                else
                {
                    MessageBox.Show("No se pudo modificar el producto.");
                }
            }
        }

        // Evento para el botón Eliminar Producto
        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdProducto.Text))
            {
                MessageBox.Show("Seleccione un producto para eliminar.");
                return;
            }

            if (MessageBox.Show("¿Está seguro de que desea eliminar este producto?", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (MySqlConnection conexion = new MySqlConnection(conexionBD))
                {
                    conexion.Open();

                    string deleteProducto = "DELETE FROM productos WHERE id_producto = @id_producto";
                    MySqlCommand cmd = new MySqlCommand(deleteProducto, conexion);
                    cmd.Parameters.AddWithValue("@id_producto", txtIdProducto.Text);

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Producto eliminado exitosamente.");
                        CargarProductos();  // Recargar los datos de productos
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el producto.");
                    }
                }
            }
        }
    }
}
