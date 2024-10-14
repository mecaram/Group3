using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion
{
    public partial class Administradores : Form
    {
        string conexionBD = ConfigurationManager.ConnectionStrings["conexionBD"].ToString();
        public Administradores()
        {
            InitializeComponent();
        }
        // Método para limpiar los TextBox
        private void LimpiarTextBox()
        {
            //toma el textbox y lo deja vacio.
            txtIdAdministradores.Clear();
            txtNombre.Clear();
            txtContrasena.Clear();

        }

        private void Administradores_Load(object sender, EventArgs e)
        {
            // Configurar la grilla, desactivamos algunas cosas
            gridAdministradores.ReadOnly = true;   // Deshabilitar edición de celdas
            gridAdministradores.MultiSelect = false;  // Deshabilitar selección múltiple
            gridAdministradores.CurrentCell = null;   // Deshabilitar el resaltado de la fila actual
            txtIdAdministradores.Enabled = false;     // Deshabilitar el campo id

            gridAdministradores.RowHeadersVisible = false;
            gridAdministradores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // Conectar a la base de datos
            // creamos la instancia conexion, llamando a la variable conexionDB en App.config
            using (MySqlConnection conexion = new MySqlConnection(conexionBD))
            {
                // Cargar administradores
                MySqlDataAdapter daAdministradores = new MySqlDataAdapter(
                @"SELECT c.id_admin, c.nombre, c.contrasena
                FROM administradores c",
                conexionBD);

                //instancia tabla administrador, y un int con la cantidad de filas de registros existentes
                DataTable dtAdministradores = new DataTable();
                int registrosAdministradores = daAdministradores.Fill(dtAdministradores);

                //si existe almenos 1 registro, mostrará la cabecera con las columnas correspondientes
                //si hay 0 registros, devuelve una grid vacia
                if (registrosAdministradores > 0)
                {
                    gridAdministradores.DataSource = dtAdministradores;
                }
                else
                {
                    gridAdministradores.DataSource = null;
                }
            }
        }
        //grilla Administradores
        private void gridAdministradores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //si se selecciona un registro, los datos de este se cargaran en los textbox
            if (gridAdministradores.SelectedRows.Count > 0 && gridAdministradores.CurrentRow != null && gridAdministradores.CurrentRow.Cells["id_admin"].Value != null)
            {
                txtIdAdministradores.Text = gridAdministradores.CurrentRow.Cells["id_admin"].Value.ToString();
                txtNombre.Text = gridAdministradores.CurrentRow.Cells["nombre"].Value.ToString();
                txtContrasena.Text = gridAdministradores.CurrentRow.Cells["contrasena"].Value.ToString();

                // Acceso al nombre del administrador
                //   if (grid.CurrentRow.Cells["ciudad"].Value != null && !string.IsNullOrEmpty(gridCliente.CurrentRow.Cells["ciudad"].Value.ToString()))
                //    {
                //        cboCiudadCliente.Text = gridCliente.CurrentRow.Cells["ciudad"].Value.ToString();  // Muestra el nombre de la ciudad
                //    }
                //    else
                //    {
                //        cboCiudadCliente.SelectedIndex = -1;  // deselecciona si la ciudad no existe.
                //    }
                //}
                //else
                //{
                //    LimpiarTextBox();  // Limpiar campos si no hay selección válida
                //}

            }
        }

        //textbox buscar cliente en grilla
        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        {
            //busqueda dinamica en tiempo real
            using (MySqlConnection conexion = new MySqlConnection(conexionBD))
            {
                conexion.Open();
                string sentencia = @"SELECT c.id_admin, c.nombre, c.contrasena
                     FROM administradores c
                     WHERE c.id_admin LIKE @filtro OR 
                           c.nombre LIKE @filtro OR
                           c.contrasena LIKE @filtro";


                MySqlCommand cmdBuscar = new MySqlCommand(sentencia, conexion);
                cmdBuscar.Parameters.AddWithValue("@filtro", "%" + txtBuscar.Text + "%");

                MySqlDataAdapter daBuscar = new MySqlDataAdapter(cmdBuscar);
                DataTable dtBuscar = new DataTable();
                daBuscar.Fill(dtBuscar);

                gridAdministradores.DataSource = dtBuscar.Rows.Count > 0 ? dtBuscar : null;
            }
        }

        private void txtLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarTextBox();
        }

        private void btnAgregarAdministrador_Click(object sender, EventArgs e)
        {
            // Validaciones


            if (!Regex.IsMatch(txtNombre.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("El campo Nombre solo acepta letras.");
                return;
            }

            if (!Regex.IsMatch(txtContrasena.Text, @"^[a-zA-Z0-9\s]+$"))
            {
                MessageBox.Show("El campo Contraseña solo acepta letras, números.");
                return;
            }

            // Insertar el cliente
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(conexionBD))
                {
                    conexion.Open();

                    string cargaCliente = @"INSERT INTO `supermercadodb`.`administradores` (`nombre`, `contrasena`) 
                                            VALUES (@nombre, @contrasena);";

                    using (MySqlCommand cmdCargar = new MySqlCommand(cargaCliente, conexion))
                    {
                        cmdCargar.Parameters.AddWithValue("@nombre", txtNombre.Text);
                        cmdCargar.Parameters.AddWithValue("@contrasena", txtContrasena.Text);


                        int filasAfectadas = cmdCargar.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Administrador cargado exitosamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se pudo cargar el administrador.");
                        }
                    }
                }

                // Recargar datos y limpiar campos
                Administradores_Load(sender, e);
                LimpiarTextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar el administrador: " + ex.Message);
            }

        }
        //boton modificar cliente
        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            // Validaciones de campos
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Seleccione un Administrador para modificar.");
                return;
            }

            if (!Regex.IsMatch(txtContrasena.Text, @"^[a-zA-Z0-9\s]+$"))
            {
                MessageBox.Show("El campo Contraseña solo acepta letras y números.");
                return;
            }

            // Si las validaciones son correctas, modificar el administrador
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(conexionBD))
                {
                    conexion.Open();

                    string modificarAdministrador = @"UPDATE `supermercadodb`.`administradores` 
                                                SET `nombre` = @nombre, `contrasena` = @contrasena  
                                                WHERE `id_admin` = @id_admin;";

                    using (MySqlCommand cmdModificar = new MySqlCommand(modificarAdministrador, conexion))
                    {
                        cmdModificar.Parameters.AddWithValue("@nombre", txtNombre.Text);

                        cmdModificar.Parameters.AddWithValue("@contrasena", txtContrasena.Text);

                        cmdModificar.Parameters.AddWithValue("@id_admin", Convert.ToInt32(txtIdAdministradores.Text));

                        int filasAfectadas = cmdModificar.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Administrador modificado exitosamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se pudo modificar el Administrador.");
                        }
                    }
                }

                // Recargar datos y limpiar campos
                Administradores_Load(sender, e);
                LimpiarTextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al modificar el Administrador: " + ex.Message);
            }
        }

        //eliminar administrador
        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdAdministradores.Text))
            {
                MessageBox.Show("No se seleccionó un Administrador.");
                return;
            }

            //mensaje de advertencia
            if (MessageBox.Show("Desea realmente eliminar este Administrador?", "Solicitud del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                using (MySqlConnection conexion = new MySqlConnection(conexionBD))
                {
                    conexion.Open();
                    string sentencia = $"DELETE FROM administradores WHERE id_admin = {txtIdAdministradores.Text.Trim()}";
                    MySqlCommand cmdEliminar = new MySqlCommand(sentencia, conexion);
                    cmdEliminar.ExecuteNonQuery();
                    Administradores_Load(sender, e);
                    LimpiarTextBox();
                }
            }
        }

    }
}
