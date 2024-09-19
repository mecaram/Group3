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
    public partial class Ciudades : Form
    {
        string conexionBD = ConfigurationManager.ConnectionStrings["conexionBD"].ToString();

        public Ciudades()
        {
            InitializeComponent();
        }

        private void Ciudades_Load(object sender, EventArgs e)
        {
            // Configurar la grilla, desactivamos algunas cosas
            gridCiudades.ReadOnly = true;   // Deshabilitar edición de celdas
            gridCiudades.MultiSelect = false;  // Deshabilitar selección múltiple
            gridCiudades.CurrentCell = null;   // Deshabilitar el resaltado de la fila actual
            txtIdCiudad.Enabled = false;     // Deshabilitar el campo id

            // Conectar a la base de datos
            // creamos la instancia conexion, llamando a la variable conexionDB en App.config
            using (MySqlConnection conexion = new MySqlConnection(conexionBD))
            {
                // Cargar clientes
                MySqlDataAdapter daClientes = new MySqlDataAdapter(
                @"SELECT c.id_ciudad, c.ciudad, c.cod_postal
                FROM ciudades c",
                conexionBD);

                //instancia tabla clientes, y un int con la cantidad de filas de registros existentes
                DataTable dtClientes = new DataTable();
                int registrosClientes = daClientes.Fill(dtClientes);

                //si existe almenos 1 registro, mostrará la cabecera con las columnas correspondientes
                //si hay 0 registros, devuelve una grid vacia
                if (registrosClientes > 0)
                {
                    gridCiudades.DataSource = dtClientes;
                }
                else
                {
                    gridCiudades.DataSource = null;
                }
            }
        }

        // Método para limpiar los TextBox
        private void LimpiarTextBox()
        {
            //toma el textbox y lo deja vacio.
            txtIdCiudad.Clear();
            txtCiudad.Clear();
            txtCodPostal.Clear();

        }

        private void txtLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarTextBox();
        }

        private void gridCiudades_SelectionChanged(object sender, DataGridViewCellEventArgs e)
        {
            //si se selecciona un registro, los datos de este se cargaran en los textbox
            if (gridCiudades.SelectedRows.Count > 0 && gridCiudades.CurrentRow != null && gridCiudades.CurrentRow.Cells["id_ciudad"].Value != null)
            {
                txtIdCiudad.Text = gridCiudades.CurrentRow.Cells["id_ciudad"].Value.ToString();
                txtIdCiudad.Text = gridCiudades.CurrentRow.Cells["ciudad"].Value.ToString();
                txtCodPostal.Text = gridCiudades.CurrentRow.Cells["cod_postal"].Value.ToString();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validaciones
            if (!int.TryParse(txtCodPostal.Text, out _))
            {
                MessageBox.Show("El campo codigo postal solo acepta números enteros.");
                return;
            }

            if (!Regex.IsMatch(txtCiudad.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("El campo ciudad solo acepta letras.");
                return;
            }

            // Insertar el cliente
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(conexionBD))
                {
                    conexion.Open();

                    string cargaCliente = @"INSERT INTO `supermercadodb`.`ciudades` (`ciudad`, `cod_postal`) 
                                            VALUES (@ciudad, @cod_postal);";

                    using (MySqlCommand cmdCargar = new MySqlCommand(cargaCliente, conexion))
                    {
                        cmdCargar.Parameters.AddWithValue("@ciudad", txtCiudad.Text);
                        cmdCargar.Parameters.AddWithValue("@cod_postal", txtCodPostal.Text);

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
                Ciudades_Load(sender, e);
                LimpiarTextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar el cliente: " + ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Validaciones de campos
            if (string.IsNullOrEmpty(txtIdCiudad.Text))
            {
                MessageBox.Show("Seleccione una ciudad para modificar.");
                return;
            }

            if (!int.TryParse(txtCodPostal.Text, out _))
            {
                MessageBox.Show("El campo codigo postal solo acepta números enteros.");
                return;
            }

            if (!Regex.IsMatch(txtIdCiudad.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("El campo ciudad solo acepta letras.");
                return;
            }

            // Insertar el cliente
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(conexionBD))
                {
                    conexion.Open();

                    string cargaCliente = @"UPDATE `supermercadodb`.`ciudades` (`ciudad`, `cod_postal`) 
                                            VALUES (@ciudad, @cod_postal);";

                    using (MySqlCommand cmdCargar = new MySqlCommand(cargaCliente, conexion))
                    {
                        cmdCargar.Parameters.AddWithValue("@ciudad", txtCiudad.Text);
                        cmdCargar.Parameters.AddWithValue("@cod_postal", txtCodPostal.Text);

                        int filasAfectadas = cmdCargar.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Ciudad actualizada exitosamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se pudo actualizar la ciudad.");
                        }
                    }
                }

                // Recargar datos y limpiar campos
                Ciudades_Load(sender, e);
                LimpiarTextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar el cliente: " + ex.Message);

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
