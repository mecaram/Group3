using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Google.Protobuf.WellKnownTypes;

//BUSCADOR CON LIKE
//SELECT * FROM supermercadodb.clientes Where concat(nombre,' ',apellido) like '%juan lopez%';

//Corregir el crash de tocar el ultimo registro blanco de la grid

namespace Gestion
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            // Deshabilitar la edición de celdas en la grilla
            gridCliente.ReadOnly = true;

            // Habilitar la selección de filas completas
            gridCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Deshabilitar la opción de seleccionar múltiples filas
            gridCliente.MultiSelect = false;

            // Deshabilitar el resaltado de la fila actual
            gridCliente.CurrentCell = null;

            //deshabilitar campo id
            txtIdCliente.Enabled = false;

            // CONEXION BASE DE DATOS
            MySqlConnection conexion = new MySqlConnection("Data Source= localhost; Initial Catalog = supermercadodb; Uid = root; Pwd = 1337");

            MySqlDataAdapter da = new MySqlDataAdapter("Select * From clientes", conexion);

            // CARGAR DATOS EN LA GRILLA

            DataTable dt = new DataTable();

            int registros = da.Fill(dt);

            if (registros > 0)
            {
                gridCliente.DataSource = dt;
            }
            else
            {
                gridCliente.DataSource = null;
            }

            MySqlDataAdapter daCiudades = new MySqlDataAdapter("Select * From ciudades", conexion);

            // CARGAR DATOS EN LA GRILLA

            DataTable dtCiudades = new DataTable();

            registros = daCiudades.Fill(dtCiudades);

            if (registros > 0)
            {
                cboCiudadCliente.DataSource = dtCiudades;
                cboCiudadCliente.DisplayMember = "ciudad";
                cboCiudadCliente.ValueMember = "id_ciudad";
            }
            else
            {
                cboCiudadCliente.DataSource = null;
            }

            gridCliente.ClearSelection();
        }

        public void gridCliente_SelectionChanged(object sender, EventArgs e)
        {
            // Verificar que haya una fila seleccionada y que no sea una fila vacía
            if (gridCliente.SelectedRows.Count > 0 && gridCliente.CurrentRow != null && gridCliente.CurrentRow.Cells["id_cliente"].Value != null)
            {
                // Cargar los datos de la fila seleccionada en los TextBox solo si los valores no son nulos
                txtIdCliente.Text = gridCliente.CurrentRow.Cells["id_cliente"].Value.ToString();
                txtNombreCliente.Text = gridCliente.CurrentRow.Cells["nombre"].Value.ToString();
                txtApellidoCliente.Text = gridCliente.CurrentRow.Cells["apellido"].Value.ToString();
                txtDniCliente.Text = gridCliente.CurrentRow.Cells["dni"].Value.ToString();
                txtDireccionCliente.Text = gridCliente.CurrentRow.Cells["direccion"].Value.ToString();

                // Verificar si el valor de id_ciudad no es nulo o vacío antes de asignarlo
                if (gridCliente.CurrentRow.Cells["id_ciudad"].Value != null && !string.IsNullOrEmpty(gridCliente.CurrentRow.Cells["id_ciudad"].Value.ToString()))
                {
                    cboCiudadCliente.SelectedValue = Convert.ToInt32(gridCliente.CurrentRow.Cells["id_ciudad"].Value);
                }
                else
                {
                    // Si no hay una ciudad válida, deseleccionar cualquier selección en el ComboBox
                    cboCiudadCliente.SelectedIndex = -1;
                }
            }
            else
            {
                // Si no hay una fila válida seleccionada, limpiar los TextBox
                LimpiarTextBox();
            }
        }


        // Método para limpiar los TextBox
        private void LimpiarTextBox()
        {
            txtIdCliente.Clear();
            txtNombreCliente.Text = string.Empty;
            txtApellidoCliente.Text = string.Empty;
            txtDniCliente.Text = string.Empty;

            // Verificar si hay elementos en el ComboBox antes de seleccionar uno
            if (cboCiudadCliente.Items.Count > 0)
            {
                cboCiudadCliente.SelectedIndex = 0;  // Selecciona el primer ítem
            }
            else
            {
                cboCiudadCliente.SelectedIndex = -1;  // Si no hay elementos, deseleccionar cualquier selección
            }

            txtDireccionCliente.Text = string.Empty;
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            // Validar que se haya seleccionado un cliente
            if (string.IsNullOrEmpty(txtIdCliente.Text))
            {
                MessageBox.Show("Seleccione un cliente para modificar.");
                return;
            }

            // Validar que el campo DNI solo contenga números
            if (!int.TryParse(txtDniCliente.Text, out _))
            {
                MessageBox.Show("El campo DNI solo acepta números enteros.");
                return;
            }

            // Validar que el campo Nombre solo contenga letras y espacios
            if (!Regex.IsMatch(txtNombreCliente.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("El campo Nombre solo acepta letras.");
                return;
            }

            // Validar que el campo Apellido solo contenga letras y espacios
            if (!Regex.IsMatch(txtApellidoCliente.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("El campo Apellido solo acepta letras.");
                return;
            }

            // Validar que el campo Dirección no contenga caracteres especiales
            if (!Regex.IsMatch(txtDireccionCliente.Text, @"^[a-zA-Z0-9\s]+$"))
            {
                MessageBox.Show("El campo Dirección solo acepta letras, números y espacios.");
                return;
            }

            // Si las validaciones son correctas, procedemos a realizar la modificación
            try
            {
                using (MySqlConnection conexion = new MySqlConnection("Data Source= localhost; Initial Catalog = supermercadodb; Uid = root; Pwd = 1337"))
                {
                    conexion.Open();

                    // Consulta SQL para actualizar el cliente
                    string modificarCliente = "UPDATE `supermercadodb`.`clientes` " +
                                              "SET `nombre` = @nombre, `apellido` = @apellido, `dni` = @dni, `id_ciudad` = @ciudad, `direccion` = @direccion " +
                                              "WHERE `id_cliente` = @id_cliente;";

                    using (MySqlCommand cmdModificar = new MySqlCommand(modificarCliente, conexion))
                    {
                        // Asignar valores a los parámetros
                        cmdModificar.Parameters.AddWithValue("@nombre", txtNombreCliente.Text);
                        cmdModificar.Parameters.AddWithValue("@apellido", txtApellidoCliente.Text);
                        cmdModificar.Parameters.AddWithValue("@dni", txtDniCliente.Text);
                        cmdModificar.Parameters.AddWithValue("@ciudad", Convert.ToInt32(cboCiudadCliente.SelectedValue));
                        cmdModificar.Parameters.AddWithValue("@direccion", txtDireccionCliente.Text);
                        cmdModificar.Parameters.AddWithValue("@id_cliente", Convert.ToInt32(txtIdCliente.Text));

                        // Ejecutar el comando
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

                // Recargar los datos del formulario después de la modificación
                Clientes_Load(sender, e);

                // Limpiar los campos
                LimpiarTextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al modificar el cliente: " + ex.Message);
            }
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            //validar si se seleccionó un registro
            if (txtIdCliente.Text == "")
            {
                MessageBox.Show("No se seleccionó un registro.");
                return;
            }

            if (MessageBox.Show("Desea realmente eliminar este Registro ?", "Solicitud del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                MySqlConnection conexion = new MySqlConnection("Data Source= localhost; Initial Catalog = supermercadodb; Uid = root; Pwd = 1337");
                conexion.Open();

                string sentencia = string.Format("Delete From clientes Where id_cliente = {0}", txtIdCliente.Text.Trim());
                var cmdEliminar = new MySqlCommand(sentencia, conexion);

                cmdEliminar.ExecuteNonQuery();

                conexion.Close();
                Clientes_Load(sender, e);

                LimpiarTextBox();
            }
        }

        private void btnCargarCliente_Click(object sender, EventArgs e)
        {

            // Validar que el campo DNI solo contenga números
            if (!int.TryParse(txtDniCliente.Text, out _))
            {
                MessageBox.Show("El campo DNI solo acepta números enteros.");
                return;
            }

            // Validar que el campo Nombre solo contenga letras y espacios
            if (!Regex.IsMatch(txtNombreCliente.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("El campo Nombre solo acepta letras.");
                return;
            }

            // Validar que el campo Apellido solo contenga letras y espacios
            if (!Regex.IsMatch(txtApellidoCliente.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("El campo Apellido solo acepta letras.");
                return;
            }

            // Validar que el campo Dirección no contenga caracteres especiales
            if (!Regex.IsMatch(txtDireccionCliente.Text, @"^[a-zA-Z0-9\s]+$"))
            {
                MessageBox.Show("El campo Dirección solo acepta letras, números y espacios.");
                return;
            }

            // Si las validaciones son correctas, procedemos a realizar la inserción
            try
            {
                using (MySqlConnection conexion = new MySqlConnection("Data Source= localhost; Initial Catalog = supermercadodb; Uid = root; Pwd = 1337"))
                {
                    conexion.Open();

                    string cargaCliente = "INSERT INTO `supermercadodb`.`clientes` (`nombre`, `apellido`, `dni`, `id_ciudad`, `direccion`) VALUES (@nombre, @apellido, @dni, @ciudad, @direccion);";

                    using (MySqlCommand cmdCargar = new MySqlCommand(cargaCliente, conexion))
                    {
                        // Asignar valores a los parámetros
                        cmdCargar.Parameters.AddWithValue("@nombre", txtNombreCliente.Text);
                        cmdCargar.Parameters.AddWithValue("@apellido", txtApellidoCliente.Text);
                        cmdCargar.Parameters.AddWithValue("@dni", txtDniCliente.Text);
                        cmdCargar.Parameters.AddWithValue("@ciudad", Convert.ToInt32(cboCiudadCliente.SelectedValue));
                        cmdCargar.Parameters.AddWithValue("@direccion", txtDireccionCliente.Text);

                        // Ejecutar el comando
                        cmdCargar.ExecuteNonQuery();
                    }
                }

                // Recargar los datos del formulario después de la inserción
                Clientes_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar el cliente: " + ex.Message);
            }
        }

        private void txtBuscarCliente_TextChanged(object sender, EventArgs e)
        {
            // CONEXIÓN A LA BASE DE DATOS
            using (MySqlConnection conexion = new MySqlConnection("Data Source= localhost; Initial Catalog = supermercadodb; Uid = root; Pwd = 1337"))
            {
                conexion.Open();

                // Consulta SQL que busca coincidencias en varios campos
                string consulta = @"
            SELECT * 
            FROM clientes 
            WHERE 
                id_cliente LIKE @busqueda OR 
                nombre LIKE @busqueda OR 
                apellido LIKE @busqueda OR 
                dni LIKE @busqueda OR 
                id_ciudad LIKE @busqueda OR 
                direccion LIKE @busqueda";

                using (MySqlCommand cmdBuscar = new MySqlCommand(consulta, conexion))
                {
                    // Definir el parámetro de búsqueda usando el valor del TextBox
                    cmdBuscar.Parameters.AddWithValue("@busqueda", "%" + txtBuscarCliente.Text + "%");

                    // Adaptador de datos
                    MySqlDataAdapter da = new MySqlDataAdapter(cmdBuscar);

                    // Cargar los datos en una tabla
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Mostrar los resultados en la grilla
                    if (dt.Rows.Count > 0)
                    {
                        gridCliente.DataSource = dt;
                    }
                    else
                    {
                        gridCliente.DataSource = null;  // Si no hay resultados, limpiar la grilla
                    }
                }
            }
        }


    }
}