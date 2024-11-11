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
    public partial class FormTemas : Form
    {
        public FormTemas()
        {
            InitializeComponent();
        }

        private void BTNTema1_Click(object sender, EventArgs e)
        {
            var form3 = new FormTema1();
            form3.Show();
        }
    }
}
