using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace Gestion
{
    public partial class MediosDePagos : Form
    {
        private string conexionBD = ConfigurationManager.ConnectionStrings["conexionBD"].ToString();
        private DataTable dtMediosDePagos;

        public MediosDePagos()
        {
            InitializeComponent();
            txtIdMedios.Enabled = false; // Deshabilitar el campo ID
            this.Load += new EventHandler(this.MediosDePagos_Load);
            this.gridMediosDePagos.SelectionChanged += new EventHandler(this.gridMediosDePagos_SelectionChanged);
        }

        // Método que se ejecuta al cargar el formulario
        private void MediosDePagos_Load(object sender, EventArgs e)
        {
            CargarMediosDePagos(); // Cargar medios de pago al iniciar el formulario
            ConfigurarGrilla(); // Configura la grilla de medios de pago
        }

        // Configuración de la grilla
        private void ConfigurarGrilla()
        {
            gridMediosDePagos.ReadOnly = true;
            gridMediosDePagos.MultiSelect = false;
            gridMediosDePagos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        // Cargar datos en la grilla
        private void CargarMediosDePagos()
        {
            using (MySqlConnection conexion = new MySqlConnection(conexionBD))
            {
                MySqlDataAdapter daMedios = new MySqlDataAdapter("SELECT * FROM medios_de_pagos", conexion);
                dtMediosDePagos = new DataTable();
                daMedios.Fill(dtMediosDePagos);
                gridMediosDePagos.DataSource = dtMediosDePagos;
            }
        }

        // Método que se ejecuta al seleccionar un registro de la grilla
        private void gridMediosDePagos_SelectionChanged(object sender, EventArgs e)
        {
            if (gridMediosDePagos.SelectedRows.Count > 0)
            {
                DataRowView rowView = (DataRowView)gridMediosDePagos.SelectedRows[0].DataBoundItem;
                txtIdMedios.Text = rowView["id_medio"].ToString(); // ID del medio de pago
                txtMediosdePagos.Text = rowView["medios_de_pago"].ToString(); // Nombre del medio de pago
            }
            else
            {
                LimpiarTextBoxes(); // Limpiar campos si no hay selección válida
            }
        }

        // Botón Agregar nuevo medio de pago
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMediosdePagos.Text))
            {
                MessageBox.Show("Por favor, ingrese un medio de pago.");
                return;
            }

            using (MySqlConnection conexion = new MySqlConnection(conexionBD))
            {
                conexion.Open();
                string query = "INSERT INTO medios_de_pagos (medios_de_pago) VALUES (@medios_de_pago)";
                using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@medios_de_pago", txtMediosdePagos.Text);
                    cmd.ExecuteNonQuery();
                }
            }

            CargarMediosDePagos(); // Refrescar la grilla
            LimpiarTextBoxes(); // Limpiar los campos
        }

        // Botón Modificar medio de pago seleccionado
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtIdMedios.Text, out int id) && !string.IsNullOrWhiteSpace(txtMediosdePagos.Text))
            {
                using (MySqlConnection conexion = new MySqlConnection(conexionBD))
                {
                    conexion.Open();
                    string query = "UPDATE medios_de_pagos SET medios_de_pago = @medios_de_pago WHERE id_medio = @id_medio";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@medios_de_pago", txtMediosdePagos.Text);
                        cmd.Parameters.AddWithValue("@id_medio", id);
                        cmd.ExecuteNonQuery();
                    }
                }
                CargarMediosDePagos(); // Refrescar la grilla
                LimpiarTextBoxes(); // Limpiar los campos
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un ID válido y un nuevo nombre.");
            }
        }

        // Botón Eliminar medio de pago seleccionado
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtIdMedios.Text, out int id))
            {
                // Mensaje de confirmación para eliminar
                if (MessageBox.Show("¿Desea realmente eliminar este medio de pago?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (MySqlConnection conexion = new MySqlConnection(conexionBD))
                    {
                        conexion.Open();
                        string query = "DELETE FROM medios_de_pagos WHERE id_medio = @id_medio";
                        using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                        {
                            // Corregimos el valor que se envía al parámetro
                            cmd.Parameters.AddWithValue("@id_medio", id);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    CargarMediosDePagos(); // Refrescar la grilla
                    LimpiarTextBoxes(); // Limpiar los campos
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un ID válido.");
            }
        }


        // Método para limpiar los TextBox
        private void LimpiarTextBoxes()
        {
            txtMediosdePagos.Clear();
            txtIdMedios.Clear(); // Limpiar el campo ID, aunque esté deshabilitado
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            using (MySqlConnection conexion = new MySqlConnection(conexionBD))
            {
                conexion.Open();
                string sentencia = @"SELECT m.id_medio, m.medios_de_pago
                                     FROM medios_de_pagos m
                                     WHERE m.id_medio LIKE @filtro OR 
                                           m.medios_de_pago LIKE @filtro";

                MySqlCommand cmdBuscar = new MySqlCommand(sentencia, conexion);
                cmdBuscar.Parameters.AddWithValue("@filtro", "%" + txtBuscar.Text + "%");

                MySqlDataAdapter daBuscar = new MySqlDataAdapter(cmdBuscar);
                DataTable dtBuscar = new DataTable();
                daBuscar.Fill(dtBuscar);

                gridMediosDePagos.DataSource = dtBuscar.Rows.Count > 0 ? dtBuscar : null;
            }
        }
    }
}
