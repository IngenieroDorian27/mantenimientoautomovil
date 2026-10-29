using Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual
{
    public partial class RegistroCliente : Form
    {
        Administrador adm = Administrador.getAdm();
        public RegistroCliente()
        {
            InitializeComponent();
        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            String apeCliente = txtApeCliente.Text.Trim();
            String nomCliente = txtNomCliente.Text.Trim();
            String cdlCliente = txtCdlCliente.Text.Trim();
            String corrCliente = txtCorrCliente.Text.Trim();
            String telCliente = txtTlfCliente.Text.Trim();
            String placaVeh = txtPlacaVeh.Text.Trim();
            String marVeh = txtMarcaVeh.Text.Trim();
            String matrVehi = txtMatrVeh.Text.Trim();
            String kiloVeh = txtKiloVeh.Text.Trim();

            String contenido = "";

            if (apeCliente.CompareTo("") != 0 && nomCliente.CompareTo("") != 0 &&
                cdlCliente.CompareTo("") != 0 && corrCliente.CompareTo("") != 0 &&
                telCliente.CompareTo("") != 0 && placaVeh.CompareTo("") != 0 &&
                marVeh.CompareTo("") != 0 && matrVehi.CompareTo("") != 0 &&
                kiloVeh.CompareTo("") != 0)
            {
                contenido = adm.ingresarCliente(apeCliente, nomCliente, cdlCliente,
                corrCliente, telCliente, placaVeh, marVeh, matrVehi, kiloVeh);
                MessageBox.Show("Registro exitoso");
                txtboxContenido.Text = contenido;
            }
            else
            {
                MessageBox.Show("Existen campos vacios");
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtApeCliente.Text = string.Empty;
            txtNomCliente.Text = string.Empty;
            txtCdlCliente.Text = string.Empty;
            txtCorrCliente.Text = string.Empty;
            txtTlfCliente.Text = string.Empty;
            txtPlacaVeh.Text = string.Empty;
            txtMarcaVeh.Text = string.Empty;
            txtMatrVeh.Text = string.Empty;
            txtKiloVeh.Text = string.Empty;
            txtboxContenido.Text = string.Empty;
        }

        private void txtApeCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Error, solo se permiten letras.");
            }
        }

        private void RegistroCliente_Load(object sender, EventArgs e)
        {

        }

        private void txtNomCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Error, solo se permiten letras.");
            }
        }

        private void txtCdlCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Error, solo se permiten números.");
            }

        }

        private void txtCorrCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Error, solo se permiten letras.");
            }
        }

        private void txtTlfCliente_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Error, solo se permiten números.");
            }
        }

        private void txtPlacaVeh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Error, solo se permiten letras.");
            }
        }

        private void txtMarcaVeh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Error, solo se permiten letras.");
            }
        }

        private void txtKiloVeh_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Error, solo se permiten números.");
            }
        }
    }
}
