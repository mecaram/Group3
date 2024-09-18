using MySql.Data.MySqlClient;
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
            txtContrasenia.Clear();

        }

        private void Administradores_Load(object sender, EventArgs e)
        {
            // Configurar la grilla, desactivamos algunas cosas
            gridAdministradores.ReadOnly = true;   // Deshabilitar edición de celdas
            gridAdministradores.MultiSelect = false;  // Deshabilitar selección múltiple
            gridAdministradores.CurrentCell = null;   // Deshabilitar el resaltado de la fila actual
            txtIdAdministradores.Enabled = false;     // Deshabilitar el campo id

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
                    gridAdministradores.DataSource = dtClientes;
                }
                else
                {
                    gridAdministradores.DataSource = null;
                }
            }
    }

        private void txtLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarTextBox();
        }
    }
}
