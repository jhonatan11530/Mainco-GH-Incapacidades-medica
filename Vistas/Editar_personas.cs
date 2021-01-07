using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GH_Incapacidades_medica
{
    public partial class Editar_personas : Form
    {
        public Editar_personas()
        {
            InitializeComponent();
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox textbo = (TextBox)sender;
            string busca = textbo.Text;

            Consulta(busca);
        }
        public void Consulta(string buscas)
        {
            string nombre = null;
            string cargo = null;
            string area = null;
            Conexion conexion = new Conexion();
            SqlConnection connecting = conexion.connecting();
            SqlDataReader reader = conexion.reader();
            try
            {
                string consulta = "SELECT * FROM proyecto.dbo.personas where Cedula=" + buscas + ""; //Consulta a MySQL (Muestra las bases de datos que tiene el servidor)
                SqlCommand comando = new SqlCommand(consulta)
                {
                    Connection = connecting //Establece la MySqlConnection utilizada por esta instancia de MySqlCommand
                }; //Declaración SQL para ejecutar contra una base de datos MySQL
                connecting.Open(); //Abre la conexión
                reader = comando.ExecuteReader(); //Ejecuta la consulta y crea un MySqlDataReader

                while (reader.Read()) //Avanza MySqlDataReader al siguiente registro
                {

                    nombre = reader.GetString(2);
                    cargo = reader.GetString(4);
                    area = reader.GetString(3);

                    textBox3.Text = textBox1.Text;
                    textBox2.Text = nombre;
                    textBox4.Text = cargo;
                    textBox5.Text = area;


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

            string cedula = textBox3.Text;
            string nombre = textBox2.Text;
            string cargo = textBox4.Text;
            string area = textBox5.Text;

            Conexion conexion = new Conexion();
            SqlConnection connecting = conexion.connecting();
            try
            {
                string consulta = "UPDATE [proyecto].[dbo].[personas] SET Cedula='" + cedula + "',Nombre='" + nombre + "',Area='" + area + "',Carga='" + cargo + "' WHERE Cedula=" + cedula + " "; //Consulta a MySQL (Muestra las bases de datos que tiene el servidor)
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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
