using Model;

namespace Control
{
    public class Administrador
    {
        List<Cliente> registrocliente = new List<Cliente>();
        List<Mecanico> registromecanico = new List<Mecanico>();
        List<Mantenimiento> registromantenimiento = new List<Mantenimiento>();

        public static Administrador adm = null;
        public static Administrador getAdm()
        {
            if (adm == null)
            {
                adm = new Administrador();
            }
            return adm;
        }


        public Administrador()
        {
            
        }

        public string ingresarCliente(string apeCliente, string nomCliente, string cdlCliente,
            string corrCliente, string telCliente, String placaVeh, String marVeh,
            String matrVehi, String kiloVeh)
        {
            String x = "";
            Cliente datos = new Cliente(apeCliente, nomCliente, cdlCliente,
                corrCliente, telCliente, placaVeh, marVeh, matrVehi, kiloVeh);
            registrocliente.Add(datos);

            foreach (Cliente clientes in registrocliente)
            {
                x = "Apellido-> " + clientes.ApellidoCliente + "\n" +
                    "Nombre-> " + clientes.NombreCliente + "\n" +
                    "Cedula-> " + clientes.CdulaCliente + "\n" +
                    "Correo-> " + clientes.CorreoCliente + "\n" +
                    "Telefono-> " + clientes.TelefonoCliente + "\n" +
                    "Placa Vehiculo-> " + clientes.PlacVeh + "\n" +
                    "Marca Vehiculo-> " + clientes.MarcVeh + "\n" +
                    "Matricula Vehiculo-> " + clientes.MatrVeh + "\n" +
                    "Kilometraje Vehiculo-> " + clientes.kiloVeh + "\n";
            }

            return x;
        }

        public string ingresarMecanico(string apeMec, string nomMec, string cdlMec, string corrMec, string telMec)
        {
            String x = "";
            Mecanico datos = new Mecanico(apeMec, nomMec, cdlMec, corrMec, telMec);
            registromecanico.Add(datos);

            foreach (Mecanico mecac in registromecanico)
            {
                x = "Apellido-> " + mecac.ApellidoMecanico + "\n" +
                    "Nombre-> " + mecac.NombreMecanico + "\n" +
                    "Cedula-> " + mecac.CdulaMecanico + "\n" +
                    "Correo-> " + mecac.CorreoMecanico + "\n" +
                    "Telefono-> " + mecac.TelefonoMecanico + "\n";
            }

            return x;
        }

        public string registroMantenimiento(int codmant, string sleccliente, string sleccmecanico,
             string slectipomantcorrt, string slecservicio, string fechamant,
            string diagmant, string trabmant, string preciotipo, string precioserv)
        {
            String x = "";
            double preciotp = Convert.ToDouble(preciotipo);
            double precioser = Convert.ToDouble(precioserv);
            double total = 0;
            double subtotal = 0;
            double iva = 0;

            subtotal = precioser + preciotp;
            iva = subtotal * 0.12;
            total = subtotal + iva;
            total = Math.Round(total, 2);

            Mantenimiento datos = new Mantenimiento(codmant, sleccliente, sleccmecanico, slectipomantcorrt,
                slecservicio, fechamant, diagmant, trabmant, total);
            registromantenimiento.Add(datos);

            foreach (Mantenimiento listaDatos in registromantenimiento)
            {
                x = "Codigo-> " + listaDatos.CodMan + "\n" +
                    "Nombre Cliente-> " + listaDatos.CliReg + "\n" +
                    "Nombre Mecanico-> " + listaDatos.MecRegis + "\n" +
                    "Tipo Mantenimiento-> " + listaDatos.RespRegis + "\n" +
                    "Servicio Adicional-> " + listaDatos.Servregistrado + "\n" +
                    "Fecha Mantenimiento-> " + listaDatos.FecMant + "\n" +
                    "Diagnostico-> " + listaDatos.DiagMant + "\n" +
                    "Trabajo Realizado-> " + listaDatos.TrabMant + "\n" +
                    "Total a Pagar-> " + listaDatos.TotPag + "\n";
            }
            return x;
        }

        public List<String> GetNombreCliente()
        {
            List<string> nombresClientes = new List<string>();
            foreach (Cliente obtener in registrocliente)
            {
                nombresClientes.Add(obtener.NombreCliente + " " + obtener.ApellidoCliente);
            }
            return nombresClientes;
        }

        public List<String> GetNombreMecanico()
        {
            List<string> nombresMecanicos = new List<string>();
            foreach (Mecanico obtener in registromecanico)
            {
                nombresMecanicos.Add(obtener.NombreMecanico + " " + obtener.ApellidoMecanico);
            }
            return nombresMecanicos;
        }

    }
}