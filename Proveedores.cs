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
            //toma el textbox y lo deja vacio.
            txtIdProveedor.Clear();
            txtRazonSocialProveedor.Clear();
            txtCuitProveedor.Clear();
            txtTelefonoProveedor.Clear();
            txtDireccionProveedor.Clear();

        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            // Configurar la grilla, desactivamos algunas cosas
            gridProveedor.ReadOnly = true;   // Deshabilitar edición de celdas
            gridProveedor.MultiSelect = false;  // Deshabilitar selección múltiple
            gridProveedor.CurrentCell = null;   // Deshabilitar el resaltado de la fila actual
            gridProveedor.Enabled = false;     // Deshabilitar el campo id

            // Conectar a la base de datos
            // creamos la instancia conexion, llamando a la variable conexionDB en App.config
            using (MySqlConnection conexion = new MySqlConnection(conexionBD))
            {
                // Cargar clientes
                MySqlDataAdapter daProveedores = new MySqlDataAdapter(
                @"SELECT p.id_proveedor, p.razon_social, p.cuit, p.id_ciudad, p.telefono, p.direccion
                FROM proveedores p",
                conexionBD);

                //instancia tabla clientes, y un int con la cantidad de filas de registros existentes
                DataTable dtProveedores = new DataTable();
                int registrosProveedores = daProveedores.Fill(dtProveedores);

                //si existe almenos 1 registro, mostrará la cabecera con las columnas correspondientes
                //si hay 0 registros, devuelve una grid vacia
                if (registrosProveedores > 0)
                {
                    gridProveedor.DataSource = dtProveedores;
                }
                else
                {
                    gridProveedor.DataSource = null;
                }

                // Cargar ciudades
                //obtenemos los nombres de las ciudades mediante una 'foreign key'(FK).
                //esta FK enlaza el id_ciudad de la tabla ciudades con el id_ciudad de la tabla clientes
                MySqlDataAdapter daCiudades = new MySqlDataAdapter("Select * From ciudades", conexionBD);
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

        private void gridProveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //si se selecciona un registro, los datos de este se cargaran en los textbox
            if (gridProveedor.SelectedRows.Count > 0 && gridProveedor.CurrentRow != null && gridProveedor.CurrentRow.Cells["id_cliente"].Value != null)
            {
                txtIdProveedor.Text = gridProveedor.CurrentRow.Cells["id_proveedor"].Value.ToString();
                txtRazonSocialProveedor.Text = gridProveedor.CurrentRow.Cells["razon_social"].Value.ToString();
                txtCuitProveedor.Text = gridProveedor.CurrentRow.Cells["cuit"].Value.ToString();
                txtTelefonoProveedor.Text = gridProveedor.CurrentRow.Cells["telefono"].Value.ToString();
                txtDireccionProveedor.Text = gridProveedor.CurrentRow.Cells["direccion"].Value.ToString();

                // Acceso al nombre de la ciudad
                if (gridProveedor.CurrentRow.Cells["id_ciudad"].Value != null && !string.IsNullOrEmpty(gridProveedor.CurrentRow.Cells["id_ciudad"].Value.ToString()))
                {
                    cboCiudades.Text = gridProveedor.CurrentRow.Cells["id_ciudad"].Value.ToString();  // Muestra el nombre de la ciudad
                }
                else
                {
                    //cboCiudadCliente.SelectedIndex = -1;  // deselecciona si la ciudad no existe.
                }
            }
            else
            {
                LimpiarTextBox();  // Limpiar campos si no hay selección válida
            }
        }
    }
}
