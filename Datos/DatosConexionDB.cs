using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;

namespace Datos
{
    //con la conexion tube muchos problemas para que funcione a causa de erres de SSL?? y de encriptacion de mi Manager de SQL pero los pude solucionar

    public class DatosConexionDB
    {
        public SqlConnection conexion;
        public string cadenaConexion = @"Data Source = LEO\SQLEXPRESS;Initial Catalog=Libreria;Integrated Security=True;Connect Timeout=30;TrustServerCertificate=true;Encrypt=True";
        
             public DatosConexionDB()
        {
            conexion = new SqlConnection(cadenaConexion);
        }

        public void Abrirconexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Broken || conexion.State == ConnectionState.Closed)
                    conexion.Open();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de abrir la conexion", e);
            }
        }

        public void Cerrarconexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de cerrar la conexion", e);
            }
        }
    }
}
