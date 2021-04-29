using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentacion
{
    public partial class v_productos : Form
    {
        public v_productos()
        {
            InitializeComponent();
        }
        private void ocultarMostrarPaneles(Panel aux)
        {
            if (aux.Visible == true)
            {
                aux.Visible = false;
            }
            else
            {
                aux.Visible = true;
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cbxMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
