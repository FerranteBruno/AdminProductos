using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;
using negocio;

namespace AdminWeb
{
    public partial class Carrito : System.Web.UI.Page
    {
        //public List<Producto> enCarrito;
        public CarritoCompra carrito = new CarritoCompra();
        public List<itemCarrito> enCarrito;
        NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;

        protected void Page_Load(object sender, EventArgs e)
        {
            enCarrito = (List<itemCarrito>)Session["listaEnCarro"];
            carrito = (CarritoCompra)Session["Total"];


            if (enCarrito == null)
                enCarrito = new List<itemCarrito>();

            if (carrito == null)
                carrito = new CarritoCompra();


            if (!IsPostBack)
            {
                if (Request.QueryString["ID"] != null)
                {
                    if (enCarrito.Find(x => x.item.ID.ToString() == Request.QueryString["ID"]) == null)
                    {
                        List<Producto> listadoOriginal = (List<Producto>)Session["listadoProductos"];
                        itemCarrito aux = new itemCarrito();

                        aux.cantidad = 1;
                        aux.item = listadoOriginal.Find(x => x.ID.ToString() == Request.QueryString["ID"]);
                        aux.subtotal = Math.Round(aux.cantidad * aux.item.Precio,3);
                        aux.id = aux.item.ID;

                        enCarrito.Add(aux);


                        carrito.total += Math.Round(aux.subtotal,3);
                        carrito.listado = enCarrito;
                    }
                }

                repetidor.DataSource = enCarrito;
                repetidor.DataBind();

            }

            lblTotal.Text = "Total: " + carrito.total.ToString("c",nfi);

            Session.Add("listaEnCarro", enCarrito);
            Session.Add("Total", carrito);

        }

        protected void btnEliminar2_Click(object sender, EventArgs e)
        {
            var argument = ((Button)sender).CommandArgument;
            List<itemCarrito> enCarrito = (List<itemCarrito>)Session["listaEnCarro"];
            itemCarrito elim = enCarrito.Find(x => x.id.ToString() == argument);
            enCarrito.Remove(elim);

            carrito.total -= Math.Round(elim.subtotal,3);
            if (carrito.total < 0) carrito.total = 0;
            lblTotal.Text = carrito.total.ToString("c", nfi);



            Session.Add("listaEnCarro", enCarrito);
            Session.Add("Total", carrito);
            repetidor.DataSource = null;
            repetidor.DataSource = enCarrito;
            repetidor.DataBind();
        }

        protected void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}