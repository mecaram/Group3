using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Gestion
{
    public partial class Clientes : Form
    {
        string conexionBD = ConfigurationManager.ConnectionStrings["conexionBD"].ToString();
        public Clientes()
        {
            InitializeComponent();
        }

        // Método para limpiar los TextBox
        private void LimpiarTextBox()
        {
            //toma el textbox y lo deja vacio.
            txtIdCliente.Clear();
            txtNombreCliente.Clear();
            txtApellidoCliente.Clear();
            txtDniCliente.Clear();
            txtDireccionCliente.Clear();

        }

        // formulario clientes
        private void Clientes_Load(object sender, EventArgs e)
        {
            // Configurar la grilla, desactivamos algunas cosas
            gridCliente.ReadOnly = true;   // Deshabilitar edición de celdas
            gridCliente.MultiSelect = false;  // Deshabilitar selección múltiple
            gridCliente.CurrentCell = null;   // Deshabilitar el resaltado de la fila actual
            txtIdCliente.Enabled = false;     // Deshabilitar el campo id

            // Conectar a la base de datos
            // creamos la instancia conexion, llamando a la variable conexionDB en App.config
            using (MySqlConnection conexion = new MySqlConnection(conexionBD))
            {
                // Cargar clientes
                MySqlDataAdapter daClientes = new MySqlDataAdapter(
                @"SELECT c.id_cliente, c.nombre, c.apellido, c.dni, c.direccion, ciu.ciudad 
                FROM clientes c
                JOIN ciudades ciu ON c.id_ciudad = ciu.id_ciudad",
                conexionBD);

                //instancia tabla clientes, y un int con la cantidad de filas de registros existentes
                DataTable dtClientes = new DataTable();
                int registrosClientes = daClientes.Fill(dtClientes);

                //si existe almenos 1 registro, mostrará la cabecera con las columnas correspondientes
                //si hay 0 registros, devuelve una grid vacia
                if (registrosClientes > 0)
                {
                    gridCliente.DataSource = dtClientes;
                }
                else
                {
                    gridCliente.DataSource = null;
                }

                // Cargar ciudades
                //obtenemos los nombres de las ciudades mediante una 'foreign key'(FK).
                //esta FK enlaza el id_ciudad de la tabla ciudades con el id_ciudad de la tabla clientes
                MySqlDataAdapter daCiudades = new MySqlDataAdapter("Select * From ciudades", conexionBD);
                DataTable dtCiudades = new DataTable();
                int registrosCiudades = daCiudades.Fill(dtCiudades);

                if (registrosCiudades > 0)
                {
                    cboCiudadCliente.DataSource = dtCiudades;
                    cboCiudadCliente.DisplayMember = "ciudad";
                    cboCiudadCliente.ValueMember = "id_ciudad";
                }
                else
                {
                    cboCiudadCliente.DataSource = null;
                }
            }
        }

        //grilla clientes
        public void gridCliente_SelectionChanged(object sender, EventArgs e)
        {
            //si se selecciona un registro, los datos de este se cargaran en los textbox
            if (gridCliente.SelectedRows.Count > 0 && gridCliente.CurrentRow != null && gridCliente.CurrentRow.Cells["id_cliente"].Value != null)
            {
                txtIdCliente.Text = gridCliente.CurrentRow.Cells["id_cliente"].Value.ToString();
                txtNombreCliente.Text = gridCliente.CurrentRow.Cells["nombre"].Value.ToString();
                txtApellidoCliente.Text = gridCliente.CurrentRow.Cells["apellido"].Value.ToString();
                txtDniCliente.Text = gridCliente.CurrentRow.Cells["dni"].Value.ToString();
                txtDireccionCliente.Text = gridCliente.CurrentRow.Cells["direccion"].Value.ToString();

                // Acceso al nombre de la ciudad
                if (gridCliente.CurrentRow.Cells["ciudad"].Value != null && !string.IsNullOrEmpty(gridCliente.CurrentRow.Cells["ciudad"].Value.ToString()))
                {
                    cboCiudadCliente.Text = gridCliente.CurrentRow.Cells["ciudad"].Value.ToString();  // Muestra el nombre de la ciudad
                }
                else
                {
                    cboCiudadCliente.SelectedIndex = -1;  // deselecciona si la ciudad no existe.
                }
            }
            else
            {
                LimpiarTextBox();  // Limpiar campos si no hay selección válida
            }

        }

        //textbox buscar cliente en grilla
        private void txtBuscarCliente_TextChanged(object sender, EventArgs e)
        {
            //busqueda dinamica en tiempo real
            using (MySqlConnection conexion = new MySqlConnection(conexionBD))
            {
                conexion.Open();
                string sentencia = @"SELECT c.id_cliente, c.nombre, c.apellido, c.dni, c.direccion, ciu.ciudad 
                     FROM clientes c
                     JOIN ciudades ciu ON c.id_ciudad = ciu.id_ciudad
                     WHERE c.nombre LIKE @filtro OR 
                           c.apellido LIKE @filtro OR 
                           c.dni LIKE @filtro OR 
                           c.direccion LIKE @filtro OR 
                           ciu.ciudad LIKE @filtro";



                MySqlCommand cmdBuscar = new MySqlCommand(sentencia, conexion);
                cmdBuscar.Parameters.AddWithValue("@filtro", "%" + txtBuscarCliente.Text + "%");

                MySqlDataAdapter daBuscar = new MySqlDataAdapter(cmdBuscar);
                DataTable dtBuscar = new DataTable();
                daBuscar.Fill(dtBuscar);

                gridCliente.DataSource = dtBuscar.Rows.Count > 0 ? dtBuscar : null;
            }
        }

        //boton limpia textbox
        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarTextBox();
        }

        //registrar cliente
        private void btnCargarCliente_Click(object sender, EventArgs e)
        {
            // Validaciones
            if (!int.TryParse(txtDniCliente.Text, out _))
            {
                MessageBox.Show("El campo DNI solo acepta números enteros.");
                return;
            }

            if (!Regex.IsMatch(txtNombreCliente.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("El campo Nombre solo acepta letras.");
                return;
            }

            if (!Regex.IsMatch(txtApellidoCliente.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("El campo Apellido solo acepta letras.");
                return;
            }

            if (!Regex.IsMatch(txtDireccionCliente.Text, @"^[a-zA-Z0-9\s]+$"))
            {
                MessageBox.Show("El campo Dirección solo acepta letras, números y espacios.");
                return;
            }

            // Insertar el cliente
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(conexionBD))
                {
                    conexion.Open();

                    string cargaCliente = @"INSERT INTO `supermercadodb`.`clientes` (`nombre`, `apellido`, `dni`, `id_ciudad`, `direccion`) 
                                            VALUES (@nombre, @apellido, @dni, @ciudad, @direccion);";

                    using (MySqlCommand cmdCargar = new MySqlCommand(cargaCliente, conexion))
                    {
                        cmdCargar.Parameters.AddWithValue("@nombre", txtNombreCliente.Text);
                        cmdCargar.Parameters.AddWithValue("@apellido", txtApellidoCliente.Text);
                        cmdCargar.Parameters.AddWithValue("@dni", txtDniCliente.Text);
                        cmdCargar.Parameters.AddWithValue("@ciudad", Convert.ToInt32(cboCiudadCliente.SelectedValue));
                        cmdCargar.Parameters.AddWithValue("@direccion", txtDireccionCliente.Text);

                        int filasAfectadas = cmdCargar.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Cliente cargado exitosamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se pudo cargar el cliente.");
                        }
                    }
                }

                // Recargar datos y limpiar campos
                Clientes_Load(sender, e);
                LimpiarTextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar el cliente: " + ex.Message);
            }
        }

        //boton modificar cliente
        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            // Validaciones de campos
            if (string.IsNullOrEmpty(txtIdCliente.Text))
            {
                MessageBox.Show("Seleccione un cliente para modificar.");
                return;
            }

            if (!int.TryParse(txtDniCliente.Text, out _))
            {
                MessageBox.Show("El campo DNI solo acepta números enteros.");
                return;
            }

            if (!Regex.IsMatch(txtNombreCliente.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("El campo Nombre solo acepta letras.");
                return;
            }

            if (!Regex.IsMatch(txtApellidoCliente.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("El campo Apellido solo acepta letras.");
                return;
            }

            if (!Regex.IsMatch(txtDireccionCliente.Text, @"^[a-zA-Z0-9\s]+$"))
            {
                MessageBox.Show("El campo Dirección solo acepta letras, números y espacios.");
                return;
            }

            // Si las validaciones son correctas, modificar el cliente
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(conexionBD))
                {
                    conexion.Open();

                    string modificarCliente = @"UPDATE `supermercadodb`.`clientes` 
                                                SET `nombre` = @nombre, `apellido` = @apellido, `dni` = @dni, `id_ciudad` = @ciudad, `direccion` = @direccion 
                                                WHERE `id_cliente` = @id_cliente;";

                    using (MySqlCommand cmdModificar = new MySqlCommand(modificarCliente, conexion))
                    {
                        cmdModificar.Parameters.AddWithValue("@nombre", txtNombreCliente.Text);
                        cmdModificar.Parameters.AddWithValue("@apellido", txtApellidoCliente.Text);
                        cmdModificar.Parameters.AddWithValue("@dni", txtDniCliente.Text);
                        cmdModificar.Parameters.AddWithValue("@ciudad", Convert.ToInt32(cboCiudadCliente.SelectedValue));
                        cmdModificar.Parameters.AddWithValue("@direccion", txtDireccionCliente.Text);
                        cmdModificar.Parameters.AddWithValue("@id_cliente", Convert.ToInt32(txtIdCliente.Text));

                        int filasAfectadas = cmdModificar.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Cliente modificado exitosamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se pudo modificar el cliente.");
                        }
                    }
                }

                // Recargar datos y limpiar campos
                Clientes_Load(sender, e);
                LimpiarTextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al modificar el cliente: " + ex.Message);
            }
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdCliente.Text))
            {
                MessageBox.Show("No se seleccionó un registro.");
                return;
            }

            //mensaje de advertencia
            if (MessageBox.Show("Desea realmente eliminar este registro?", "Solicitud del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                using (MySqlConnection conexion = new MySqlConnection(conexionBD))
                {
                    conexion.Open();
                    string sentencia = $"DELETE FROM clientes WHERE id_cliente = {txtIdCliente.Text.Trim()}";
                    MySqlCommand cmdEliminar = new MySqlCommand(sentencia, conexion);
                    cmdEliminar.ExecuteNonQuery();
                    Clientes_Load(sender, e);
                    LimpiarTextBox();
                }
            }
        }

    }
}
