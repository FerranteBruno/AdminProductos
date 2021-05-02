using negocio;
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

namespace vistas
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
        private void cargarComboBox()
        {
            MarcaNegocio marc = new MarcaNegocio();
            CategoriaNegocio cate = new CategoriaNegocio();

            cbxCategoria.DataSource = cate.listar();
            cbxCategoria.ValueMember = "id";
            cbxCategoria.DisplayMember = "Nombre";

            cbxMarca.DataSource = marc.listar();
            cbxMarca.ValueMember = "id";
            cbxMarca.DisplayMember = "Nombre";
            cbxCategoria.Text = "--Seleccione Categoria--";
            cbxMarca.Text = "--Seleccione Marca--";
        }
        private void cargarProductos()
        {
            ProductoNegocio prod = new ProductoNegocio();
            dgvProductos.DataSource = null;
            dgvProductos.Rows.Clear();
            dgvProductos.AutoGenerateColumns = false;
            dgvProductos.ClearSelection();
            dgvProductos.DataSource = prod.listar();
        }
        private string armaConsultaFiltro()
        {
            string consulta="";
            if (txtBuscar.Text != "")
            {
                consulta += txtBuscar.Text.ToString();
            }
            //if (cbxMarca.SelectedIndex != -1)
            //{
            //    consulta+="and"
            //}
            return consulta;
        }
        private void buscarProucto()
        {
            ProductoNegocio prod = new ProductoNegocio();
            dgvProductos.DataSource = null;
            dgvProductos.Rows.Clear();
            dgvProductos.AutoGenerateColumns = false;
            dgvProductos.ClearSelection();
            dgvProductos.DataSource = prod.Buscar(armaConsultaFiltro());
        }


        private void v_productos_Load(object sender, EventArgs e)
        {
            cargarComboBox();
            cargarProductos();
            txtBuscar.Focus();
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblNombre.Text= dgvProductos.CurrentRow.Cells[2].Value.ToString();
            lblMarca.Text = dgvProductos.CurrentRow.Cells[4].Value.ToString();
            lblCategoria.Text = dgvProductos.CurrentRow.Cells[5].Value.ToString();
            lblPrecio.Text = dgvProductos.CurrentRow.Cells[7].Value.ToString();
            lblDescripcion.Text = dgvProductos.CurrentRow.Cells[3].Value.ToString();
            picProducto.ImageLocation= dgvProductos.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Producto prod = (Producto)dgvProductos.CurrentRow.DataBoundItem;

            v_nuevoProducto modificar = new v_nuevoProducto(prod);

            modificar.ShowDialog();
            cargarProductos();
            

        }
        private void eliminarProducto(Producto prod)
        {
            ProductoNegocio datos = new ProductoNegocio();

            int eliminado = prod.ID;

            datos.eliminar(eliminado);
            MessageBox.Show("Producto Eliminado");
            cargarProductos();

        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Producto prod = (Producto)dgvProductos.CurrentRow.DataBoundItem;

            var result = MessageBox.Show("Eliminar producto?", "Eliminar Producto", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                eliminarProducto(prod);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            buscarProucto();
        }
    }
}
