using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            // CONEXION BASE DE DATOS

            MySqlConnection conexion = new MySqlConnection("Data Source= localhost; Initial Catalog = gestion; Uid = root; Pwd = 123456789");

            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM clientes", conexion);

            // CARGAR DATOS EN LA GRILLA

            DataTable dt = new DataTable();

            int registros = da.Fill(dt);

            if (registros > 0)
            {
                gridCliente.DataSource = dt;
            }
        }

        private void gridCliente_SelectionChanged(object sender, EventArgs e)
        {
            // CARGAR DATOS DE LA GRILLA EN LOS TEXTBOX
            txtIdCliente.Text = gridCliente.CurrentRow.Cells["id_cliente"].Value.ToString();
            txtNombreCliente.Text = gridCliente.CurrentRow.Cells["nombre"].Value.ToString();
            txtApellidoCliente.Text = gridCliente.CurrentRow.Cells["apellido"].Value.ToString();
            txtDniCliente.Text = gridCliente.CurrentRow.Cells["dni"].Value.ToString();
            txtCiudadCliente.Text = gridCliente.CurrentRow.Cells["id_ciudad"].Value.ToString();
            txtDireccionCliente.Text = gridCliente.CurrentRow.Cells["direccion"].Value.ToString();
        }
    }
}