using dominio;
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

namespace vistas
{
    public partial class v_nuevoProducto : Form
    {
        private List<Control> Controles = new List<Control>();
        private Producto prod=null;
        
        public v_nuevoProducto()
        {
            InitializeComponent();
            Controles.Add(txtCodigo);
            Controles.Add(txtNombre);
            Controles.Add(txtStock);
            Controles.Add(cbxMarca);
            Controles.Add(cbxCategoria);
            Controles.Add(txtUrlImagen);
            Controles.Add(txtPrecio);
            Controles.Add(txtDescripcion);
        }
        public v_nuevoProducto(Producto aux)
        {
            InitializeComponent();
            Controles.Add(txtCodigo);
            Controles.Add(txtNombre);
            Controles.Add(txtStock);
            Controles.Add(cbxMarca);
            Controles.Add(cbxCategoria);
            Controles.Add(txtUrlImagen);
            Controles.Add(txtPrecio);
            Controles.Add(txtDescripcion);
            prod = aux;
            lblTitulo.Text= "Modificar Producto";
        }

        #region --Funciones--

        public bool  checkControles(List<Control> listado)
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

                    if (b.Text == "--Seleccione Categoria--" || b.Text == "--Seleccione Marca--")
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
                a.Handled = true;
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

        private void FondoRojoBlanco(ref TextBox caja)
        {
            if (caja.BackColor == Color.Red)
            {
                caja.BackColor = Color.White;
            }
        }

        private void guardarProducto()
        {
            Producto prod = new Producto();
            ProductoNegocio datos = new ProductoNegocio();

            prod.Codigo = txtCodigo.Text;
            prod.Nombre = txtNombre.Text;
            prod.Descripcion = txtDescripcion.Text;
            prod.Marca = (Marca)cbxMarca.SelectedItem;
            prod.Categoria = (Categoria)cbxCategoria.SelectedItem;
            prod.UrlImagen = txtUrlImagen.Text;
            prod.Precio = float.Parse(txtPrecio.Text);
            prod.Stock = float.Parse(txtStock.Text);
            prod.Estado = true;

            datos.agregar(prod);
            MessageBox.Show("Producto Guardado");
            limpiarCampos(Controles);
        }
        private void modificarProducto()
        {
            Producto produ = new Producto();
            ProductoNegocio datos = new ProductoNegocio();

            produ.ID = prod.ID;
            produ.Codigo = txtCodigo.Text;
            produ.Nombre = txtNombre.Text;
            produ.Descripcion = txtDescripcion.Text;
            produ.Marca = (Marca)cbxMarca.SelectedItem;
            produ.Categoria = (Categoria)cbxCategoria.SelectedItem;
            produ.UrlImagen = txtUrlImagen.Text;
            produ.Precio = float.Parse(txtPrecio.Text);
            produ.Stock = float.Parse(txtStock.Text);
            produ.Estado = true;

            datos.modificar(produ);
            MessageBox.Show("Producto Modificado");
            limpiarCampos(Controles);
            this.Close();
        }
        private void cargarComboBox()
        {
            MarcaNegocio marc = new MarcaNegocio();
            CategoriaNegocio cate = new CategoriaNegocio();

            List<Categoria> liscat = cate.listar();
            List<Marca> listmarc = marc.listar();
             
            cbxCategoria.DataSource = liscat.OrderBy(o => o.Nombre).ToList();
            cbxCategoria.ValueMember = "id";
            cbxCategoria.DisplayMember = "Nombre";

            cbxMarca.DataSource = listmarc.OrderBy(o => o.Nombre).ToList();
            cbxMarca.ValueMember = "id";
            cbxMarca.DisplayMember = "Nombre";

            cbxCategoria.Text = "--Seleccione Categoria--";
            cbxMarca.Text = "--Seleccione Marca--";
        }
        
        #endregion

        private void v_nuevoProducto_Load(object sender, EventArgs e)
        {
            cargarComboBox();

            if (prod != null)
            {
                txtCodigo.Text = prod.Codigo;
                txtNombre.Text = prod.Nombre;
                txtUrlImagen.Text = prod.UrlImagen;

                cbxMarca.SelectedValue = prod.Marca.ID;
                cbxCategoria.SelectedValue = prod.Categoria.ID;

                txtPrecio.Text = prod.Precio.ToString();
                txtStock.Text = prod.Stock.ToString();
                txtDescripcion.Text = prod.Descripcion;
            }
            txtCodigo.Select();
        }        

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            pbImagenProducto.ImageLocation = txtUrlImagen.Text.ToString();
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {


            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
            {
                e.Handled = true;
                FondoRojoBlanco(ref txtStock);
            }

            saltoDeCampo(e, cbxMarca);
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
            {
                FondoRojoBlanco(ref txtStock);
                e.Handled = true;
            }

            saltoDeCampo(e, txtDescripcion);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (checkControles(Controles))
            {
                if (prod == null)
                {
                    guardarProducto();
                }
                else
                {
                    modificarProducto();

                }
            }
        }

        private void cbxMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            cbxMarca.BackColor = Color.White;
            saltoDeCampo(e, cbxCategoria);
        }

        private void cbxCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            cbxCategoria.BackColor = Color.White;
            saltoDeCampo(e, txtUrlImagen);
        }

        private void txtUrlImagen_KeyPress(object sender, KeyPressEventArgs e)
        {
            FondoRojoBlanco(ref txtUrlImagen);
            saltoDeCampo(e, txtPrecio);
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            FondoRojoBlanco(ref txtDescripcion);
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnGuardar.PerformClick();         
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarCampos(Controles);
            this.Close();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            FondoRojoBlanco(ref txtNombre);
            saltoDeCampo(e, txtStock);
        }

        private void btnNuevaMarca_Click(object sender, EventArgs e)
        {
            v_nuevaMarca vent = new v_nuevaMarca(true);
            vent.ShowDialog();
            cargarComboBox();
        }

        private void btnNuevaCategoria_Click(object sender, EventArgs e)
        {
            v_nuevaCategoria vent = new v_nuevaCategoria(true);
            vent.ShowDialog();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            FondoRojoBlanco(ref txtCodigo);
            saltoDeCampo(e, txtNombre);
        }

        private void cbxMarca_Enter(object sender, EventArgs e)
        {
            cbxMarca.BackColor = Color.White;
        }

        private void cbxCategoria_Enter(object sender, EventArgs e)
        {
            cbxCategoria.BackColor = Color.White;
        }
    }
}
