using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient; //Sirve para ocupar el SqlDataReader
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client; 


namespace MINVU_APP_2018
{
    public partial class BuscarPostulante : Form
    {
        OracleConnection oc = new OracleConnection("User Id= SUBSIDIO; Password = SUBSIDIO;Data Source = localhost;");

        string dml = "select * from informacion_postulante where CEDULA_POSTULANTE = :CEDULA_POSTULANTE";

        public BuscarPostulante()
        {
            InitializeComponent();
            txtRutBuscar.Text = "1-K";
            Conexion();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                OracleCommand comando = new OracleCommand(dml,oc);
                OracleDataAdapter da = new OracleDataAdapter(comando);
                DataSet ds = new DataSet();

                // Añadiendo el parámetro
                da.SelectCommand.Parameters.Add(":CEDULA_POSTULANTE", OracleDbType.Varchar2);
                // Estableciendo el valor del parámetro
                da.SelectCommand.Parameters[":CEDULA_POSTULANTE"].Value = txtRutBuscar.Text;

                // Se recuperan los datos
                da.Fill(ds, "INFORMACION_POSTULANTE");

                // Se verifica la existencia del registro
                if (ds.Tables["INFORMACION_POSTULANTE"].Rows.Count != 0)
                {//ds.Tables["INFORMACION_POSTULANTE"].Rows[0]["PUNTAJE_OBTENIDO"].ToString();
                    // Se establecen los valores en el formulario
                    txtRutPos.Text = ds.Tables["INFORMACION_POSTULANTE"].Rows[0]["CEDULA_POSTULANTE"].ToString();
                    txtNombresPos.Text = ds.Tables["INFORMACION_POSTULANTE"].Rows[0]["NOM_COMPLETO_POST"].ToString();
                    txtFechaNac.Text = ds.Tables["INFORMACION_POSTULANTE"].Rows[0]["FECHA_NAC_POST"].ToString();
                    txtNacionalidad.Text = ds.Tables["INFORMACION_POSTULANTE"].Rows[0]["FECHA_NAC_POST"].ToString();
                    txtEstadoCivil.Text = ds.Tables["INFORMACION_POSTULANTE"].Rows[0]["ESTADO_CIVIL_POST"].ToString();
                    txtCargasFam.Text = ds.Tables["INFORMACION_POSTULANTE"].Rows[0]["TOTAL_CARGAS"].ToString();
                    txtPueblos.Text = ds.Tables["INFORMACION_POSTULANTE"].Rows[0]["PUEBLO_INDIGENA_POST"].ToString();
                    txtTitulo.Text = ds.Tables["INFORMACION_POSTULANTE"].Rows[0]["DESCR_TITULO_POST"].ToString();
                    txtFolio.Text = ds.Tables["INFORMACION_POSTULANTE"].Rows[0]["NRO_FOLIO"].ToString();
                    txtFechaPos.Text = ds.Tables["INFORMACION_POSTULANTE"].Rows[0]["FECHA_POSTULACION"].ToString();
                    txtReceptorPos.Text = ds.Tables["INFORMACION_POSTULANTE"].Rows[0]["RECEPTOR_POSTULACION"].ToString();
                    txtRutConyuge.Text = ds.Tables["INFORMACION_POSTULANTE"].Rows[0]["CEDULA_CONYUGE"].ToString();
                    txtCalle.Text = ds.Tables["INFORMACION_POSTULANTE"].Rows[0]["CALLE_POST"].ToString();
                    txtNumero.Text = ds.Tables["INFORMACION_POSTULANTE"].Rows[0]["NUMERO"].ToString();
                    txtNombresConyuge.Text = ds.Tables["INFORMACION_POSTULANTE"].Rows[0]["NOMBRE_CONYUGE"].ToString();
                    txtBlock.Text = ds.Tables["INFORMACION_POSTULANTE"].Rows[0]["BLOCK_POST"].ToString();
                    txtDepartamento.Text = ds.Tables["INFORMACION_POSTULANTE"].Rows[0]["DEPARTAMENTO_POST"].ToString();
                    txtManzana.Text = ds.Tables["INFORMACION_POSTULANTE"].Rows[0]["MANZANA_POST"].ToString();
                    txtSitio.Text = ds.Tables["INFORMACION_POSTULANTE"].Rows[0]["SITIO_POST"].ToString();
                    txtRegion.Text = ds.Tables["INFORMACION_POSTULANTE"].Rows[0]["REGION"].ToString();
                    txtComuna.Text = ds.Tables["INFORMACION_POSTULANTE"].Rows[0]["COMUNA"].ToString();
                    txtTelefonoTrabajo.Text = ds.Tables["INFORMACION_POSTULANTE"].Rows[0]["TELEF_TRABAJO_POST"].ToString();
                    txtTelefonoDomicilio.Text = ds.Tables["INFORMACION_POSTULANTE"].Rows[0]["TELEF_MOVIL_POST"].ToString();
                    txtTelefonoMovil.Text = ds.Tables["INFORMACION_POSTULANTE"].Rows[0]["TELEF_MOVIL_POST"].ToString();
                    txtCodigoPostal.Text = ds.Tables["INFORMACION_POSTULANTE"].Rows[0]["COD_POSTAL_POST"].ToString();
                    txtemail.Text = ds.Tables["INFORMACION_POSTULANTE"].Rows[0]["EMAIL_POST"].ToString();
                    txtTipoPos.Text = ds.Tables["INFORMACION_POSTULANTE"].Rows[0]["TRAMO_POSTULACION"].ToString();
                    txtRegionVivienda.Text = ds.Tables["INFORMACION_POSTULANTE"].Rows[0]["REGION_VIV"].ToString();
                    txtComunaVivienda.Text = ds.Tables["INFORMACION_POSTULANTE"].Rows[0]["COMUNA_VIV"].ToString();
                    txtTipoVivienda.Text = ds.Tables["INFORMACION_POSTULANTE"].Rows[0]["TIPO_VIVIENDA"].ToString();
                    txtValorPropiedad.Text = ds.Tables["INFORMACION_POSTULANTE"].Rows[0]["VALOR_PROPIEDAD"].ToString();
                    txtMontoAhorrado.Text = ds.Tables["INFORMACION_POSTULANTE"].Rows[0]["MONTO_AHORRADO"].ToString();
                    txtPuntajeMinimo.Text = ds.Tables["INFORMACION_POSTULANTE"].Rows[0]["PUNTAJE_MINIMO"].ToString();
                    txtPuntajeObtenido.Text = ds.Tables["INFORMACION_POSTULANTE"].Rows[0]["PUNTAJE_OBTENIDO"].ToString();


                    // El campo productImage primero se almacena en un buffer
                    byte[] imageBuffer = (byte[])ds.Tables["INFORMACION_POSTULANTE"].Rows[0]["FOTO"];
                    // Se crea un MemoryStream a partir de ese buffer
                    System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBuffer);
                    // Se utiliza el MemoryStream para extraer la imagen
                    pboxPostulante.Image = Image.FromStream(ms);
                }
                else
                {
                    MessageBox.Show("El postulante no existe");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(""+ex);
            }
        }

        private OracleConnection Conexion() {
            try
            {
                oc.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("UPS! No hay datos asociados para el rut especificado ","ERROR"); 
            }
            return oc;
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Principal principal = new Principal();
            principal.Show();
        }
    }
}
