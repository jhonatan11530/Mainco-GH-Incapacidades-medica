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

namespace GH_Incapacidades_medica.Vistas
{
    public partial class Borrar : Form
    {
        public Borrar()
        {
            InitializeComponent();

            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;

            dataGridView1.Enabled = false;
            dataGridView2.Enabled = false;
            dataGridView3.Enabled = false;

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;

            LlenarDataGridView();
        }
        public void LlenarDataGridView()
        {

            Conexion conexion = new Conexion();
            SqlConnection connecting = conexion.connecting();
            SqlDataAdapter uno,dos,tres;
            DataTable da, de, di;
            try
            {
                
                uno = new SqlDataAdapter("SELECT CEDULA,NOMBRE,INCAPACIDAD FROM [proyecto].[dbo].[incapacidad]", connecting);
                da = new DataTable();
                uno.Fill(da);
                dataGridView1.DataSource = da;
                
                dos = new SqlDataAdapter("SELECT id,RADICADO,FECHA_RADICADO,FECHA_PETICION,FECHA_TUTELA FROM [proyecto].[dbo].[peticion]", connecting);
                de = new DataTable();
                dos.Fill(de);
                dataGridView2.DataSource = de;
                
                tres = new SqlDataAdapter("SELECT Cedula,Nombre,Carga,Grupada FROM [proyecto].[dbo].[personas]", connecting);
                di = new DataTable();
                tres.Fill(di);
                dataGridView3.DataSource = di;
                

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

        private void checkBox1_Click(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
            checkBox1.Checked = true;
            checkBox3.Checked = false;

            textBox2.Enabled = false;
            textBox3.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;

            button1.Enabled = true;

            textBox1.Enabled = true;
            dataGridView1.Enabled = true;
            dataGridView2.Enabled = false;
            dataGridView3.Enabled = false;
        }

        private void checkBox2_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = true;
            checkBox3.Checked = false;

            textBox1.Enabled = false;
            textBox3.Enabled = false;
            button1.Enabled = false;
            button3.Enabled = false;

            button2.Enabled = true;

            textBox2.Enabled = true;
            dataGridView1.Enabled = false;
            dataGridView3.Enabled = false;
            dataGridView2.Enabled = true;
        }


        private void checkBox3_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = true;

            textBox1.Enabled = false;
            textBox2.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;

            button3.Enabled = true;

            textBox3.Enabled = true;
            dataGridView3.Enabled = true;
            dataGridView1.Enabled = false;
            dataGridView2.Enabled = false;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {

                string Radicado = row.Cells[0].Value.ToString();
                MessageBox.Show(Radicado);

            }
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView2.SelectedRows)
            {

                string Radicado = row.Cells[0].Value.ToString();
                MessageBox.Show(Radicado);

            }
        }

        private void dataGridView3_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView3.SelectedRows)
            {

                string Radicado = row.Cells[0].Value.ToString();
                MessageBox.Show(Radicado);

            }
        }
    }
}
