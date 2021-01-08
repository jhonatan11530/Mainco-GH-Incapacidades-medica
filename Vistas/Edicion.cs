using GH_Incapacidades_medica.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GH_Incapacidades_medica
{
    public partial class Edicion : Form
    {
        public Edicion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Editar_personas editar = new Editar_personas();
            editar.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Editar_Radicado editar = new Editar_Radicado();
            editar.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Borrar borrar = new Borrar();
            borrar.Show();
            this.Hide();
        }
    }
}
