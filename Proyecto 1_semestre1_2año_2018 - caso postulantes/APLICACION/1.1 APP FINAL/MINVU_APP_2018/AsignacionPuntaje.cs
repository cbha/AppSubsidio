using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MINVU_APP_2018
{
    public partial class AsignacionPuntaje : Form
    {
        OracleConnection oc = new OracleConnection("User Id= SUBSIDIO; Password = SUBSIDIO;Data Source = localhost;");
        public AsignacionPuntaje()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand comando = new OracleCommand("SP_SELECCIONAR_PUNTAJES", oc);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("registros", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            OracleDataAdapter adaptador = new OracleDataAdapter();

            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgAsignacionPuntaje.DataSource = tabla;
            oc.Close();
        }

        private OracleConnection Conexion()
        {
            try
            {
                oc.Open();
                MessageBox.Show("Conectado");
            }
            catch (Exception)
            {
                MessageBox.Show("UPS! No hay datos asociados para el rut especificado ", "ERROR");
            }
            return oc;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Principal principal = new Principal();
            //principal.Show();
        }
    }
}
