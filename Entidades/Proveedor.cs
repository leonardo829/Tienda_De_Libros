using System.Collections.Generic;

namespace TiendaDeLibros.Entidades
{
	public class Proveedor
	{
        #region atributos
        public int Id_proveedor { get; set; }
		public string Nombre { get; set; }
		public string Telefono { get; set; }
		public string Email { get; set; }
		public List<Libro> LibrosDisponibles { get; set; }
        #endregion

        #region Constructor
        public Proveedor()
        {
            Id_proveedor = 0;
			Nombre = string.Empty;
			Telefono = string.Empty;
			Email = string.Empty;
			LibrosDisponibles = new List<Libro>();
        }
        #endregion

        #region propiedades/encapsulamiento
        public int id_proveedor
        {
            get { return Id_proveedor; }
            set { Id_proveedor = value; }
        }

        public string nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }

        public string telefono
        {
            get { return Telefono; }
            set { Telefono = value; }
        }
        public string email
        {
            get { return Email; }
            set { Email = value; }
        }
        #endregion
    }
}
