﻿using negocio;
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

        private void v_productos_Load(object sender, EventArgs e)
        {
            ProductoNegocio prod = new ProductoNegocio();
            dgvProductos.AutoGenerateColumns = true;
            dgvProductos.DataSource = prod.listar();
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

        }
    }
}
