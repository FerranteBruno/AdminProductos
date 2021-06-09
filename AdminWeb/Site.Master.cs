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
        public string sToCarrito="Carrito";
        public CarritoCompra carrito;
        public int acu = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            carrito = (CarritoCompra)Session["Total"];

            if (carrito == null)
                sToCarrito = "Carrito";
            else
            {
                if (carrito.listado != null)
                {
                    foreach (itemCarrito i in carrito.listado)
                    {
                        acu += i.cantidad;
                    }
                    if (acu != 0)
                    {
                        sToCarrito = "Carrito(" + acu + ")";
                    }
                }
                else
                {
                    sToCarrito = "Carrito";
                }
            }
        }
    }
}