using System.Windows.Forms;

namespace Pruebas
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BTNInicio_Click(object sender, EventArgs e)
        {
            var form2 = new FormTemas();
            form2.Show();
        }
    }
}
