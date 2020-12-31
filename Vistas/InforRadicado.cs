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

namespace GH_Incapacidades_medica
{
    public partial class InforRadicado : Form
    {
        public InforRadicado(string Radicado)
        {
            InitializeComponent();
            Filtrar(Radicado);
        }
        public void Filtrar(string Radicado)
        {

            Conexion conexion = new Conexion();
            SqlConnection connecting = conexion.connecting();
            SqlDataAdapter da;
            DataTable dt;
            try
            {
                da = new SqlDataAdapter("SELECT * FROM [proyecto].[dbo].[incapacidad] WHERE RADICADO='"+ Radicado + "' ", connecting);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                da = new SqlDataAdapter("SELECT * FROM [proyecto].[dbo].[peticion] WHERE RADICADO='" + Radicado + "' ", connecting);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;

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

        private void InforRadicado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet4.peticion' Puede moverla o quitarla según sea necesario.
            this.peticionTableAdapter.Fill(this.dataSet4.peticion);
            // TODO: esta línea de código carga datos en la tabla 'dataSet3.incapacidad' Puede moverla o quitarla según sea necesario.
            this.incapacidadTableAdapter.Fill(this.dataSet3.incapacidad);

        }
    }
}
