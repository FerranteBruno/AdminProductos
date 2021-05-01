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
            label2.Text = "Modificar Categoría";
        }

        private void cargarCategorias()
        {
            CategoriaNegocio cat = new CategoriaNegocio();
            dgvCategorias.DataSource = null;
            dgvCategorias.Rows.Clear();
            dgvCategorias.AutoGenerateColumns = false;
            dgvCategorias.ClearSelection();
            dgvCategorias.DataSource = cat.listar();
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
            cargarCategorias();
            txtNombre.Text = "--Ingrese una Categoría--";

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
            MessageBox.Show("Categoría Guardada");
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
            MessageBox.Show("Categoría Modificada");
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "--Ingrese una Categoría--";
            }
        }

        private void dgvCategorias_Leave(object sender, EventArgs e)
        {
            if (btnEliminar.Focused == false)
            {
                btnEliminar.Enabled = false;
            }
        }

        private void txtNombre_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            CategoriaNegocio datos = new CategoriaNegocio();

            int eliminado = int.Parse(dgvCategorias.CurrentRow.Cells[0].Value.ToString());

            var result = MessageBox.Show("Eliminar categoría?", "Eliminar Categoría", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                datos.eliminar(eliminado);
            }
        }

        private void dgvCategorias_Click(object sender, EventArgs e)
        {
            btnEliminar.Enabled = true;
        }
    }
}
