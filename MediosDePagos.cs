using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Gestion
{
    public partial class MediosDePagos : Form
    {
        private List<MedioDePago> mediosDePagos = new List<MedioDePago>();
        private int currentId = 1;

        public MediosDePagos()
        {
            InitializeComponent();
            ActualizarGrid();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMediosdePagos.Text))
            {
                MessageBox.Show("Por favor, ingrese un medio de pago.");
                return;
            }

            var nuevoMedio = new MedioDePago
            {
                Id = currentId++,
                Nombre = txtMediosdePagos.Text
            };

            mediosDePagos.Add(nuevoMedio);
            ActualizarGrid();
            txtMediosdePagos.Clear();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtIdMedios.Text, out int id) && !string.IsNullOrWhiteSpace(txtMediosdePagos.Text))
            {
                var medio = mediosDePagos.FirstOrDefault(m => m.Id == id);
                if (medio != null)
                {
                    medio.Nombre = txtMediosdePagos.Text;
                    ActualizarGrid();
                    txtMediosdePagos.Clear();
                    txtIdMedios.Clear();
                }
                else
                {
                    MessageBox.Show("Medio de pago no encontrado.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un ID válido y un nuevo nombre.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtIdMedios.Text, out int id))
            {
                var medio = mediosDePagos.FirstOrDefault(m => m.Id == id);
                if (medio != null)
                {
                    mediosDePagos.Remove(medio);
                    ActualizarGrid();
                    txtMediosdePagos.Clear();
                    txtIdMedios.Clear();
                }
                else
                {
                    MessageBox.Show("Medio de pago no encontrado.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un ID válido.");
            }
        }

        private void ActualizarGrid()
        {
            gridMediosDePagos.DataSource = null;
            gridMediosDePagos.DataSource = mediosDePagos;
        }

     
    }

    public class MedioDePago
    {
        public int Id { get; set; }
        public required string Nombre { get; set; }
    }
}
