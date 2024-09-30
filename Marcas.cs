using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace Gestion
{
    public partial class Marcas : Form
    {
        // Cadena de conexión
        string conexionBD = ConfigurationManager.ConnectionStrings["conexionBD"].ToString();

        public Marcas()
        {
            InitializeComponent();
        }

        // Método para limpiar los TextBox
        private void LimpiarTextBox()
        {
            txtIdMarca.Clear();
            txtNombre.Clear();
        }

        // Cargar las marcas en el DataGridView
        private void CargarMarcas()
        {
            using (MySqlConnection conexion = new MySqlConnection(conexionBD))
            {
                // Cargar marcas
                MySqlDataAdapter daMarcas = new MySqlDataAdapter("SELECT id_marca, nombre FROM marcas", conexionBD);
                DataTable dtMarcas = new DataTable();
                daMarcas.Fill(dtMarcas);

                if (dtMarcas.Rows.Count > 0)
                {
                    gridMarcas.DataSource = dtMarcas;
                    gridMarcas.AutoGenerateColumns = false; // Desactiva la generación automática de columnas
                }
                else
                {
                    gridMarcas.DataSource = null;
                }

                // Asegurarse de que no haya columnas extra
                if (gridMarcas.Columns.Count > 2)  // Asumiendo que hay solo 2 columnas: id_marca y nombre
                {
                    for (int i = gridMarcas.Columns.Count - 1; i >= 2; i--)
                    {
                        gridMarcas.Columns.RemoveAt(i);
                    }
                }
            }
        }

        // Evento que se ejecuta cuando se carga el formulario
        private void Marcas_Load(object sender, EventArgs e)
        {
            // Configuraciones iniciales
            gridMarcas.ReadOnly = true;
            gridMarcas.MultiSelect = false;
            gridMarcas.CurrentCell = null;
            txtIdMarca.Enabled = false;

            // Cargar las marcas en la grilla
            CargarMarcas();

            // Asignamos el evento CellClick
            gridMarcas.CellClick += gridMarcas_CellClick;
        }

        // Evento al hacer clic en cualquier celda de la fila
        private void gridMarcas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificamos si se hizo clic en una fila válida
            if (e.RowIndex >= 0)
            {
                // Obtenemos la fila actual
                DataGridViewRow fila = gridMarcas.Rows[e.RowIndex];

                // Asignamos los valores de las celdas a los TextBox
                txtIdMarca.Text = fila.Cells["id_marca"].Value.ToString();
                txtNombre.Text = fila.Cells["nombre"].Value.ToString();
            }
        }

        // Botón para agregar una nueva marca
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("El campo Nombre no puede estar vacío.");
                return;
            }

            try
            {
                using (MySqlConnection conexion = new MySqlConnection(conexionBD))
                {
                    conexion.Open();

                    string insertarMarca = "INSERT INTO marcas (nombre) VALUES (@nombre)";
                    using (MySqlCommand cmd = new MySqlCommand(insertarMarca, conexion))
                    {
                        cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Marca agregada exitosamente.");
                            CargarMarcas(); // Recargar la grilla
                            LimpiarTextBox(); // Limpiar los campos
                        }
                        else
                        {
                            MessageBox.Show("No se pudo agregar la marca.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la marca: " + ex.Message);
            }
        }

        // Botón para eliminar una marca
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdMarca.Text))
            {
                MessageBox.Show("Seleccione una marca para eliminar.");
                return;
            }

            if (MessageBox.Show("¿Está seguro de eliminar esta marca?", "Confirmar eliminación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conexion = new MySqlConnection(conexionBD))
                    {
                        conexion.Open();

                        string eliminarMarca = "DELETE FROM marcas WHERE id_marca = @id_marca";
                        using (MySqlCommand cmd = new MySqlCommand(eliminarMarca, conexion))
                        {
                            cmd.Parameters.AddWithValue("@id_marca", txtIdMarca.Text);

                            int filasAfectadas = cmd.ExecuteNonQuery();
                            if (filasAfectadas > 0)
                            {
                                MessageBox.Show("Marca eliminada exitosamente.");
                                CargarMarcas(); // Recargar la grilla
                                LimpiarTextBox(); // Limpiar los campos
                            }
                            else
                            {
                                MessageBox.Show("No se pudo eliminar la marca.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar la marca: " + ex.Message);
                }
            }
        }

        // Botón para modificar una marca
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdMarca.Text))
            {
                MessageBox.Show("Seleccione una marca para modificar.");
                return;
            }

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("El campo Nombre no puede estar vacío.");
                return;
            }

            try
            {
                using (MySqlConnection conexion = new MySqlConnection(conexionBD))
                {
                    conexion.Open();

                    string modificarMarca = "UPDATE marcas SET nombre = @nombre WHERE id_marca = @id_marca";
                    using (MySqlCommand cmd = new MySqlCommand(modificarMarca, conexion))
                    {
                        cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                        cmd.Parameters.AddWithValue("@id_marca", txtIdMarca.Text);

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Marca modificada exitosamente.");
                            CargarMarcas(); // Recargar la grilla
                            LimpiarTextBox(); // Limpiar los campos
                        }
                        else
                        {
                            MessageBox.Show("No se pudo modificar la marca.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar la marca: " + ex.Message);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            using (MySqlConnection conexion = new MySqlConnection(conexionBD))
            {
                conexion.Open();
                string sentencia = @"SELECT m.id_marca, m.nombre
                                     FROM marcas m
                                     WHERE m.id_marca LIKE @filtro OR 
                                           m.nombre LIKE @filtro";

                MySqlCommand cmdBuscar = new MySqlCommand(sentencia, conexion);
                cmdBuscar.Parameters.AddWithValue("@filtro", "%" + txtBuscar.Text + "%");

                MySqlDataAdapter daBuscar = new MySqlDataAdapter(cmdBuscar);
                DataTable dtBuscar = new DataTable();
                daBuscar.Fill(dtBuscar);

                gridMarcas.DataSource = dtBuscar.Rows.Count > 0 ? dtBuscar : null;
            }
        }

    }
}
