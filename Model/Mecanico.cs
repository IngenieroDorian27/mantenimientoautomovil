using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Mecanico
    {
        //Declaracion de los atributos.
        private String apellidoMecanico;
        private String nombreMecanico;
        private String cedulaMecanico;
        private String correoMecanico;
        private String telefonoMecanico;

        //Declaracion de contructor vacio
        public Mecanico()
        {
            this.apellidoMecanico = string.Empty;
            this.nombreMecanico = string.Empty;
            this.cedulaMecanico = string.Empty;
            this.correoMecanico = string.Empty;
            this.telefonoMecanico = string.Empty;
        }

        //Declaracion de contructor parametrizado
        public Mecanico(String apellidoMecanico, String nombreMecanico, String cedulaMecanico,
            String correoMecanico, String telefonoMecanico)
        {
            this.apellidoMecanico = apellidoMecanico;
            this.nombreMecanico = nombreMecanico;
            this.cedulaMecanico = cedulaMecanico;
            this.correoMecanico = correoMecanico;
            this.telefonoMecanico = telefonoMecanico;
        }

        //Creacion de propiedades
        public String ApellidoMecanico
        {
            get { return apellidoMecanico; }
            set { apellidoMecanico = value; }
        }

        public String NombreMecanico
        {
            get { return nombreMecanico; }
            set { nombreMecanico = value; }
        }

        public String CdulaMecanico
        {
            get { return cedulaMecanico; }
            set { cedulaMecanico = value; }
        }

        public String CorreoMecanico
        {
            get { return correoMecanico; }
            set { correoMecanico = value; }
        }

        public String TelefonoMecanico
        {
            get { return telefonoMecanico; }
            set { telefonoMecanico = value; }
        }
    }
}
