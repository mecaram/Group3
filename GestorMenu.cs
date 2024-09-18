namespace Gestion
{
    public partial class GestorMenu : Form
    {
        public GestorMenu()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            clientes.ShowDialog();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            Proveedores proveedores = new Proveedores();
            proveedores.ShowDialog();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos();
            productos.ShowDialog();
        }

        private void GestorMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            Marcas marcas = new Marcas();
            marcas.ShowDialog();
        }

        private void btnRubros_Click(object sender, EventArgs e)
        {
            Rubros rubros = new Rubros();
            rubros.ShowDialog();
        }

        private void btnCiudades_Click(object sender, EventArgs e)
        {
            //Ciudades ciudades = new Ciudades();
            //ciudades.ShowDialog();
        }

        private void btnMediosDePagos_Click(object sender, EventArgs e)
        {
            MediosDePagos mediosDePagos = new MediosDePagos();
            mediosDePagos.ShowDialog();
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            Compras compras = new Compras();
            compras.ShowDialog();
        }

        private void btnCierres_Click(object sender, EventArgs e)
        {
            Cierres cierres = new Cierres();
            cierres.ShowDialog();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            Ventas ventas = new Ventas();
            ventas.ShowDialog();
        }

        private void btnDetallesDeVentas_Click(object sender, EventArgs e)
        {
            DetallesDeVentas detallesDeVentas = new DetallesDeVentas();
            detallesDeVentas.ShowDialog();
        }

        private void btnAdministradores_Click(object sender, EventArgs e)
        {
            Administradores administradores = new Administradores();    
                administradores.ShowDialog();   
        }
    }
}
