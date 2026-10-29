using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Mantenimiento
    {
        private int codigoMantenimiento;
        private String clienteRegistrado;
        private String mecanicoRegistrado;
        private String respuestoRegistrado;
        private String servicioRegistrado;
        private String fechaMantenimiento;
        private String diagnosticoMantenimiento;
        private String trabajoMantenimiento;
        private double totalPagar;

        public Mantenimiento()
        {
            this.codigoMantenimiento = 0;
            this.clienteRegistrado = string.Empty;
            this.mecanicoRegistrado = string.Empty;
            this.respuestoRegistrado = string.Empty;
            this.servicioRegistrado = string.Empty;
            this.fechaMantenimiento = string.Empty;
            this.diagnosticoMantenimiento = string.Empty;
            this.trabajoMantenimiento = string.Empty;
            this.totalPagar = 0;

        }

        public Mantenimiento(int codigoMantenimiento, String clienteRegistrado, String mecanicoRegistrado,
            String respuestoRegistrado, String servicioRegistrado, String fechaMantenimiento,
            String diagnosticoMantenimiento, String trabajoMantenimiento, double totalPagar)
        {
            this.codigoMantenimiento = codigoMantenimiento;
            this.clienteRegistrado = clienteRegistrado;
            this.mecanicoRegistrado = mecanicoRegistrado;
            this.respuestoRegistrado = respuestoRegistrado;
            this.servicioRegistrado = servicioRegistrado;
            this.fechaMantenimiento = fechaMantenimiento;
            this.diagnosticoMantenimiento = diagnosticoMantenimiento;
            this.trabajoMantenimiento = trabajoMantenimiento;
            this.totalPagar = totalPagar;

        }

        public int CodMan
        {
            get { return codigoMantenimiento; }
            set { codigoMantenimiento = value; }
        }

        public String CliReg
        {
            get { return clienteRegistrado; }
            set { clienteRegistrado = value; }
        }

        public String MecRegis
        {
            get { return mecanicoRegistrado; }
            set { mecanicoRegistrado = value; }
        }

        public String RespRegis
        {
            get { return respuestoRegistrado; }
            set { respuestoRegistrado = value; }
        }

        public String Servregistrado
        {
            get { return servicioRegistrado; }
            set { servicioRegistrado = value; }
        }

        public String FecMant
        {
            get { return fechaMantenimiento; }
            set { fechaMantenimiento = value; }
        }

        public String DiagMant
        {
            get { return diagnosticoMantenimiento; }
            set { diagnosticoMantenimiento = value; }
        }

        public String TrabMant
        {
            get { return trabajoMantenimiento; }
            set { trabajoMantenimiento = value; }
        }

        public double TotPag
        {
            get { return totalPagar; }
            set { totalPagar = value; }
        }
    }
}
