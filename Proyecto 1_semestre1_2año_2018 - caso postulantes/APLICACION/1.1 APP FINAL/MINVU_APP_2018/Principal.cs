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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnEjecucionProceso_Click(object sender, EventArgs e)
        {
            AsignacionPuntaje asig = new AsignacionPuntaje();
            asig.Show();
        }

        private void btnConsultaPostulante_Click(object sender, EventArgs e)
        {
            this.Hide();
            BuscarPostulante bscPos = new BuscarPostulante();
            bscPos.Show();
            
        }

       
    }
}
