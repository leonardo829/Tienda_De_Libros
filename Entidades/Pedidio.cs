using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pedidio
    {
        public int ID_Pedido { get; set; }
        public int ID_Usuario { get; set; }
        public DateTime FechaPedido { get; set; }
        public enum EstadoPedido
        {
            Pendiente = 0,
            Enviado = 1,
            Entregado = 2
        }
    }
}
