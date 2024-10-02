using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Gestion
{
    public partial class Rubros : Form
    {
        string conexionBD = ConfigurationManager.ConnectionStrings["conexionBD"].ToString();

        public Rubros()
        {
            InitializeComponent();
        }

        // Método para limpiar los TextBox
        private void LimpiarTextBox()
        {
            txtIdRubro.Clear();
            txtNombre.Clear();
        }

        // Evento que se ejecuta cuando se carga el formulario
        private void Rubros_Load(object sender, EventArgs e)
        {
            // Configurar la grilla
            //grdRubros.ReadOnly = true;  // La grilla no es editable
            //grdRubros.MultiSelect = false;  // Deshabilitar la selección múltiple
            //grdRubros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;  // Seleccionar filas completas

            // Desactivar el campo txtIdRubro para que no se pueda editar
            txtIdRubro.Enabled = false;

            // Llamamos a cargar los rubros en la grilla
            CargarRubros();
        }

        // Método para cargar los rubros desde la base de datos y mostrarlos en la grilla
        private void CargarRubros()
        {
            using (MySqlConnection conexion = new MySqlConnection(conexionBD))
            {
                try
                {
                    conexion.Open();
                    MySqlDataAdapter daRubros = new MySqlDataAdapter("SELECT id_rubro, nombre FROM rubros", conexion);
                    DataTable dtRubros = new DataTable();
                    daRubros.Fill(dtRubros);

                    if (dtRubros.Rows.Count > 0)
                    {
                        grdRubros.DataSource = dtRubros;
                        grdRubros.Refresh();
                    }
                    else
                    {
                        grdRubros.DataSource = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los rubros: " + ex.Message);
                }
            }
        }

        // Evento que se ejecuta cuando se selecciona un registro en la grilla
        private void grdRubros_SelectionChanged(object sender, EventArgs e)
        {
            // Si hay una fila seleccionada y válida, se cargan los datos en los TextBox
            if (grdRubros.SelectedRows.Count > 0 && grdRubros.CurrentRow != null)
            {
                txtIdRubro.Text = grdRubros.CurrentRow.Cells["id_rubro"].Value.ToString();
                txtNombre.Text = grdRubros.CurrentRow.Cells["nombre"].Value.ToString();
               
            }
            else
            {
                LimpiarTextBox();  // Limpiar los campos si no hay selección válida
            }
        }

        // Evento para el botón "Agregar"
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validaciones básicas
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El campo Nombre es obligatorio.");
                return;
            }

            // Insertar el nuevo rubro
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(conexionBD))
                {
                    conexion.Open();

                    string insertarRubro = "INSERT INTO rubros (nombre) VALUES (@nombre);";
                    using (MySqlCommand cmd = new MySqlCommand(insertarRubro, conexion))
                    {
                        cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Rubro agregado exitosamente.");
                            CargarRubros();  // Recargar la grilla
                            LimpiarTextBox();  // Limpiar los campos
                        }
                        else
                        {
                            MessageBox.Show("No se pudo agregar el rubro.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el rubro: " + ex.Message);
            }
        }

        // Evento para el botón "Modificar"
        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Validaciones
            if (string.IsNullOrWhiteSpace(txtIdRubro.Text))
            {
                MessageBox.Show("Seleccione un rubro para modificar.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El campo Nombre es obligatorio.");
                return;
            }

            // Actualizar el rubro seleccionado
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(conexionBD))
                {
                    conexion.Open();

                    string actualizarRubro = "UPDATE rubros SET nombre = @nombre WHERE id_rubro = @id_rubro;";
                    using (MySqlCommand cmd = new MySqlCommand(actualizarRubro, conexion))
                    {
                        cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                        cmd.Parameters.AddWithValue("@id_rubro", Convert.ToInt32(txtIdRubro.Text));

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Rubro modificado exitosamente.");
                            CargarRubros();  // Recargar la grilla
                            LimpiarTextBox();  // Limpiar los campos
                        }
                        else
                        {
                            MessageBox.Show("No se pudo modificar el rubro.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el rubro: " + ex.Message);
            }
        }

        // Evento para el botón "Eliminar"
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Validaciones
            if (string.IsNullOrWhiteSpace(txtIdRubro.Text))
            {
                MessageBox.Show("Seleccione un rubro para eliminar.");
                return;
            }

            // Confirmación para eliminar
            if (MessageBox.Show("¿Desea eliminar este rubro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conexion = new MySqlConnection(conexionBD))
                    {
                        conexion.Open();

                        string eliminarRubro = "DELETE FROM rubros WHERE id_rubro = @id_rubro;";
                        using (MySqlCommand cmd = new MySqlCommand(eliminarRubro, conexion))
                        {
                            cmd.Parameters.AddWithValue("@id_rubro", Convert.ToInt32(txtIdRubro.Text));

                            int filasAfectadas = cmd.ExecuteNonQuery();
                            if (filasAfectadas > 0)
                            {
                                MessageBox.Show("Rubro eliminado exitosamente.");
                                CargarRubros();  // Recargar la grilla
                                LimpiarTextBox();  // Limpiar los campos
                            }
                            else
                            {
                                MessageBox.Show("No se pudo eliminar el rubro.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el rubro: " + ex.Message);
                }
            }
        }

        // Evento para limpiar los campos
        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarTextBox();
        }

        private object GetDataSource()
        {
            return grdRubros.DataSource;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string textoBusqueda = txtBuscar.Text.Trim(); // Tomar el texto ingresado en el cuadro de búsqueda

            // Realizar la búsqueda en la base de datos
            using (MySqlConnection conexion = new MySqlConnection(conexionBD))
            {
                try
                {
                    conexion.Open();

                    // Consulta SQL que busca coincidencias en id_rubro o nombre usando LIKE
                    string consulta = "SELECT id_rubro, nombre FROM rubros WHERE id_rubro LIKE @busqueda OR nombre LIKE @busqueda;";
                    MySqlDataAdapter daRubros = new MySqlDataAdapter(consulta, conexion);

                    // Parametrizar la búsqueda para evitar inyección SQL
                    daRubros.SelectCommand.Parameters.AddWithValue("@busqueda", "%" + textoBusqueda + "%");

                    var cons = daRubros.SelectCommand.CommandText;
                    var cons2 = daRubros.SelectCommand.Parameters[0].Value.ToString();

                    DataTable dtRubros = new DataTable();
                    daRubros.Fill(dtRubros);

                    if (dtRubros.Rows.Count <= 0)
                    {
                        grdRubros.DataSource = null; // Limpiar la grilla si no hay resultados
                    }
                    else
                    {
                        grdRubros.DataSource = dtRubros; // Actualizar la grilla con los resultados filtrados
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al filtrar los rubros: " + ex.Message);
                }
            }
        }
    }
}
