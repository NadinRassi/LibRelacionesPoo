using System;
using System.Collections.Generic;
using System.Text;

namespace LibRelacionesEntreObjetos.Caso_2
{
    public class Cliente//1 cliente tiene * pedidos
    {
        public List<Pedido> Pedidos { set; get; }

    }
}
