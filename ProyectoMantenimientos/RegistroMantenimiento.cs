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
    public partial class RegistroMantenimiento : Form
    {
        private Administrador adm = Administrador.getAdm();
        int cod = 100;
        public RegistroMantenimiento()
        {
            InitializeComponent();

            cmbCliente.DataSource = null;
            cmbMecanico.DataSource = null;
            cmbCliente.DataSource = adm.GetNombreCliente();
            cmbMecanico.DataSource = adm.GetNombreMecanico();

        }

        private void btnRegisMant_Click(object sender, EventArgs e)
        {


            int codigomant = cod + 1;
            cod = codigomant;
            String diagmant = rtbxDiagMant.Text.Trim();
            String trabmant = rtbxTrabMant.Text.Trim();
            String preciotipo = txtPrecioTipo.Text.Trim();
            String precioserv = txtPrecioServ.Text.Trim();
            String contenido = string.Empty;

            if (cmbCliente.SelectedItem != null && cmbMecanico.SelectedItem != null &&
                cmbRespuestos.SelectedItem != null && lsbServicios.SelectedItem != null &&
                dtpFechaMantenimiento.Value != DateTime.MinValue && diagmant.CompareTo("") != 0 &&
                trabmant.CompareTo("") != 0)
            {
                contenido = adm.registroMantenimiento(cod, cmbCliente.Text, cmbMecanico.Text,
                cmbRespuestos.Text, lsbServicios.Text, dtpFechaMantenimiento.Text, diagmant, trabmant, preciotipo,
                precioserv);
                MessageBox.Show("Registro exitoso");
                rtbxContenidoVenta.Text = contenido;
            }
            else
            {
                MessageBox.Show("Existen campos vacio o sin seleccionar");
            }


        }



        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodMant.Text = string.Empty;
            cmbCliente.SelectedIndex = -1;
            cmbMecanico.SelectedIndex = -1;
            cmbTipoMant.SelectedIndex = -1;
            cmbRespuestos.Items.Clear();
            lsbServicios.SelectedIndices.Clear();
            dtpFechaMantenimiento.Value = DateTime.Now;
            rtbxDiagMant.Text = string.Empty;
            rtbxTrabMant.Text = string.Empty;
            rtbxContenidoVenta.Text = string.Empty;
            txtPrecioServ.Text = string.Empty;
            txtPrecioTipo.Text = string.Empty;
        }

        private void cmbTipoMant_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoMant.SelectedIndex == 1)
            {
                txtPrecioTipo.Text = string.Empty;
                cmbRespuestos.Items.Clear();
                cmbRespuestos.Items.Add("Condensador");
                cmbRespuestos.Items.Add("Bateria");
                cmbRespuestos.Items.Add("Embragues");
                cmbRespuestos.Items.Add("Engranaje");
                cmbRespuestos.Items.Add("Amortiguadores");

            }
            else if (cmbTipoMant.SelectedIndex == 0)
            {
                txtPrecioTipo.Text = string.Empty;
                cmbRespuestos.Items.Clear();
                cmbRespuestos.Items.Add("Preventivo");

            }
        }

        private void cmbRespuestos_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbRespuestos.SelectedItem.ToString() == "Preventivo")
            {

                txtPrecioTipo.Text = "85,23";

            }
            else if (cmbRespuestos.SelectedItem.ToString() == "Condensador")
            {
                txtPrecioTipo.Text = "130,20";

            }
            else if (cmbRespuestos.SelectedItem.ToString() == "Bateria")
            {
                txtPrecioTipo.Text = "110,05";
            }
            else if (cmbRespuestos.SelectedItem.ToString() == "Embragues")
            {
                txtPrecioTipo.Text = "96,35";
            }
            else if (cmbRespuestos.SelectedItem.ToString() == "Engranaje")
            {
                txtPrecioTipo.Text = "120,00";
            }
            else if (cmbRespuestos.SelectedItem.ToString() == "Amortiguadores")
            {
                txtPrecioTipo.Text = "140,20";
            }
        }


        private void RegistroMantenimiento_Load(object sender, EventArgs e)
        {
            txtCodMant.ReadOnly = true;
            cmbCliente.SelectedIndex = -1;
            cmbMecanico.SelectedIndex = -1;

        }

        private void lsbServicios_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal valor = 0.0m;

            foreach (int indice in lsbServicios.SelectedIndices)
            {
                if (indice == 0)
                {
                    valor += 0.0m;
                }
                else if (indice == 1)
                {
                    valor = valor += 25.50m;

                }
                else if (indice == 2)
                {
                    valor += 30.50m;

                }
                else if (indice == 3)
                {
                    valor += 28.70m;

                }
                else if (indice == 4)
                {
                    valor += 20.00m;

                }
                else if (indice == 5)
                {
                    valor += 15.20m;
                }
            }

            txtPrecioServ.Text = valor.ToString();
        }
    }
}
