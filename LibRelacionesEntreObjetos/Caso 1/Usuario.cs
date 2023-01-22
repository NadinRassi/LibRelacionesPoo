using System;
using System.Collections.Generic;
using System.Text;

namespace LibRelacionesEntreObjetos.Caso_1
{
    public class Usuario//1 ususario tiene 1 cliente
    {

        public Cliente Cliente { get; set; }
        public string Nombre { get; set; }
        public string Password { get; set; }

    }
}
