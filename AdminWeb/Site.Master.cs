using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;
using negocio;

namespace AdminWeb
{
    public partial class SiteMaster : MasterPage
    {
        public string sToCarrito;
        public CarritoCompra carrito;
        protected void Page_Load(object sender, EventArgs e)
        {
            carrito = (CarritoCompra)Session["Total"];

            if (carrito == null)
                sToCarrito = "Carrito(0)";
            else
            {
                sToCarrito = "Carrito(" + carrito.listado.Count() + ")";
            }

        }
    }
}