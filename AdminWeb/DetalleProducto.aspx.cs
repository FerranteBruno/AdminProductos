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
    public partial class DetalleProducto : System.Web.UI.Page
    {
        public Producto seleccionado;
        public NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
        protected void Page_Load(object sender, EventArgs e)
        {

          int  id = int.Parse(Request.QueryString["id"]);

            List<Producto> listado = (List<Producto>)Session["listadoProductos"];
            seleccionado = listado.Find(x => x.ID == id);

            
        }
    }
}