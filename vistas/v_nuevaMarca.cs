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
    public partial class v_nuevaMarca : Form
    {
        private Marca marc = null;
        private bool ventana = false;

        public v_nuevaMarca()
        {
            InitializeComponent();
        }
        public v_nuevaMarca(bool aux)
        {
            InitializeComponent();
            ventana = aux;
            if (aux)
            {
                pnlGrid.Visible = false;
                this.Width = 345;
                this.Height = 177;
            }
        }
        public v_nuevaMarca(Marca aux)
        {
            InitializeComponent();
            marc = aux;
            label2.Text = "Modificar Marca";
        }

        private void cargarMarcas()
        {
            MarcaNegocio marc = new MarcaNegocio();
            dgvMarcas.DataSource = null;
            dgvMarcas.Rows.Clear();
            dgvMarcas.AutoGenerateColumns = false;
            dgvMarcas.ClearSelection();
            dgvMarcas.DataSource = marc.listar();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void v_nuevaMarca_Load(object sender, EventArgs e)
        {
            cargarMarcas();
            //txtNombre.Text = "--Ingrese una Marca--";
            txtNombre.Focus();
            if(marc != null)
            {
                txtNombre.Text = marc.Nombre;
            }
        }

        private void guardarMarca()
        {
            Marca marca = new Marca();
            MarcaNegocio datos = new MarcaNegocio();

            marca.Nombre = txtNombre.Text;
            marca.Estado = true;

            datos.agregar(marca);
            MessageBox.Show("Marca Guardada");
            txtNombre.Text = "";
        }

        private void modificarMarca()
        {
            Marca marca = new Marca();
            MarcaNegocio datos = new MarcaNegocio();

            if (marc.ID != null)
            {
                marca.ID = marc.ID;
            }
            marca.Nombre = txtNombre.Text;
            marca.Estado = true;

            datos.modificar(marca);
            MessageBox.Show("Marca Modificada");
            txtNombre.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            {
                if (marc == null)
                {
                    guardarMarca();
                    if (ventana)
                    {
                        this.Close();
                    }
                }
                else
                {
                    modificarMarca();
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese el nombre de la marca");
                txtNombre.Focus();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtNombre_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
        //    if (txtNombre.Text == "")
        //    {
        //        txtNombre.Text = "--Ingrese una Marca--";
        //    }
        }

        private void dgvMarcas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvMarcas_Leave(object sender, EventArgs e)
        {
            if (btnEliminar.Focused == false)
            {
                btnEliminar.Enabled = false;
            }
        }

        private void dgvMarcas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEliminar.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MarcaNegocio datos = new MarcaNegocio();

            int eliminado = int.Parse(dgvMarcas.CurrentRow.Cells[0].Value.ToString());

            var result = MessageBox.Show("Eliminar marca?", "Eliminar Marca", MessageBoxButtons.YesNo);
            if ( result == DialogResult.Yes)
            {
                datos.eliminar(eliminado);
            }
            cargarMarcas();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ventana)
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    guardarMarca();
                    e.Handled = true;
                    this.Close();
                }
            }
        }
    }
}
