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
    public partial class Editar_Radicado : Form
    {
        public Editar_Radicado()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox textbo = (TextBox)sender;
            int busca = Int32.Parse(textbo.Text);

            Consulta(busca);
        }
        public void Consulta(int busca)
        {

            string Radicado = null;
            string Fecha_Radicado = null;
            string Fecha_Peticion = null;
            string Fecha_Tutela = null;
            Conexion conexion = new Conexion();
            SqlConnection connecting = conexion.connecting();
            SqlDataReader reader = conexion.reader();
            try
            {
                string consulta = "SELECT * FROM proyecto.dbo.peticion where RADICADO='" + busca + "' "; //Consulta a MySQL (Muestra las bases de datos que tiene el servidor)
                SqlCommand comando = new SqlCommand(consulta)
                {
                    Connection = connecting //Establece la MySqlConnection utilizada por esta instancia de MySqlCommand
                }; //Declaración SQL para ejecutar contra una base de datos MySQL
                connecting.Open(); //Abre la conexión
                reader = comando.ExecuteReader(); //Ejecuta la consulta y crea un MySqlDataReader

                while (reader.Read()) //Avanza MySqlDataReader al siguiente registro
                {

                    Radicado = reader.GetString(1);
                    Fecha_Radicado = reader.GetString(2);
                    Fecha_Peticion = reader.GetString(3);
                    Fecha_Tutela = reader.GetString(4);

                    textBox2.Text = Radicado;
                    dateTimePicker1.Text = Fecha_Radicado;
                    dateTimePicker2.Text = Fecha_Peticion;
                    dateTimePicker3.Text = Fecha_Tutela; 

                }


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

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult btn = MessageBox.Show("LOS DATOS ESTAN CORRECTOS ?", "VERIFICACION", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (btn == DialogResult.Yes)
            {
                MessageBox.Show("LOS DATOS FUERON ACTUALIZADOS CORRECTAMENTE !!", "CORRECTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string valor = textBox1.Text;
                actualizar(valor);
            }
            else
            {
                MessageBox.Show("VERIFIQUE LOS DATOS PRIMERO SI TODO ESTA CORRECTO !!", "VERIFIQUE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public void actualizar(string valor)
        {

            string RADICADO = textBox2.Text;
            string FECHA_RADICADO = dateTimePicker1.Text;
            string FECHA_PETICION = dateTimePicker2.Text;
            string FECHA_TUTELA = dateTimePicker3.Text;

            Conexion conexion = new Conexion();
            SqlConnection connecting = conexion.connecting();
            try
            {
                string consulta = "UPDATE [proyecto].[dbo].[personas] SET RADICADO='" + RADICADO + "',FECHA_RADICADO='" + FECHA_RADICADO + "',FECHA_PETICION='" + FECHA_PETICION + "',FECHA_TUTELA='" + FECHA_TUTELA + "' WHERE RADICADO=" + RADICADO + " "; //Consulta a MySQL (Muestra las bases de datos que tiene el servidor)
                SqlCommand comando = new SqlCommand(consulta)
                {
                    Connection = connecting //Establece la MySqlConnection utilizada por esta instancia de MySqlCommand
                }; //Declaración SQL para ejecutar contra una base de datos MySQL
                connecting.Open(); //Abre la conexión
                comando.ExecuteReader(); //Ejecuta la consulta y crea un MySqlDataReader

                Close();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message); //Si existe un error aquí muestra el mensaje
            }
            finally
            {
                connecting.Close();


                //Cierra la conexión a MySQL
            }

        }

    }
}
