using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GH_Incapacidades_medica
{
    public partial class Notificacion_Radicado : Form
    {
        public Notificacion_Radicado(string valor,int valor1)
        {
            InitializeComponent();

            MaximizeBox = false;

            mostrar(valor, valor1);
        }
        public void mostrar(string valor,int valor1)
        {
            if (valor1==0) {

                 Conexion conexion = new Conexion();
                 SqlConnection connecting = conexion.connecting();
                 SqlDataAdapter da;
                 DataTable dt;
                 try
                 {
                     da = new SqlDataAdapter("SELECT * FROM [proyecto].[dbo].[peticion] WHERE FECHA_RADICADO='" + valor + "'", connecting);
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
            if (valor1 == 1)
            {
                
                Conexion conexion = new Conexion();
                SqlConnection connecting = conexion.connecting();
                SqlDataAdapter da;
                DataTable dt;
                try
                {
                    da = new SqlDataAdapter("SELECT * FROM [proyecto].[dbo].[peticion] WHERE FECHA_PETICION='" + valor + "'", connecting);
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
            if (valor1 == 2)
            {
    
                Conexion conexion = new Conexion();
                SqlConnection connecting = conexion.connecting();
                SqlDataAdapter da;
                DataTable dt;
                try
                {
                    da = new SqlDataAdapter("SELECT * FROM [proyecto].[dbo].[peticion] WHERE FECHA_TUTELA='" + valor + "'", connecting);
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

        private void button1_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
