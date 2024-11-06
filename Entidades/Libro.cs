namespace TiendaDeLibros.Entidades
{
    public class Libro
    {
        #region atributos
        public int ID_Libro { get; set; }
        public int ISBN { get; set; }
        public string Categoria { get; set; }
        public string Nombre { get; set; }
        public string Autor { get; set; }
        public string Editorial { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        #endregion


        #region Constructor
        public void Libros()
        {
            ID_Libro = 0;
            ISBN = 0;
            Categoria = string.Empty;
            Nombre = string.Empty;
            Autor = string.Empty;
            Editorial = string.Empty;
            Cantidad = 0;
            Precio = 0;
        }
        #endregion

        #region propiedades/encapsulamiento

        public int id_libro
        {
            get { return ID_Libro; }
            set { ID_Libro = value; }
        }
        public int isbn
        {
            get { return ISBN; }
            set { ISBN = value; }
        }
        public int cantidad
        {
            get { return Cantidad; }
            set { Cantidad = value; }
        }
        public decimal precio
        {
            get { return Precio; }
            set { Precio = value; }
        }
        public string categoria
        {
            get { return Categoria; }
            set { Categoria = value; }
        }
        public string nomnbre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }
        public string autor
        {
            get { return Autor; }
            set { Autor = value; }
        }
        public string editorial
        {
            get { return Editorial; }
            set { Editorial = value; }
        }
        #endregion

    }
}
