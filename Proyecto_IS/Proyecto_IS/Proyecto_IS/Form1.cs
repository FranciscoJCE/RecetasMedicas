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
    public partial class Form1 : Form
    {
        private ConexionBD conexion;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMedico_Click(object sender, EventArgs e)
        {
            LoginMed inicio = new LoginMed();
            inicio.Show();
            this.Hide();
            
        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            LoginPaciente inicio = new LoginPaciente();
            inicio.Show();
            this.Hide();
        }

        private void btnFarmaceutico_Click(object sender, EventArgs e)
        {
            LoginFarmaceutico inicio = new LoginFarmaceutico();
            inicio.Show();
            this.Hide();
        }
    }
}
