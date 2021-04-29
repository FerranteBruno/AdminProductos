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
    public partial class v_nuevoProducto : Form
    {
        private List<Control> Controles = new List<Control>();
        public v_nuevoProducto()
        {
            InitializeComponent();
            Controles.Add(txtNombre);
            Controles.Add(txtStock);
            Controles.Add(cbxMarca);
            Controles.Add(cbxCategoria);
            Controles.Add(txtUrlImagen);
            Controles.Add(txtPrecio);
            Controles.Add(txtDescripcion);
        }

        private void v_nuevoProducto_Load(object sender, EventArgs e)
        {
            txtNombre.Focus();
        }
        public bool checkControles(List<Control> listado)
        {
            int cont = 0;
            Control aux = new Control();

            bool ok = true;

            foreach (var a in listado)//Busca los controles vacios y los pinta en rojo
            {
                if (a.GetType() == new TextBox().GetType())
                {
                    if (a.Text == "")
                    {
                        cont++;
                        a.BackColor = Color.Red;
                        if (cont == 1) { aux = a; } //Guarda el primer control vacio
                        ok = false;
                    }
                    else
                    {
                        a.BackColor = Color.White;
                    }
                }
                else if (a.GetType() == new ComboBox().GetType())
                {
                    ComboBox b = (ComboBox)a;

                    if (b.SelectedIndex == -1)
                    {
                        cont++;
                        a.BackColor = Color.Red;
                        if (cont == 1) { aux = a; } //Guarda el primer control vacio
                        ok = false;
                    }
                    else
                    {
                        a.BackColor = Color.White;
                    }
                }
            }
            aux.Focus();//Hace focus al primer control vacio
            return ok;
        }
        private void saltoDeCampo(KeyPressEventArgs a, Control aux)
        {
            if (a.KeyChar == (char)Keys.Enter)
            {
                aux.Focus();
            }
        }
        private void limpiarCampos(List<Control> listado)
        {
            List<ComboBox> aux = new List<ComboBox>();

            foreach (var a in listado)//Busca los controles vacios y los pinta en rojo
            {
                if (a.GetType() == new TextBox().GetType())
                {
                    a.Text = "";
                }
                else if (a.GetType() == new ComboBox().GetType())
                {
                    aux.Add((ComboBox)a);
                }
            }
            foreach (ComboBox a in aux)
            {
                a.SelectedIndex = -1;
            }
            listado[0].Focus();
        }

        private void guardarProducto()
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            pbImagenProducto.ImageLocation = txtUrlImagen.Text.ToString();
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
            saltoDeCampo(e, cbxMarca);
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
            saltoDeCampo(e, txtDescripcion);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (checkControles(Controles))
            {
                MessageBox.Show("todo cool");
            }
        }

        private void cbxMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            saltoDeCampo(e, cbxCategoria);
        }

        private void cbxCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            saltoDeCampo(e, txtUrlImagen);
        }

        private void txtUrlImagen_KeyPress(object sender, KeyPressEventArgs e)
        {
            saltoDeCampo(e, txtPrecio);
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                guardarProducto();
                MessageBox.Show("Producto Guardado");
                limpiarCampos(Controles);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarCampos(Controles);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            saltoDeCampo(e,txtStock);
        }

        private void btnNuevaMarca_Click(object sender, EventArgs e)
        {
            v_nuevaMarca vent = new v_nuevaMarca();
            vent.ShowDialog();
        }

        private void btnNuevaCategoria_Click(object sender, EventArgs e)
        {
            v_nuevaCategoria vent = new v_nuevaCategoria();
            vent.ShowDialog();
        }
    }
}
