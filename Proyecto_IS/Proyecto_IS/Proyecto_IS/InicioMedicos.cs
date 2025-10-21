using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_IS
{
    public partial class InicioMedicos : Form
    {
        static string conexionruta = "server = TRISTAN\\MSSQLSERVER01; integrated security = true ; database = Proyecto_IS";
        SqlConnection conexion = new SqlConnection(conexionruta);
        public InicioMedicos()
        {
            InitializeComponent();
            conexion.Open();
            string query = "Select * from Paciente";
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable Paciente = new DataTable();
            data.Fill(Paciente);
            dgv_HistorialMedico.DataSource = Paciente;
        }

    }
}
