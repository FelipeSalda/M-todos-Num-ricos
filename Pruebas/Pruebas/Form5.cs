using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pruebas
{
    public partial class FormPTema2 : Form
    {
        public FormPTema2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string resCorrecta = "43";
            string resUsuario = txtRespuesta.Text.Trim();
            if(resCorrecta == resUsuario)
            {
                MessageBox.Show("El resultado es correcto");
            }
            else
            {
                MessageBox.Show("El resultado no es correcto");
            }
        }
    }
}
