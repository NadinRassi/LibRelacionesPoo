using System;
using System.Collections.Generic;
using System.Text;

namespace LibRelacionesEntreObjetos.Caso_1
{
    public class Cliente //1 usuario tiene 1 cliente
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Usuario Usuario { get; set; }

    }
}
