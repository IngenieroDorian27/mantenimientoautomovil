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
    public partial class RegistroMecanico : Form
    {
        Administrador admin = Administrador.getAdm();
        public RegistroMecanico()
        {
            InitializeComponent();
        }

        private void btnRegistrarMecanico_Click(object sender, EventArgs e)
        {
            String apeMec = txtApeMecanico.Text.Trim();
            String nomMec = txtNomMecanico.Text.Trim();
            String cdlMec = txtCdlMecanico.Text.Trim();
            String corrMec = txtCorrMecanico.Text.Trim();
            String telMec = txtTlfMecanico.Text.Trim();

            String contenido = "";

            if (apeMec.CompareTo("") != 0 && nomMec.CompareTo("") != 0 &&
                cdlMec.CompareTo("") != 0 && corrMec.CompareTo("") != 0 &&
                telMec.CompareTo("") != 0)
            {
                contenido = admin.ingresarMecanico(apeMec, nomMec, cdlMec, corrMec, telMec);
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
            txtApeMecanico.Text = string.Empty;
            txtNomMecanico.Text = string.Empty;
            txtCdlMecanico.Text = string.Empty;
            txtCorrMecanico.Text = string.Empty;
            txtTlfMecanico.Text = string.Empty;
            txtboxContenido.Text = string.Empty;
        }

        private void txtApeMecanico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Error, solo se permiten letras.");
            }
        }

        private void txtNomMecanico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Error, solo se permiten letras.");
            }
        }

        private void txtCdlMecanico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Error, solo se permiten números.");
            }
        }

        private void txtTlfMecanico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Error, solo se permiten números.");
            }
        }
    }
}
