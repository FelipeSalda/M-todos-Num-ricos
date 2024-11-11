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
    public partial class FormTema1 : Form
    {
        int progreso = 1;
        int puntos = 0;
        public FormTema1()
        {
            InitializeComponent();
        }

        private void FormTema1_Load(object sender, EventArgs e)
        {
            ActualizarEstadoTemas();
            MostrarPuntos();
        }

        private void BTNTerminarT1_Click(object sender, EventArgs e)
        {
            puntos += 40; 
            VerificarDesbloqueo();
        }

        private void ActualizarEstadoTemas()
        {
            lblProgreso.Text = $"Lagrange - Puntos: {puntos}/100";
        }

        private void MostrarPuntos()
        {
            lblProgreso.Text = $"Tema {progreso} - Puntos: {puntos}/100";
        }

        private void lblProgreso_Click(object sender, EventArgs e)
        {

        }
        private void VerificarDesbloqueo()
        {
            MostrarPuntos();
            
            if (puntos >= 100)
            {
                progreso++;
                puntos = 0;
                ActualizarEstadoTemas();
            }
        }

        private void BTNProblemasT1_Click(object sender, EventArgs e)
        {
            if (puntos >= 40)
            {
                var form4 = new FormPTema2();
                form4.Show();
            }
            else
            {
                MessageBox.Show("Necesitas completar la teoría antes de acceder a los problemas.",
                                "Acceso Denegado",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
        }
    }
}
