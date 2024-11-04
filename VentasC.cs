using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Gestion
{
    public partial class VentasC : Form
    {
        string conexionBD = ConfigurationManager.ConnectionStrings["conexionBD"].ToString();
        MySqlConnection conexion;

        public VentasC()
        {
            InitializeComponent();
            CargarVentas();
            CargarComboBoxClientes();
            CargarComboBoxMediosDePago();

            // Asociar eventos
            btnBuscar.Click += btnBuscar_Click;
            btnEliminar.Click += btnEliminar_Click;
            btnComprobante.Click += btnComprobante_Click;

            dgvVentas.Columns.Add(new DataGridViewCheckBoxColumn() { Name = "Eliminar", HeaderText = "Eliminar", Width = 50 });
        }



        private void CargarVentas()
        {
            using (conexion = new MySqlConnection(conexionBD))
            {
                conexion.Open();
                // Cambia la consulta para incluir los nombres de cliente y medio de pago
                string query = @"SELECT v.id_venta, c.nombre AS cliente_nombre, c.apellido AS cliente_apellido, 
                                 v.fecha_venta, v.total, mp.medios_de_pago 
                                 FROM Ventas v
                                 JOIN Clientes c ON v.id_cliente = c.id_cliente
                                 JOIN Medios_de_Pagos mp ON v.id_medio_de_pago = mp.id_medio";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexion);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvVentas.DataSource = dataTable;

                // Actualiza el total de registros
                lblTotalRegistros.Text = $"Total Articulos: {dataTable.Rows.Count}";
            }
        }

        private void CargarComboBoxClientes()
        {
            using (conexion = new MySqlConnection(conexionBD))
            {
                conexion.Open();
                string query = "SELECT id_cliente, CONCAT(nombre, ' ', apellido) AS nombre_completo FROM Clientes";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cboClientes.Items.Add(new
                    {
                        Value = reader["id_cliente"],
                        Text = reader["nombre_completo"]
                    });
                }
                cboClientes.DisplayMember = "Text";
                cboClientes.ValueMember = "Value";
            }
        }

        private void CargarComboBoxMediosDePago()
        {
            using (conexion = new MySqlConnection(conexionBD))
            {
                conexion.Open();
                string query = "SELECT id_medio, medios_de_pago FROM Medios_de_Pagos";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cboMedioPago.Items.Add(new
                    {
                        Value = reader["id_medio"],
                        Text = reader["medios_de_pago"]
                    });
                }
                cboMedioPago.DisplayMember = "Text";
                cboMedioPago.ValueMember = "Value";
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            using (conexion = new MySqlConnection(conexionBD))
            {
                conexion.Open();
                string query = @"SELECT v.id_venta, c.nombre AS cliente_nombre, c.apellido AS cliente_apellido, 
                                 v.fecha_venta, v.total, mp.medios_de_pago 
                                 FROM Ventas v
                                 JOIN Clientes c ON v.id_cliente = c.id_cliente
                                 JOIN Medios_de_Pagos mp ON v.id_medio_de_pago = mp.id_medio
                                 WHERE v.fecha_venta BETWEEN @fechaInicio AND @fechaFin";

                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@fechaInicio", dtpFechaInicio.Value);
                cmd.Parameters.AddWithValue("@fechaFin", dtpFechaFin.Value);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvVentas.DataSource = dataTable;

                // Actualiza el total de registros
                lblTotalRegistros.Text = $"Total Articulos: {dataTable.Rows.Count}";
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (chkEliminar.Checked)
            {
                foreach (DataGridViewRow row in dgvVentas.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["Eliminar"].Value))
                    {
                        int idVenta = Convert.ToInt32(row.Cells["id_venta"].Value);
                        using (conexion = new MySqlConnection(conexionBD))
                        {
                            conexion.Open();
                            string query = "DELETE FROM Ventas WHERE id_venta = @idVenta";
                            MySqlCommand cmd = new MySqlCommand(query, conexion);
                            cmd.Parameters.AddWithValue("@idVenta", idVenta);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                CargarVentas(); // Actualiza la grid después de eliminar
            }
            else
            {
                MessageBox.Show("Selecciona las ventas que deseas eliminar.");
            }
        }

        private void btnComprobante_Click(object sender, EventArgs e)
        {
            if (dgvVentas.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvVentas.SelectedRows[0];
                int idVenta = Convert.ToInt32(selectedRow.Cells["id_venta"].Value);
                string cliente = $"{selectedRow.Cells["cliente_nombre"].Value} {selectedRow.Cells["cliente_apellido"].Value}";
                DateTime fecha = Convert.ToDateTime(selectedRow.Cells["fecha_venta"].Value);
                double total = Convert.ToDouble(selectedRow.Cells["total"].Value);

                // Código de impresión
                PrintDocument printDocument = new PrintDocument();
                printDocument.PrintPage += (s, ev) =>
                {
                    ev.Graphics.DrawString($"Comprobante de Venta", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new PointF(100, 100));
                    ev.Graphics.DrawString($"Cliente: {cliente}", new Font("Arial", 16), Brushes.Black, new PointF(100, 150));
                    ev.Graphics.DrawString($"Fecha: {fecha}", new Font("Arial", 16), Brushes.Black, new PointF(100, 180));
                    ev.Graphics.DrawString($"Total: ${total}", new Font("Arial", 16), Brushes.Black, new PointF(100, 210));
                };

                PrintPreviewDialog previewDialog = new PrintPreviewDialog
                {
                    Document = printDocument
                };
                previewDialog.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una venta para imprimir.");
            }
        }
    }
}
