using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace vistas
{
    public partial class v_nuevaCategoria : Form
    {
        private Categoria cat = null;
        public v_nuevaCategoria()
        {
            InitializeComponent();
        }

        public v_nuevaCategoria(Categoria aux)
        {
            InitializeComponent();
            cat = aux;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void v_nuevaCategoria_Load(object sender, EventArgs e)
        {
            txtNombre.Text = "--Ingrese una Categoria--";

            if (cat != null)
            {
                txtNombre.Text = cat.Nombre;
            }
        }
        private void guardarCategoria()
        {
            Categoria categoria = new Categoria();
            CategoriaNegocio datos = new CategoriaNegocio();

            categoria.Nombre = txtNombre.Text;
            categoria.Estado = true;

            datos.agregar(categoria);
            MessageBox.Show("Categoria Guardada");
            txtNombre.Text = "";
        }

        private void modificarCategoria()
        {
            Categoria categoria = new Categoria();
            CategoriaNegocio datos = new CategoriaNegocio();

            if (cat.ID != null)
            {
                categoria.ID = cat.ID;
            }
            categoria.Nombre = txtNombre.Text;
            categoria.Estado = true;

            datos.modificar(categoria);
            MessageBox.Show("Categoria Modificada");
            txtNombre.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cat == null)
            {
                guardarCategoria();
            }
            else
            {
                modificarCategoria();
            }
        }
    }
}
