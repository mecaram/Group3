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
                MySqlDataAdapter daClientes = new MySqlDataAdapter(query, conexion);
                DataTable dtClientes = new DataTable();
                daClientes.Fill(dtClientes);

                // Agregar la opción "No aplica"
                DataRow drNoAplica = dtClientes.NewRow();
                drNoAplica["id_cliente"] = DBNull.Value; // o puedes usar un valor especial como 0 o -1
                drNoAplica["nombre_completo"] = "No aplica";
                dtClientes.Rows.InsertAt(drNoAplica, 0);

                cboClientes.DataSource = dtClientes;
                cboClientes.DisplayMember = "nombre_completo";
                cboClientes.ValueMember = "id_cliente";
            }
        }

        private void CargarComboBoxMediosDePago()
        {
            using (conexion = new MySqlConnection(conexionBD))
            {
                conexion.Open();
                string query = "SELECT id_medio, medios_de_pago FROM Medios_de_Pagos";
                MySqlDataAdapter daMediosPago = new MySqlDataAdapter(query, conexion);
                DataTable dtMediosPago = new DataTable();
                daMediosPago.Fill(dtMediosPago);

                // Agregar la opción "No aplica"
                DataRow drNoAplica = dtMediosPago.NewRow();
                drNoAplica["id_medio"] = DBNull.Value; // o puedes usar un valor especial como 0 o -1
                drNoAplica["medios_de_pago"] = "No aplica";
                dtMediosPago.Rows.InsertAt(drNoAplica, 0);

                cboMedioPago.DataSource = dtMediosPago;
                cboMedioPago.DisplayMember = "medios_de_pago";
                cboMedioPago.ValueMember = "id_medio";
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
                         LEFT JOIN Clientes c ON v.id_cliente = c.id_cliente
                         LEFT JOIN Medios_de_Pagos mp ON v.id_medio_de_pago = mp.id_medio
                         WHERE v.fecha_venta BETWEEN @fechaInicio AND @fechaFin";

                // Si se seleccionó un cliente distinto a "No aplica"
                if (cboClientes.SelectedValue != DBNull.Value && cboClientes.SelectedValue != null)
                {
                    query += " AND v.id_cliente = @idCliente";
                }

                // Si se seleccionó un medio de pago distinto a "No aplica"
                if (cboMedioPago.SelectedValue != DBNull.Value && cboMedioPago.SelectedValue != null)
                {
                    query += " AND v.id_medio_de_pago = @idMedioPago";
                }

                MySqlCommand cmd = new MySqlCommand(query, conexion);

                DateTime inicio = dtpFechaInicio.Value.Date;
                DateTime fin = dtpFechaFin.Value.Date;

                // Ajustar el rango de fecha
                if (inicio == fin)
                {
                    cmd.Parameters.AddWithValue("@fechaInicio", inicio.ToString("yyyy-MM-dd 00:00:00"));
                    cmd.Parameters.AddWithValue("@fechaFin", fin.ToString("yyyy-MM-dd 23:59:59"));
                }
                else
                {
                    cmd.Parameters.AddWithValue("@fechaInicio", inicio.ToString("yyyy-MM-dd 00:00:00"));
                    cmd.Parameters.AddWithValue("@fechaFin", fin.ToString("yyyy-MM-dd 23:59:59"));
                }

                // Parámetro opcional para el cliente
                if (cboClientes.SelectedValue != DBNull.Value && cboClientes.SelectedValue != null)
                {
                    cmd.Parameters.AddWithValue("@idCliente", cboClientes.SelectedValue);
                }

                // Parámetro opcional para el medio de pago
                if (cboMedioPago.SelectedValue != DBNull.Value && cboMedioPago.SelectedValue != null)
                {
                    cmd.Parameters.AddWithValue("@idMedioPago", cboMedioPago.SelectedValue);
                }

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvVentas.DataSource = dataTable;

                // Actualiza el total de registros
                lblTotalRegistros.Text = $"Total Articulos: {dataTable.Rows.Count}";
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

        private void btnVentas_Click(object sender, EventArgs e)
        {
            //FORM VIEJO
            Ventas ventas = new Ventas();
            ventas.ShowDialog();
            btnBuscar_Click(sender, e);
        }
    }
}
