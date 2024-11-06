using System.Collections.Generic;

namespace TiendaDeLibros.Entidades
{
	public class Usuario
	{
        #region atributos
        public int Id_usuario { get;
			set; }
		public string Nombre { get; set; }
		public string Telefono { get; set; }
		public string Email { get; set; }
		public string Direccion { get; set; }
		public string Documento { get; set; }
		public string Contrasena { get; set; }
		public List<Libro> CarritoDeCompra { get; set; }
        #endregion

        #region Constructor
        public Usuario()
		{
			Id_usuario = 0;
			Nombre = string.Empty;
			Telefono = string.Empty;
			Email = string.Empty;
			Direccion = string.Empty;
			Documento = string.Empty;
			Contrasena = string.Empty;
			CarritoDeCompra = new List<Libro>();
		}
        #endregion


        #region propiedades/encapsulamiento
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
		public string direccion 
		{	
			get { return Direccion; }
			set { Direccion = value; }
		}

		public string documento
		{
			get { return Documento; }
			set { Documento = value; }
		}

		public string contraseña
		{
			get { return Contrasena; }
			set { Contrasena = value; }
		}
        #endregion
    }
}
