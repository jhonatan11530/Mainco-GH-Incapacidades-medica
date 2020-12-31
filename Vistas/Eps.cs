using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GH_Incapacidades_medica
{
    public partial class Eps : Form
    {
        public Eps()
        {
            InitializeComponent();
            MaximizeBox = false;

            FILTROEPS();

        }
        public void FILTROEPS()
        {
            string[] FILTROEPS = { "SELECCIONE EPS PARA FILTRAR", "S.O.S", "SANITAS", "EMSSANAR", "CONFELNACO", "SURA EPS", "ARL SURA", "ASMET SALUD", "SALUD TOTAL", "COOSALUD", "COOMEVA", "NUEVA EPS", "EPS SURAMERICANA", "MEDIMAS" };
            for (int i = 0; i < FILTROEPS.Length; i++)
            {
                comboBox1.Items.Add(FILTROEPS[i]);
            }
            comboBox1.SelectedIndex = +0;

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            string valor = comboBox1.SelectedItem.ToString();

            if (valor == "SELECCIONE EPS PARA FILTRAR")
            {

                MessageBox.Show("SE MOSTRARA TODAS LAS EPS ", "TODO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SinFiltro();
            }
            else
            {
                ConFiltro(valor);
            }



        }
        public void SinFiltro()
        {

            Conexion conexion = new Conexion();
            SqlConnection connecting = conexion.connecting();
            SqlDataAdapter da;
            DataTable dt;
            try
            {
                da = new SqlDataAdapter("SELECT dbo.incapacidad.NOMBRE,dbo.incapacidad.EPS, dbo.incapacidad.RADICADO, dbo.incapacidad.INCAPACIDAD,FECHA_RADICADO,FECHA_PETICION,FECHA_TUTELA FROM [proyecto].[dbo].[peticion] INNER JOIN [proyecto].[dbo].[incapacidad] ON dbo.incapacidad.RADICADO = dbo.peticion.RADICADO; ", connecting);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message); //Si existe un error aquí muestra el mensaje
            }
            finally
            {
                connecting.Close(); //Cierra la conexión a MySQL
            }

        }
        public void ConFiltro(string valor)
        {

            Conexion conexion = new Conexion();
            SqlConnection connecting = conexion.connecting();
            SqlDataAdapter da;
            DataTable dt;
            try
            {
                da = new SqlDataAdapter("SELECT dbo.incapacidad.NOMBRE,dbo.incapacidad.EPS, dbo.incapacidad.RADICADO, dbo.incapacidad.INCAPACIDAD,FECHA_RADICADO,FECHA_PETICION,FECHA_TUTELA FROM [proyecto].[dbo].[peticion] INNER JOIN [proyecto].[dbo].[incapacidad] ON dbo.incapacidad.RADICADO = dbo.peticion.RADICADO WHERE proyecto.dbo.incapacidad.EPS='" + valor + "'", connecting);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message); //Si existe un error aquí muestra el mensaje
            }
            finally
            {
                connecting.Close(); //Cierra la conexión a MySQL
            }

        }
    }
}
