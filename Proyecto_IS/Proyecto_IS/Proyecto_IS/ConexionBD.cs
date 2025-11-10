using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Proyecto_IS
{
    internal class ConexionBD
    {
        
        private MySqlConnection conexion; 
        static string conexionstring = "server = TRISTAN\\MSSQLSERVER01; integrated security = true ; database = Proyecto_IS";
        public MySqlConnection getConexion()
        {
            if (conexion == null)
            {
                conexion = new MySqlConnection(conexionstring);
                conexion.Open();
            }
            return conexion;
        }
    }
}
