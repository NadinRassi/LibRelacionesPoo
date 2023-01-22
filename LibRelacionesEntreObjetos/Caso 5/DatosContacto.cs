using System;
using System.Collections.Generic;
using System.Text;

namespace LibRelacionesEntreObjetos.Caso_5
{
    public class DatosContacto
    {
        public string Domicilio { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public List<Cliente> Clientes { get; set; }//tiene una lista de clientes
        public Empleado Empleado { get; set; }
    }
}
