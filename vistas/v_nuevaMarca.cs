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
            pnlGrid.Visible = false;
            this.Width = 345;
            this.Height = 177;
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
            cargarMarcas();
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

        private void txtNombre_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Marca marc = (Marca)dgvMarcas.CurrentRow.DataBoundItem;

            v_nuevaMarca marcmod = new v_nuevaMarca(marc);

            marcmod.ShowDialog();
            cargarMarcas();
        }

        private void dgvMarcas_Click(object sender, EventArgs e)
        {
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
        }

        private void btnEliminar_EnabledChanged(object sender, EventArgs e)
        {
            if (btnEliminar.Enabled)
            {
                btnEliminar.BackColor = Color.Black;
                btnEliminar.ForeColor = Color.DeepSkyBlue;
            }
            else
            {
                btnEliminar.BackColor = Color.White;
                btnEliminar.ForeColor = SystemColors.ControlText;
            }
        }

        private void btnModificar_EnabledChanged(object sender, EventArgs e)
        {
            if (btnModificar.Enabled)
            {
                btnModificar.BackColor = Color.Black;
                btnModificar.ForeColor = Color.DeepSkyBlue;
            }
            else
            {
                btnModificar.BackColor = Color.White;
                btnModificar.ForeColor = SystemColors.ControlText;
            }
        }
    }
}
