using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace Gestion
{
    public partial class Ciudades : Form
    {
        string conexionBD = ConfigurationManager.ConnectionStrings["conexionBD"].ToString();

        public Ciudades()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(conexionBD))
            {
                string query = "INSERT INTO Ciudades (IdCiudad, NombreCiudad, CodigoPostal) VALUES (@IdCiudad, @NombreCiudad, @CodigoPostal)";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdCiudad", txtIdCiudad.Text);
                    command.Parameters.AddWithValue("@NombreCiudad", txtCiudad.Text);
                    command.Parameters.AddWithValue("@CodigoPostal", txtCodPostal.Text);

                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Ciudad agregada exitosamente.");
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(conexionBD))
            {
                string query = "UPDATE Ciudades SET NombreCiudad = @NombreCiudad, CodigoPostal = @CodigoPostal WHERE IdCiudad = @IdCiudad";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdCiudad", txtIdCiudad.Text);
                    command.Parameters.AddWithValue("@NombreCiudad", txtCiudad.Text);
                    command.Parameters.AddWithValue("@CodigoPostal", txtCodPostal.Text);

                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Ciudad modificada exitosamente.");
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(conexionBD))
            {
                string query = "DELETE FROM Ciudades WHERE IdCiudad = @IdCiudad";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdCiudad", txtIdCiudad.Text);

                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Ciudad eliminada exitosamente.");
                }
            }
        }
    }
}
