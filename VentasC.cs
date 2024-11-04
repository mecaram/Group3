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

            // Asociar los eventos de los botones
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
                string query = "SELECT * FROM Ventas"; // Agregar filtro si se desea
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexion);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvVentas.DataSource = dataTable;

                // Actualiza el total de registros
                lblTotalRegistros.Text = $"Total Articulos: {dataTable.Rows.Count}";
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            using (conexion = new MySqlConnection(conexionBD))
            {
                conexion.Open();
                string query = "SELECT * FROM Ventas WHERE fecha_venta BETWEEN @fechaInicio AND @fechaFin";
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
                        int idVenta = Convert.ToInt32(row.Cells["id_venta"].Value); // Asegúrate de que el ID de la venta está en la columna correspondiente
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
                string cliente = Convert.ToString(selectedRow.Cells["id_cliente"].Value);
                DateTime fecha = Convert.ToDateTime(selectedRow.Cells["fecha_venta"].Value);
                double total = Convert.ToDouble(selectedRow.Cells["total"].Value);

                // Aquí se puede implementar el código de impresión
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
