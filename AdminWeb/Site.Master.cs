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
        public int acu=0;
        protected void Page_Load(object sender, EventArgs e)
        {
            carrito = (CarritoCompra)Session["Total"];

            if (carrito == null)
                sToCarrito = "Carrito";
            else
            {
                foreach(itemCarrito i in carrito.listado)
                {
                    acu += i.cantidad;
                }


                sToCarrito = "Carrito(" + acu + ")";
            }

        }
    }
}