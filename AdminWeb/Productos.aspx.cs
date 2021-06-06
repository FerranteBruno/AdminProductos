using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using negocio;
using dominio;


namespace AdminWeb
{
    public partial class Productos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ProductoNegocio producto = new ProductoNegocio();
            try
            {
                dgvProductos.DataSource = producto.listar();
                dgvProductos.DataBind();
            }catch(Exception ex)
            {
                Response.Redirect("Error.aspx");
            }
        }
    }
}