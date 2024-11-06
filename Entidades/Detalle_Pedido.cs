namespace Entidades
{
	public class Detalle_Pedido
    {
       public int ID_Detalle_pedido {  get; set; }
        public int ID_Pedido { get; set; }
        public int ID_Libro { get; set; }
        public int Cantidad { get; set; }
    }
}
