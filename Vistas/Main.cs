using GH_Incapacidades_medica.Properties;
using Microsoft.Win32;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Resources;
using System.Threading;
using System.Windows.Forms;
namespace GH_Incapacidades_medica
{
    public partial class Main : Form
    {

        public Main()
        {

            ejecutar();
            SetStartup();

            textBox5.Enabled = false;

            DateTime fechaActual = DateTime.Today;
            hora.Text = "FECHA : " + fechaActual.ToString("dd MMMM, yyyy ").ToUpper();
            
            dateTimePicker1.Value = fechaActual;
            dateTimePicker2.Value = fechaActual;

            //Creamos el delegado SEMANA
            ThreadStart delegado = new ThreadStart(SEMANA);
            Thread hilo = new Thread(delegado);
            hilo.Start();

            //Creamos el delegado SEMANA
            ThreadStart delegado2 = new ThreadStart(EPS);
            Thread hilo2 = new Thread(delegado2);
            hilo2.Start();

            CONSULTA();


            if (string.IsNullOrEmpty(textBox1.Text))
            {
                button1.Enabled = false;
            }

        }
        public bool ejecutar()
        {
            string currPrsName = Process.GetCurrentProcess().ProcessName;

            //Get the name of all processes having the 
            //same name as this process name 
            Process[] allProcessWithThisName
                         = Process.GetProcessesByName(currPrsName);

            //if more than one process is running return true.
            //which means already previous instance of the application 
            //is running
            if (allProcessWithThisName.Length > 1)
            {
                MessageBox.Show("LA APLICACION YA SE ESTA EJECUTANDO ", "NO SE PUEDE ABRIR", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return true; // Yes Previous Instance Exist
            }
            else
            {
                InitializeComponent();
                verificar();
                return false; //No Prev Instance Running
            }
        }

        public void CONSULTA()
        {

            Conexion conexion = new Conexion();
            SqlConnection connecting = conexion.connecting();
            SqlDataAdapter da;
            DataTable dt;
            try
            {
                da = new SqlDataAdapter("SELECT CEDULA,NOMBRE,INCAPACIDAD,FECHA_INICIO,FECHA_FINAL FROM [proyecto].[dbo].[incapacidad]", connecting);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                da = new SqlDataAdapter("SELECT * FROM [proyecto].[dbo].[peticion]", connecting);
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
        public void EPS()
        {
            string[] EPS = { "S.O.S", "SANITAS", "EMSSANAR", "CONFELNACO", "SURA EPS", "ARL SURA", "ASMET SALUD", "SALUD TOTAL", "COOSALUD", "COOMEVA", "NUEVA EPS", "EPS SURAMERICANA", "MEDIMAS" };
            for (int i = 0; i < EPS.Length; i++)
            {
                comboBox9.Items.Add(EPS[i]);
            }
            comboBox9.SelectedIndex = +0;
        }
        public void SEMANA()
        {
            string[] semana = { "LUNES", "MARTES", "MIERCOLES", "JUEVES", "VIERNES", "SABADO", "DOMINGO" };
            for (int i = 0; i < semana.Length; i++)
            {
                comboBox7.Items.Add(semana[i]);
            }
            comboBox7.SelectedIndex = +0;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox textbo = (TextBox)sender;
            string busca = textbo.Text;
            if (!string.IsNullOrEmpty(busca))
            {
                Buscar(busca);
            }
        }
        public void Buscar(string busca)
        {

            string[] empresa = { "Mainco", "Ocupar", "Biosecurity", "Foi asociados" };
            string[] eventro = { "Enfermedad general", "Accidente Transito", "Accidente Laboral", "Licencia Maternidad", "Licencia Paternidad", "Pre-Licencia", "Enfermedad Laboral" };
            Conexion conexion = new Conexion();
            SqlConnection connecting = conexion.connecting();
            SqlDataReader reader = conexion.reader();
            try
            {
                string consulta = "SELECT * FROM proyecto.dbo.personas where Cedula=" + busca + ""; //Consulta a MySQL (Muestra las bases de datos que tiene el servidor)
                SqlCommand comando = new SqlCommand(consulta)
                {
                    Connection = connecting //Establece la MySqlConnection utilizada por esta instancia de MySqlCommand
                }; //Declaración SQL para ejecutar contra una base de datos MySQL
                connecting.Open(); //Abre la conexión
                reader = comando.ExecuteReader(); //Ejecuta la consulta y crea un MySqlDataReader

                while (reader.Read()) //Avanza MySqlDataReader al siguiente registro
                {
                    string nombre =  reader.GetString(2) ;
                    string area =  reader.GetString(4) ;
                    string cargo =  reader.GetString(3) ;//Almacena cada registro con un salto de linea


                    comboBox1.Items.Clear();
                    comboBox2.Items.Clear();
                    comboBox3.Items.Clear();

                        comboBox1.Items.Add(nombre);
                        comboBox2.Items.Add(area);
                        comboBox3.Items.Add(cargo);
                    


                    comboBox1.SelectedIndex = +0;
                    comboBox2.SelectedIndex = +0;
                    comboBox3.SelectedIndex = +0;

                    for (int i = 0; i < empresa.Length; i++)
                    {
                        comboBox4.Items.Add(empresa[i]);
                    }
                    comboBox4.SelectedIndex = +0;

                    for (int i = 0; i < eventro.Length; i++)
                    {
                        comboBox5.Items.Add(eventro[i]);
                    }
                    comboBox5.SelectedIndex = +0;



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
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            TextBox evento = (TextBox)sender;
            string code = evento.Text;
            if (code != "")
            {
                TipoIncapacidad(code);
            }


        }
        public void TipoIncapacidad(string code)
        {

            Conexion conexion = new Conexion();
            SqlConnection connecting = conexion.connecting();
            SqlDataReader reader = conexion.reader();
            try
            {
                string consulta = "SELECT dianostico,capitulo FROM proyecto.dbo.riesgo WHERE codigo='" + code + "'"; //Consulta a MySQL (Muestra las bases de datos que tiene el servidor)
                SqlCommand comando = new SqlCommand(consulta)
                {
                    Connection = connecting //Establece la MySqlConnection utilizada por esta instancia de MySqlCommand
                }; //Declaración SQL para ejecutar contra una base de datos MySQL
                connecting.Open(); //Abre la conexión
                reader = comando.ExecuteReader(); //Ejecuta la consulta y crea un MySqlDataReader

                while (reader.Read()) //Avanza MySqlDataReader al siguiente registro
                {
                    string incapacidad = reader.GetString(0);//Almacena cada registro con un salto de linea
                    comboBox6.Items.Clear();
                    comboBox6.Items.Add(incapacidad);

                    comboBox6.SelectedIndex = +0;
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
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

            DateTime fechainicio = dateTimePicker1.Value;
            DateTime fechafin = dateTimePicker2.Value.AddHours(+24);
            int DIAS = (fechafin - fechainicio).Days;
            DIAS_ASUMIDAS.Text = "" + DIAS;

        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox5.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(DIAS_ASUMIDAS.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("LOS CAMPOS ESTAN VACIOS","VACIO !!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else { 
                    DialogResult btn = MessageBox.Show("LOS DATOS ESTAN CORRECTOS ?", "VERIFICACION", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (btn == DialogResult.Yes)
                {
                    insertar();
                }
                else
                {
                    MessageBox.Show("VERIFIQUE LOS DATOS PRIMERO SI TODO ESTA CORRECTO !!", "VERIFIQUE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        public void insertar()
        {

            DateTime fechaActual = DateTime.Today;
            string mes = fechaActual.ToString("MMMM").ToUpper();

            string radicado = textBox5.Text;
            string eps = comboBox9.SelectedItem.ToString();
            string cedula = textBox1.Text;

            string nombre = comboBox1.SelectedItem.ToString();
            string cargo = comboBox2.SelectedItem.ToString();
            string area = comboBox3.SelectedItem.ToString();
            string empresa = comboBox4.SelectedItem.ToString();
            string evento = comboBox5.SelectedItem.ToString();
            string codigo = textBox2.Text;
            string codigodes = comboBox6.SelectedItem.ToString();

            string fechainicio = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            string fechafin = dateTimePicker2.Value.ToString("dd/MM/yyyy");
            string diaincap = DIAS_ASUMIDAS.Text;


            string asumidoempresa = textBox3.Text;
            string noasumidoempresa = textBox4.Text;
            string diaincapinicial = comboBox7.SelectedItem.ToString();


            Conexion conexion = new Conexion();
            SqlConnection connecting = conexion.connecting();

            try
            {


                string consulta = "INSERT INTO [proyecto].[dbo].[incapacidad] (MES,CEDULA,RADICADO,NOMBRE,EPS,CARGO,AREA,EMPRESA,INCAPACIDAD,CODIGO,DESCRIPCION,FECHA_INICIO,FECHA_FINAL,DIAS_INCAPACIDAD,DIAS_ASUMIDA,DIAS_NO_LABORADO,DIA_INICIA_INCAPACIDAD) VALUES('" + mes + "','" + cedula + "','" + radicado + "','" + nombre + "','" + eps + "','" + cargo + "','" + area + "','" + empresa + "','" + evento + "','" + codigo + "','" + codigodes + "','" + fechainicio + "','" + fechafin + "','" + diaincap + "','" + asumidoempresa + "','" + noasumidoempresa + "','" + diaincapinicial + "')"; //Consulta a MySQL (Muestra las bases de datos que tiene el servidor)
                SqlCommand comando = new SqlCommand(consulta)
                {
                    Connection = connecting //Establece la MySqlConnection utilizada por esta instancia de MySqlCommand
                }; //Declaración SQL para ejecutar contra una base de datos MySQL
                connecting.Open(); //Abre la conexión
                comando.ExecuteReader(); //Ejecuta la consulta y crea un MySqlDataReader

                insertarpeticion();
                MessageBox.Show("EL REGISTRO FUE INSERTADO CORRECTAMENTE !!", "EXITOSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CONSULTA();
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
        public void insertarpeticion()
        {

            DateTime fechaActual = DateTime.Today;
            DateTime fechaActual2;
            DateTime fechaActual3;

            string radicado = textBox5.Text;
            string fecharadicado = fechaActual.ToString("dd/MM/yyyy");
            fechaActual2 = fechaActual.AddDays(15);
            string fechapeticion = fechaActual2.ToString("dd/MM/yyyy");
            fechaActual3 = fechaActual2.AddDays(15);
            string fechatutela = fechaActual3.ToString("dd/MM/yyyy");



            Conexion conexion = new Conexion();
            SqlConnection connecting = conexion.connecting();

            try
            {

                string consulta2 = "INSERT INTO [proyecto].[dbo].[peticion] (RADICADO,FECHA_RADICADO,FECHA_PETICION,FECHA_TUTELA) VALUES('" + radicado + "','" + fecharadicado + "','" + fechapeticion + "','" + fechatutela + "')"; //Consulta a MySQL (Muestra las bases de datos que tiene el servidor)
                SqlCommand comando2 = new SqlCommand(consulta2)
                {
                    Connection = connecting //Establece la MySqlConnection utilizada por esta instancia de MySqlCommand
                }; //Declaración SQL para ejecutar contra una base de datos MySQL
                connecting.Open(); //Abre la conexión
                comando2.ExecuteReader(); //Ejecuta la consulta y crea un MySqlDataReader

                CONSULTA();
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
        public void verificar()
        {

            int dato = 0;
            int dato1 = 1;
            int dato2 = 2;

            DateTime fechaActual = DateTime.Today;
            string hoy = fechaActual.ToString("dd/MM/yyyy");
            string Nradicado = null;
            string radicado = null;
            string peticion = null;
            string tutela = null;

            Conexion conexion = new Conexion();
            SqlConnection connecting = conexion.connecting();
            SqlDataReader reader = conexion.reader();
            try
            {
                string consulta = "SELECT * FROM proyecto.dbo.peticion "; //Consulta a MySQL (Muestra las bases de datos que tiene el servidor)
                SqlCommand comando = new SqlCommand(consulta)
                {
                    Connection = connecting //Establece la MySqlConnection utilizada por esta instancia de MySqlCommand
                }; //Declaración SQL para ejecutar contra una base de datos MySQL
                connecting.Open(); //Abre la conexión
                reader = comando.ExecuteReader(); //Ejecuta la consulta y crea un MySqlDataReader

                while (reader.Read()) //Avanza MySqlDataReader al siguiente registro
                {
                    Nradicado = reader.GetString(1);
                    radicado = reader.GetString(2); //Almacena cada registro con un salto de linea
                    peticion = reader.GetString(3);
                    tutela = reader.GetString(4);

                }
                if (hoy == radicado)
                {

                    dynamic result = MessageBox.Show("EXISTE INCAPADIADES POR VENCER ?", "EXISTE INCAPACIDAD", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {

                        Notificacion_Radicado form2 = new Notificacion_Radicado(radicado,dato);
                        form2.Show();
                        Application.Run(form2);
                    }
                    if (result == DialogResult.No)
                    {
                        MessageBox.Show("DEBE VER LOS RADICADOS YA QUE LLEGO A SU FECHA LIMITE", "DEBE REVISAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Notificacion_Radicado form2 = new Notificacion_Radicado(radicado, dato);
                        form2.Show();
                        Application.Run(form2);
                    }


                }
                if (hoy == peticion)
                {
                    dynamic result = MessageBox.Show("EXISTE INCAPADIADES POR VENCER ?", "EXISTE INCAPACIDAD", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {

                        Notificacion_Radicado form2 = new Notificacion_Radicado(peticion, dato1);
                        form2.Show();
                        Application.Run(form2);
                    }
                    if (result == DialogResult.No)
                    {
                        MessageBox.Show("DEBE VER LOS RADICADOS YA QUE LLEGO A SU FECHA LIMITE", "DEBE REVISAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Notificacion_Radicado form2 = new Notificacion_Radicado(peticion, dato1);
                        form2.Show();
                        Application.Run(form2);
                    }
                }
                if (hoy == tutela)
                {
                    dynamic result = MessageBox.Show("EXISTE INCAPADIADES POR VENCER ?", "EXISTE INCAPACIDAD", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {

                        Notificacion_Radicado form2 = new Notificacion_Radicado(tutela, dato2);
                        form2.Show();
                        Application.Run(form2);
                    }
                    if (result == DialogResult.No)
                    {
                        MessageBox.Show("DEBE VER LOS RADICADOS YA QUE LLEGO A SU FECHA LIMITE", "DEBE REVISAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Notificacion_Radicado form2 = new Notificacion_Radicado(tutela, dato2);
                        form2.Show();
                        Application.Run(form2);
                    }
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
        private void SetStartup()
        {
            string appName = System.Diagnostics.Process.GetCurrentProcess().ProcessName;
            RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            rk.SetValue(appName, Application.ExecutablePath);
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.Visible = true;
                notifyIcon1.Icon = Properties.Resources.mainco;
                notifyIcon1.Text = "Notificacion";
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(2000, "Informacion", "la aplicacion esta minimizada!", ToolTipIcon.Info);
            }
        }
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Maximized;
            notifyIcon1.Visible = false;

        }
        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dynamic result = MessageBox.Show("ESTAS SEGURO QUE DESEAS SALIR ?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }


        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                dynamic result = MessageBox.Show("ESTAS SEGURO QUE DESEAS SALIR ?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }

                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Eps eps = new Eps();
            eps.Show();


        }

        private void abrirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Maximized;
            notifyIcon1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            Edicion form4 = new Edicion();
            form4.Show();

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            button3.Enabled = true;
            button1.Enabled = true;
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView2.SelectedRows)
            {
               
                string Radicado = row.Cells[0].Value.ToString();
                InforRadicado inforRadicado = new InforRadicado(Radicado);
                inforRadicado.Show();
                
            }
        }

        private void checkBox2_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = true;

            textBox5.Text = "SIN RADICADO";
            textBox5.Enabled = false;
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
            checkBox1.Checked = true;

            textBox5.Text = "";
            textBox5.Enabled = true;
        }
    }

}

