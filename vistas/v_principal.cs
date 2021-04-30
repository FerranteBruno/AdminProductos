using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vistas
{
    public partial class v_principal : Form
    {
        private Form formActivo = null;
        public v_principal()
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

        private void abrirFormHijo(Form hijo)
        {
            if (formActivo != null)
            {
                formActivo.Close();
            }
            formActivo = hijo;
            hijo.TopLevel = false;
            hijo.FormBorderStyle = FormBorderStyle.None;
            hijo.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(hijo);
            pnlContenedor.Tag = hijo;
            hijo.BringToFront();
            hijo.Show();
        }

        private void abrirYcomprobarForm(Form vent)
        {
            Type tipo = vent.GetType();
            if (formActivo == null || formActivo.GetType() != tipo)
            {
                abrirFormHijo(vent);
            }
            else
            {
                formActivo.Close();
                formActivo = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ocultarMostrarPaneles(pnlVer);
            if (pnlVer.Visible == true)
            {
                pnlAdministracion.Visible = false;
            }
            
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            abrirYcomprobarForm(new v_productos());

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        int posx = 0;
        int posy = 0;
        private void pnlTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posx = e.X;
                posy = e.Y;
            }
            else
            {
                Left = Left + (e.X - posx);
                Top = Top + (e.Y - posy);
            }
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            abrirYcomprobarForm(new v_nuevoProducto());
        }

        private void btnAdministracion_Click(object sender, EventArgs e)
        {
            ocultarMostrarPaneles(pnlAdministracion);
            if (pnlAdministracion.Visible == true)
            {
                pnlVer.Visible = false;
            }
        }

        private void btnNuevaCategoria_Click(object sender, EventArgs e)
        {
            abrirYcomprobarForm(new v_nuevaCategoria());
        }

        private void btnNuevaMarca_Click(object sender, EventArgs e)
        {
            abrirYcomprobarForm(new v_nuevaMarca());
        }

        private void btnModMarca_Click(object sender, EventArgs e)
        {

        }
    }
}
