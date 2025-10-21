using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proyecto_IS
{
    public partial class LoginMed : Form
    {
        public LoginMed()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Close();
        }

        private void btn_IniciarSesion(object sender, EventArgs e)
        {
            string usuario = txt_UsuarioMedico.Text;
            string contraseña = txt_ContraMedico.Text;

            string conexionruta = "server = TRISTAN\\MSSQLSERVER01; integrated security = true ; database = Proyecto_IS";
            string query = "Select COUNT (*) FROM LogMedicos WHERE contraseña = @usuario AND usuario = @contraseña";
            using (SqlConnection conexion = new SqlConnection(conexionruta))
            using (SqlCommand comando = new SqlCommand(query, conexion))
            {
                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@contraseña", usuario);

                conexion.Open();
                SqlDataReader reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    InicioMedicos inicio = new InicioMedicos();
                    inicio.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos");
                }
            }
        }
    }
}
