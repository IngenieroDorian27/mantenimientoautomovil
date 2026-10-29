using Visual;

namespace ProyectoMantenimientos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mRegistrarCliente_Click(object sender, EventArgs e)
        {
            RegistroCliente registroClientes = new RegistroCliente();
            registroClientes.Visible = true;
        }

        private void mRegistrarMecanico_Click(object sender, EventArgs e)
        {
            RegistroMecanico registrarMecanico = new RegistroMecanico();
            registrarMecanico.Visible = true;
        }

        private void mRegistrarMantenimiento_Click(object sender, EventArgs e)
        {
            RegistroMantenimiento registrarmantenimiento = new RegistroMantenimiento();
            registrarmantenimiento.Visible = true;
        }

        private void mSalir_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnRegistroCliente_Click(object sender, EventArgs e)
        {
            RegistroCliente mostrar = new RegistroCliente();
            mostrar.Visible = true;
        }

        private void btnRegistroMecanico_Click(object sender, EventArgs e)
        {
            RegistroMecanico mostra1 = new RegistroMecanico();
            mostra1.Visible = true;
        }

        private void btnRegistroMant_Click(object sender, EventArgs e)
        {
            RegistroMantenimiento mostrar2 = new RegistroMantenimiento();
            mostrar2.Visible = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}