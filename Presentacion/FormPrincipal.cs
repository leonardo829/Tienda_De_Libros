using TiendaDeLibros.Entidades;

namespace Presentacion
{
	public partial class FormPrincipal : Form
	{
		private List<Libro> libros = new List<Libro>();
		private List<Usuario> usuarios = new List<Usuario>();
		private List<Proveedor> proveedores = new List<Proveedor>();

		public FormPrincipal()
		{
			InitializeComponent();
			CargarDatosIniciales();
			MostrarLibros();
		}

		private void CargarDatosIniciales()
		{
			// Añade algunos libros de ejemplo
			libros.Add(new Libro { ISBN = 1, Categoria = "Novela", Nombre = "Don Quijote", Autor = "Miguel de Cervantes", Editorial = "Anaya", Cantidad = 10, Precio = 9.99m });
			libros.Add(new Libro { ISBN = 2, Categoria = "Ciencia Ficción", Nombre = "Dune", Autor = "Frank Herbert", Editorial = "Chilton Books", Cantidad = 5, Precio = 15.50m });
		}

		private void MostrarLibros()
		{
			dataGridViewLibros.DataSource = null;
			dataGridViewLibros.DataSource = libros;
		}

		private void FormPrincipal_Load(object sender, EventArgs e)
		{

		}
	}
}
