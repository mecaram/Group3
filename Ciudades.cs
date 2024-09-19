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
    public partial class Ciudades : Form
    {
        string conexionBD = ConfigurationManager.ConnectionStrings["conexionBD"].ToString();

        public Ciudades()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Ciudades_Load(object sender, EventArgs e)
        {

        }
    }
}
