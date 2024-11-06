using System.Collections.Generic;
using TiendaDeLibros.Entidades;

namespace TiendaDeLibros.Servicios
{
	public class ServicioDeUsuario
	{
		private List<Usuario> usuarios;

		public ServicioDeUsuario() 
		{
			usuarios = new List<Usuario>();
		}

		public void AgregarUsuario(Usuario usuario)
		{
			usuarios.Add(usuario);
		}

		public List<Usuario> ObtenerUsuarios()
		{
			return usuarios;
		}
	}
}
