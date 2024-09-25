using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Gestion
{
    public partial class Proveedores : Form
    {
        string conexionBD = ConfigurationManager.ConnectionStrings["conexionBD"].ToString();
        public Proveedores()
        {
            InitializeComponent();
        }

        // Método para limpiar los TextBox
        private void LimpiarTextBox()
        {
            txtIdProveedor.Clear();
            txtRazonSocialProveedor.Clear();
            txtCuitProveedor.Clear();
            txtTelefonoProveedor.Clear();
            txtDireccionProveedor.Clear();
        }

        // formulario proveedores
        private void Proveedores_Load(object sender, EventArgs e)
        {
            gridProveedor.ReadOnly = true;
            gridProveedor.MultiSelect = false;
            gridProveedor.CurrentCell = null;
            txtIdProveedor.Enabled = false;

            // Evitar que la columna de encabezado de fila sea visible
            gridProveedor.RowHeadersVisible = false;
            gridProveedor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            using (MySqlConnection conexion = new MySqlConnection(conexionBD))
            {
                // Cargar proveedores
                MySqlDataAdapter daProveedores = new MySqlDataAdapter(
                @"SELECT p.id_proveedor, p.razon_social, p.cuit, p.telefono, p.direccion, ciu.ciudad 
          FROM proveedores p
          JOIN ciudades ciu ON p.id_ciudad = ciu.id_ciudad",
                conexionBD);

                DataTable dtProveedores = new DataTable();
                int registrosProveedores = daProveedores.Fill(dtProveedores);

                if (registrosProveedores > 0)
                {
                    gridProveedor.DataSource = dtProveedores;
                }
                else
                {
                    gridProveedor.DataSource = null;
                }

                // Cargar ciudades
                MySqlDataAdapter daCiudades = new MySqlDataAdapter("SELECT * FROM ciudades", conexionBD);
                DataTable dtCiudades = new DataTable();
                int registrosCiudades = daCiudades.Fill(dtCiudades);

                if (registrosCiudades > 0)
                {
                    cboCiudades.DataSource = dtCiudades;
                    cboCiudades.DisplayMember = "ciudad";
                    cboCiudades.ValueMember = "id_ciudad";
                }
                else
                {
                    cboCiudades.DataSource = null;
                }
            }
        }


        // Selección de fila en grilla de proveedores
        private void gridProveedor_CellClick(object sender, EventArgs e)
        {
            if (gridProveedor.SelectedRows.Count > 0 && gridProveedor.CurrentRow != null && gridProveedor.CurrentRow.Cells["id_proveedor"].Value != null)
            {
                txtIdProveedor.Text = gridProveedor.CurrentRow.Cells["id_proveedor"].Value.ToString();
                txtRazonSocialProveedor.Text = gridProveedor.CurrentRow.Cells["razon_social"].Value.ToString();
                txtCuitProveedor.Text = gridProveedor.CurrentRow.Cells["cuit"].Value.ToString();
                txtTelefonoProveedor.Text = gridProveedor.CurrentRow.Cells["telefono"].Value.ToString();
                txtDireccionProveedor.Text = gridProveedor.CurrentRow.Cells["direccion"].Value.ToString();

                if (gridProveedor.CurrentRow.Cells["ciudad"].Value != null && !string.IsNullOrEmpty(gridProveedor.CurrentRow.Cells["ciudad"].Value.ToString()))
                {
                    cboCiudades.Text = gridProveedor.CurrentRow.Cells["ciudad"].Value.ToString();
                }
                else
                {
                    cboCiudades.SelectedIndex = -1;
                }
            }
            else
            {
                LimpiarTextBox();
            }
        }


        // Búsqueda en tiempo real de proveedores
        private void txtBuscarProveedor_TextChanged(object sender, EventArgs e)
        {
            using (MySqlConnection conexion = new MySqlConnection(conexionBD))
            {
                conexion.Open();
                string sentencia = @"SELECT p.id_proveedor, p.razon_social, p.cuit, p.telefono, p.direccion, ciu.ciudad
                                     FROM proveedores p
                                     JOIN ciudades ciu ON p.id_ciudad = ciu.id_ciudad
                                     WHERE p.razon_social LIKE @filtro OR 
                                           p.cuit LIKE @filtro OR 
                                           p.telefono LIKE @filtro OR 
                                           p.direccion LIKE @filtro OR 
                                           ciu.ciudad LIKE @filtro";

                MySqlCommand cmdBuscar = new MySqlCommand(sentencia, conexion);
                cmdBuscar.Parameters.AddWithValue("@filtro", "%" + txtBuscarProveedor.Text + "%");

                MySqlDataAdapter daBuscar = new MySqlDataAdapter(cmdBuscar);
                DataTable dtBuscar = new DataTable();
                daBuscar.Fill(dtBuscar);

                gridProveedor.DataSource = dtBuscar.Rows.Count > 0 ? dtBuscar : null;
            }
        }

        // Botón para limpiar los campos
        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarTextBox();
        }

        // Registrar proveedor
        private void btnCargarProveedor_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtRazonSocialProveedor.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("El campo Razón Social solo acepta letras.");
                return;
            }

            if (!Regex.IsMatch(txtCuitProveedor.Text, @"^\d+$"))
            {
                MessageBox.Show("El campo CUIT solo acepta números.");
                return;
            }

            if (!Regex.IsMatch(txtTelefonoProveedor.Text, @"^\d+$"))
            {
                MessageBox.Show("El campo Teléfono solo acepta números.");
                return;
            }

            if (!Regex.IsMatch(txtDireccionProveedor.Text, @"^[a-zA-Z0-9\s]+$"))
            {
                MessageBox.Show("El campo Dirección solo acepta letras, números y espacios.");
                return;
            }

            try
            {
                using (MySqlConnection conexion = new MySqlConnection(conexionBD))
                {
                    conexion.Open();
                    string cargaProveedor = @"INSERT INTO `supermercadodb`.`proveedores` 
                                              (`razon_social`, `cuit`, `id_ciudad`, `telefono`, `direccion`) 
                                              VALUES (@razon_social, @cuit, @ciudad, @telefono, @direccion);";

                    using (MySqlCommand cmdCargar = new MySqlCommand(cargaProveedor, conexion))
                    {
                        cmdCargar.Parameters.AddWithValue("@razon_social", txtRazonSocialProveedor.Text);
                        cmdCargar.Parameters.AddWithValue("@cuit", txtCuitProveedor.Text);
                        cmdCargar.Parameters.AddWithValue("@ciudad", Convert.ToInt32(cboCiudades.SelectedValue));
                        cmdCargar.Parameters.AddWithValue("@telefono", txtTelefonoProveedor.Text);
                        cmdCargar.Parameters.AddWithValue("@direccion", txtDireccionProveedor.Text);

                        int filasAfectadas = cmdCargar.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Proveedor cargado exitosamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se pudo cargar el proveedor.");
                        }
                    }
                }

                Proveedores_Load(sender, e);
                LimpiarTextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar el proveedor: " + ex.Message);
            }
        }

        // Modificar proveedor
        private void btnModificarProveedor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdProveedor.Text))
            {
                MessageBox.Show("Seleccione un proveedor para modificar.");
                return;
            }

            if (!Regex.IsMatch(txtRazonSocialProveedor.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("El campo Razón Social solo acepta letras.");
                return;
            }

            if (!Regex.IsMatch(txtCuitProveedor.Text, @"^\d+$"))
            {
                MessageBox.Show("El campo CUIT solo acepta números.");
                return;
            }

            if (!Regex.IsMatch(txtTelefonoProveedor.Text, @"^\d+$"))
            {
                MessageBox.Show("El campo Teléfono solo acepta números.");
                return;
            }

            if (!Regex.IsMatch(txtDireccionProveedor.Text, @"^[a-zA-Z0-9\s]+$"))
            {
                MessageBox.Show("El campo Dirección solo acepta letras, números y espacios.");
                return;
            }

            try
            {
                using (MySqlConnection conexion = new MySqlConnection(conexionBD))
                {
                    conexion.Open();
                    string modificarProveedor = @"UPDATE `supermercadodb`.`proveedores` 
                                                  SET `razon_social` = @razon_social, `cuit` = @cuit, `id_ciudad` = @ciudad, 
                                                      `telefono` = @telefono, `direccion` = @direccion 
                                                  WHERE `id_proveedor` = @id_proveedor;";

                    using (MySqlCommand cmdModificar = new MySqlCommand(modificarProveedor, conexion))
                    {
                        cmdModificar.Parameters.AddWithValue("@razon_social", txtRazonSocialProveedor.Text);
                        cmdModificar.Parameters.AddWithValue("@cuit", txtCuitProveedor.Text);
                        cmdModificar.Parameters.AddWithValue("@ciudad", Convert.ToInt32(cboCiudades.SelectedValue));
                        cmdModificar.Parameters.AddWithValue("@telefono", txtTelefonoProveedor.Text);
                        cmdModificar.Parameters.AddWithValue("@direccion", txtDireccionProveedor.Text);
                        cmdModificar.Parameters.AddWithValue("@id_proveedor", Convert.ToInt32(txtIdProveedor.Text));

                        int filasAfectadas = cmdModificar.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Proveedor modificado exitosamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se pudo modificar el proveedor.");
                        }
                    }
                }

                Proveedores_Load(sender, e);
                LimpiarTextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al modificar el proveedor: " + ex.Message);
            }
        }

        // Eliminar proveedor
        private void btnEliminarProveedor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdProveedor.Text))
            {
                MessageBox.Show("Seleccione un proveedor para eliminar.");
                return;
            }

            try
            {
                using (MySqlConnection conexion = new MySqlConnection(conexionBD))
                {
                    conexion.Open();
                    string eliminarProveedor = @"DELETE FROM `supermercadodb`.`proveedores` 
                                                 WHERE `id_proveedor` = @id_proveedor;";

                    using (MySqlCommand cmdEliminar = new MySqlCommand(eliminarProveedor, conexion))
                    {
                        cmdEliminar.Parameters.AddWithValue("@id_proveedor", Convert.ToInt32(txtIdProveedor.Text));

                        int filasAfectadas = cmdEliminar.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Proveedor eliminado exitosamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar el proveedor.");
                        }
                    }
                }

                Proveedores_Load(sender, e);
                LimpiarTextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al eliminar el proveedor: " + ex.Message);
            }
        }


    }
}
