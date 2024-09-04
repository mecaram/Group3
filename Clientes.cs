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

//BUSCADOR CON LIKE
//SELECT * FROM supermercadodb.clientes Where concat(nombre,' ',apellido) like '%juan lopez%';

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
        }

        public void gridCliente_SelectionChanged(object sender, EventArgs e)
        {
            // CARGAR DATOS DE LA GRILLA EN LOS TEXTBOX
            txtIdCliente.Text = gridCliente.CurrentRow.Cells["id_cliente"].Value.ToString();
            txtNombreCliente.Text = gridCliente.CurrentRow.Cells["nombre"].Value.ToString();
            txtApellidoCliente.Text = gridCliente.CurrentRow.Cells["apellido"].Value.ToString();
            txtDniCliente.Text = gridCliente.CurrentRow.Cells["dni"].Value.ToString();
            cboCiudadCliente.SelectedValue = gridCliente.CurrentRow.Cells["id_ciudad"].Value.ToString();
            txtDireccionCliente.Text = gridCliente.CurrentRow.Cells["direccion"].Value.ToString();
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea realmente eliminar este Registro ?", "Solicitud del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                MySqlConnection conexion = new MySqlConnection("Data Source= localhost; Initial Catalog = supermercadodb; Uid = root; Pwd = 1337");
                conexion.Open();

                string sentencia = string.Format("Delete From clientes Where id_cliente = {0}", txtIdCliente.Text.Trim());
                var cmdEliminar = new MySqlCommand(sentencia, conexion);
                cmdEliminar.ExecuteNonQuery();

                conexion.Close();
                Clientes_Load(sender, e);

                txtIdCliente.Clear();
                txtNombreCliente.Text = "";
                txtApellidoCliente.Text = "";
                txtDniCliente.Text = "";
                cboCiudadCliente.SelectedValue = 0;
                txtDireccionCliente.Text = "";
            }
        }

        private void btnCargarCliente_Click(object sender, EventArgs e)
        {
        MySqlConnection conexion = new MySqlConnection("Data Source= localhost; Initial Catalog = supermercadodb; Uid = root; Pwd = 1337");
        conexion.Open();

        string nombre = txtNombreCliente.Text;
        string apellido = txtApellidoCliente.Text;
        string dni = txtDniCliente.Text;
        int ciudad = Convert.ToInt32(cboCiudadCliente.SelectedValue);
        string direccion = txtDireccionCliente.Text;

        string cargaCliente = string.Format("INSERT INTO `supermercadodb`.`clientes` (`nombre`, `apellido`, `dni`, `id_ciudad`, `direccion`) VALUES ('{0}', '{1}', '{2}', {3}, '{4}');", nombre, apellido, dni, ciudad, direccion);

        var cmdCargar = new MySqlCommand(cargaCliente, conexion);
        cmdCargar.ExecuteNonQuery();

        conexion.Close();
        Clientes_Load(sender, e);
}

    }
}