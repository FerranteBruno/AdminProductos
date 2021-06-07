using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;
using negocio;

namespace AdminWeb
{
    public partial class ListaProductos : System.Web.UI.Page
    {
        public List<Producto> list;
        public NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
        protected void Page_Load(object sender, EventArgs e)
        {
            ProductoNegocio negocio = new ProductoNegocio();
            try{
                list = negocio.listar();

                Session.Add("listadoProductos", list);

            }catch(Exception ex)
            {
                Session.Add("Error", ex.ToString());
                Response.Redirect("Error.aspx");
            }

        }
    }
}