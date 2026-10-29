namespace Visual
{
    partial class RegistroMantenimiento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            lsbServicios = new ListBox();
            dtpFechaMantenimiento = new DateTimePicker();
            btnLimpiar = new Button();
            rtbxContenidoVenta = new RichTextBox();
            btnRegisMant = new Button();
            rtbxTrabMant = new RichTextBox();
            rtbxDiagMant = new RichTextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            txtPrecioServ = new TextBox();
            label5 = new Label();
            txtPrecioTipo = new TextBox();
            cmbTipoMant = new ComboBox();
            cmbRespuestos = new ComboBox();
            label4 = new Label();
            cmbMecanico = new ComboBox();
            cmbCliente = new ComboBox();
            txtCodMant = new TextBox();
            label9 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 32, 42);
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(lsbServicios);
            panel1.Controls.Add(dtpFechaMantenimiento);
            panel1.Controls.Add(btnLimpiar);
            panel1.Controls.Add(rtbxContenidoVenta);
            panel1.Controls.Add(btnRegisMant);
            panel1.Controls.Add(rtbxTrabMant);
            panel1.Controls.Add(rtbxDiagMant);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtPrecioServ);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtPrecioTipo);
            panel1.Controls.Add(cmbTipoMant);
            panel1.Controls.Add(cmbRespuestos);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(cmbMecanico);
            panel1.Controls.Add(cmbCliente);
            panel1.Controls.Add(txtCodMant);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1462, 686);
            panel1.TabIndex = 0;
            // 
            // lsbServicios
            // 
            lsbServicios.BackColor = Color.FromArgb(39, 52, 67);
            lsbServicios.Font = new Font("Segoe UI Emoji", 9.134328F, FontStyle.Bold, GraphicsUnit.Point);
            lsbServicios.ForeColor = Color.WhiteSmoke;
            lsbServicios.FormattingEnabled = true;
            lsbServicios.ItemHeight = 24;
            lsbServicios.Items.AddRange(new object[] { "Sin Servicio", "Cambio de Aceite", "Lavado", "Alineacion", "Suspencion", "Revisado de Frenos" });
            lsbServicios.Location = new Point(278, 428);
            lsbServicios.Name = "lsbServicios";
            lsbServicios.SelectionMode = SelectionMode.MultiSimple;
            lsbServicios.Size = new Size(187, 148);
            lsbServicios.TabIndex = 40;
            lsbServicios.SelectedIndexChanged += lsbServicios_SelectedIndexChanged;
            // 
            // dtpFechaMantenimiento
            // 
            dtpFechaMantenimiento.Location = new Point(902, 113);
            dtpFechaMantenimiento.Name = "dtpFechaMantenimiento";
            dtpFechaMantenimiento.Size = new Size(375, 31);
            dtpFechaMantenimiento.TabIndex = 39;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(31, 31, 31);
            btnLimpiar.Font = new Font("Segoe UI", 11.8208952F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.ForeColor = Color.DodgerBlue;
            btnLimpiar.Location = new Point(693, 438);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(170, 65);
            btnLimpiar.TabIndex = 38;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // rtbxContenidoVenta
            // 
            rtbxContenidoVenta.BackColor = Color.FromArgb(39, 52, 67);
            rtbxContenidoVenta.Font = new Font("Segoe UI Emoji", 9.134328F, FontStyle.Bold, GraphicsUnit.Point);
            rtbxContenidoVenta.ForeColor = Color.WhiteSmoke;
            rtbxContenidoVenta.Location = new Point(1056, 270);
            rtbxContenidoVenta.Name = "rtbxContenidoVenta";
            rtbxContenidoVenta.Size = new Size(365, 293);
            rtbxContenidoVenta.TabIndex = 37;
            rtbxContenidoVenta.Text = "";
            // 
            // btnRegisMant
            // 
            btnRegisMant.BackColor = Color.FromArgb(31, 31, 31);
            btnRegisMant.Font = new Font("Segoe UI", 11.8208952F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegisMant.ForeColor = Color.DodgerBlue;
            btnRegisMant.Location = new Point(693, 340);
            btnRegisMant.Name = "btnRegisMant";
            btnRegisMant.Size = new Size(176, 65);
            btnRegisMant.TabIndex = 36;
            btnRegisMant.Text = "Registrar";
            btnRegisMant.UseVisualStyleBackColor = false;
            btnRegisMant.Click += btnRegisMant_Click;
            // 
            // rtbxTrabMant
            // 
            rtbxTrabMant.BackColor = Color.FromArgb(39, 52, 67);
            rtbxTrabMant.Font = new Font("Segoe UI Emoji", 9.134328F, FontStyle.Bold, GraphicsUnit.Point);
            rtbxTrabMant.ForeColor = Color.WhiteSmoke;
            rtbxTrabMant.Location = new Point(902, 205);
            rtbxTrabMant.Name = "rtbxTrabMant";
            rtbxTrabMant.Size = new Size(187, 42);
            rtbxTrabMant.TabIndex = 35;
            rtbxTrabMant.Text = "";
            // 
            // rtbxDiagMant
            // 
            rtbxDiagMant.BackColor = Color.FromArgb(39, 52, 67);
            rtbxDiagMant.Font = new Font("Segoe UI Emoji", 9.134328F, FontStyle.Bold, GraphicsUnit.Point);
            rtbxDiagMant.ForeColor = Color.WhiteSmoke;
            rtbxDiagMant.Location = new Point(902, 157);
            rtbxDiagMant.Name = "rtbxDiagMant";
            rtbxDiagMant.Size = new Size(187, 42);
            rtbxDiagMant.TabIndex = 34;
            rtbxDiagMant.Text = "";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 11.8208952F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Aqua;
            label8.Location = new Point(631, 211);
            label8.Name = "label8";
            label8.Size = new Size(238, 32);
            label8.TabIndex = 32;
            label8.Text = "Trabajos Realizados";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 11.8208952F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Aqua;
            label7.Location = new Point(632, 162);
            label7.Name = "label7";
            label7.Size = new Size(151, 32);
            label7.TabIndex = 31;
            label7.Text = "Diagnostico";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 11.8208952F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Aqua;
            label6.Location = new Point(632, 113);
            label6.Name = "label6";
            label6.Size = new Size(261, 32);
            label6.TabIndex = 30;
            label6.Text = "Fecha Mantenimiento";
            // 
            // txtPrecioServ
            // 
            txtPrecioServ.BackColor = Color.FromArgb(39, 52, 67);
            txtPrecioServ.Font = new Font("Segoe UI Emoji", 9.134328F, FontStyle.Bold, GraphicsUnit.Point);
            txtPrecioServ.ForeColor = Color.WhiteSmoke;
            txtPrecioServ.Location = new Point(472, 457);
            txtPrecioServ.Name = "txtPrecioServ";
            txtPrecioServ.Size = new Size(93, 32);
            txtPrecioServ.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 11.8208952F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Aqua;
            label5.Location = new Point(21, 454);
            label5.Name = "label5";
            label5.Size = new Size(242, 32);
            label5.TabIndex = 27;
            label5.Text = "Seleccionar Servicio";
            // 
            // txtPrecioTipo
            // 
            txtPrecioTipo.BackColor = Color.FromArgb(39, 52, 67);
            txtPrecioTipo.Font = new Font("Segoe UI Emoji", 9.134328F, FontStyle.Bold, GraphicsUnit.Point);
            txtPrecioTipo.ForeColor = Color.WhiteSmoke;
            txtPrecioTipo.Location = new Point(472, 349);
            txtPrecioTipo.Name = "txtPrecioTipo";
            txtPrecioTipo.Size = new Size(93, 32);
            txtPrecioTipo.TabIndex = 26;
            // 
            // cmbTipoMant
            // 
            cmbTipoMant.BackColor = Color.FromArgb(39, 52, 67);
            cmbTipoMant.Font = new Font("Segoe UI Emoji", 9.134328F, FontStyle.Bold, GraphicsUnit.Point);
            cmbTipoMant.ForeColor = Color.WhiteSmoke;
            cmbTipoMant.FormattingEnabled = true;
            cmbTipoMant.Items.AddRange(new object[] { "Preventivo", "Correctivo" });
            cmbTipoMant.Location = new Point(278, 308);
            cmbTipoMant.Name = "cmbTipoMant";
            cmbTipoMant.Size = new Size(181, 32);
            cmbTipoMant.TabIndex = 25;
            cmbTipoMant.Text = "Seleccionar";
            cmbTipoMant.SelectedIndexChanged += cmbTipoMant_SelectedIndexChanged;
            // 
            // cmbRespuestos
            // 
            cmbRespuestos.BackColor = Color.FromArgb(39, 52, 67);
            cmbRespuestos.Font = new Font("Segoe UI Emoji", 9.134328F, FontStyle.Bold, GraphicsUnit.Point);
            cmbRespuestos.ForeColor = Color.WhiteSmoke;
            cmbRespuestos.FormattingEnabled = true;
            cmbRespuestos.Location = new Point(278, 349);
            cmbRespuestos.Name = "cmbRespuestos";
            cmbRespuestos.Size = new Size(187, 32);
            cmbRespuestos.TabIndex = 24;
            cmbRespuestos.Text = "Seleccionar";
            cmbRespuestos.SelectedIndexChanged += cmbRespuestos_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 11.8208952F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Aqua;
            label4.Location = new Point(22, 329);
            label4.Name = "label4";
            label4.Size = new Size(248, 32);
            label4.TabIndex = 23;
            label4.Text = "Tipo Mantenimiento";
            // 
            // cmbMecanico
            // 
            cmbMecanico.BackColor = Color.FromArgb(39, 52, 67);
            cmbMecanico.Font = new Font("Segoe UI Emoji", 9.134328F, FontStyle.Bold, GraphicsUnit.Point);
            cmbMecanico.ForeColor = Color.WhiteSmoke;
            cmbMecanico.FormattingEnabled = true;
            cmbMecanico.Location = new Point(307, 207);
            cmbMecanico.Name = "cmbMecanico";
            cmbMecanico.Size = new Size(272, 32);
            cmbMecanico.TabIndex = 18;
            // 
            // cmbCliente
            // 
            cmbCliente.BackColor = Color.FromArgb(39, 52, 67);
            cmbCliente.Font = new Font("Segoe UI Emoji", 9.134328F, FontStyle.Bold, GraphicsUnit.Point);
            cmbCliente.ForeColor = Color.WhiteSmoke;
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(307, 166);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(272, 32);
            cmbCliente.TabIndex = 17;
            cmbCliente.Text = "Seleccionar";
            // 
            // txtCodMant
            // 
            txtCodMant.BackColor = Color.FromArgb(31, 31, 31);
            txtCodMant.Font = new Font("Segoe UI Emoji", 9.134328F, FontStyle.Bold, GraphicsUnit.Point);
            txtCodMant.ForeColor = Color.WhiteSmoke;
            txtCodMant.Location = new Point(307, 127);
            txtCodMant.Name = "txtCodMant";
            txtCodMant.ReadOnly = true;
            txtCodMant.Size = new Size(187, 32);
            txtCodMant.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(64, 64, 64);
            label9.Font = new Font("Segoe UI", 13.970149F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Cyan;
            label9.Location = new Point(531, 35);
            label9.Name = "label9";
            label9.Size = new Size(337, 38);
            label9.TabIndex = 15;
            label9.Text = "Registro Mantenimiento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 11.8208952F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Aqua;
            label3.Location = new Point(23, 127);
            label3.Name = "label3";
            label3.Size = new Size(279, 32);
            label3.TabIndex = 14;
            label3.Text = "Codigo Mantenimiento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11.8208952F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Aqua;
            label2.Location = new Point(22, 208);
            label2.Name = "label2";
            label2.Size = new Size(261, 32);
            label2.TabIndex = 13;
            label2.Text = "Seleccionar Mecanico";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 11.8208952F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Aqua;
            label1.Location = new Point(22, 167);
            label1.Name = "label1";
            label1.Size = new Size(230, 32);
            label1.TabIndex = 12;
            label1.Text = "Seleccionar Cliente";
            // 
            // RegistroMantenimiento
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1462, 686);
            Controls.Add(panel1);
            Name = "RegistroMantenimiento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegistroMantenimiento";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox cmbMecanico;
        private ComboBox cmbCliente;
        private TextBox txtCodMant;
        private Label label9;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnLimpiar;
        private RichTextBox rtbxContenidoVenta;
        private Button btnRegisMant;
        private RichTextBox rtbxTrabMant;
        private RichTextBox rtbxDiagMant;
        //private TextBox txtFechaMant;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox txtPrecioServ;
        private Label label5;
        private TextBox txtPrecioTipo;
        private ComboBox cmbTipoMant;
        private ComboBox cmbRespuestos;
        private Label label4;
        private DateTimePicker dtpFechaMantenimiento;
        private ListBox lsbServicios;
    }
}