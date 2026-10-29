namespace Model
{
    public class Cliente
    {
        private String apellidoCliente;
        private String nombreCliente;
        private String cedulaCliente;
        private String correoCliente;
        private String telefonoCliente;
        private String placaVehiculo;
        private String marcaVehiculo;
        private String matriculaVehiculo;
        private String kilometrajeVehiculo;

        public Cliente()
        {
            this.apellidoCliente = string.Empty;
            this.nombreCliente = string.Empty;
            this.cedulaCliente = string.Empty;
            this.correoCliente = string.Empty;
            this.telefonoCliente = string.Empty;
            this.placaVehiculo = string.Empty;
            this.marcaVehiculo = string.Empty;
            this.matriculaVehiculo = string.Empty;
            this.kilometrajeVehiculo = string.Empty;
        }

        public Cliente(String apellidoCliente, String nombreCliente, String cedulaCliente,
            String correoCliente, String telefonoCliente, String placaVehiculo, String marcaVehiculo,
            String matriculaVehiculo, String kilometrajeVehiculo)
        {
            this.apellidoCliente = apellidoCliente;
            this.nombreCliente = nombreCliente;
            this.cedulaCliente = cedulaCliente;
            this.correoCliente = correoCliente;
            this.telefonoCliente = telefonoCliente;
            this.placaVehiculo = placaVehiculo;
            this.marcaVehiculo = marcaVehiculo;
            this.matriculaVehiculo = matriculaVehiculo;
            this.kilometrajeVehiculo = kilometrajeVehiculo;
        }

        //Creacion de propiedades
        public String ApellidoCliente
        {
            get { return apellidoCliente; }
            set { apellidoCliente = value; }
        }

        public String NombreCliente
        {
            get { return nombreCliente; }
            set { nombreCliente = value; }
        }

        public String CdulaCliente
        {
            get { return cedulaCliente; }
            set { cedulaCliente = value; }
        }

        public String CorreoCliente
        {
            get { return correoCliente; }
            set { correoCliente = value; }
        }

        public String TelefonoCliente
        {
            get { return telefonoCliente; }
            set { telefonoCliente = value; }
        }

        public String PlacVeh
        {
            get { return placaVehiculo; }
            set { placaVehiculo = value; }
        }

        public String MarcVeh
        {
            get { return marcaVehiculo; }
            set { marcaVehiculo = value; }
        }

        public String MatrVeh
        {
            get { return matriculaVehiculo; }
            set { matriculaVehiculo = value; }
        }

        public String kiloVeh
        {
            get { return kilometrajeVehiculo; }
            set { kilometrajeVehiculo = value; }
        }

    }
}