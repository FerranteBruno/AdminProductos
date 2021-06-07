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
    public partial class Carrito : System.Web.UI.Page
    {
        //public List<Producto> enCarrito;
        public CarritoCompra carrito = new CarritoCompra();
        public List<itemCarrito> enCarrito;


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
                        aux.subtotal = aux.cantidad * aux.item.Precio;
                        aux.id = aux.item.ID;

                        enCarrito.Add(aux);

                       

                        carrito.total += aux.subtotal;
                        carrito.listado = enCarrito;
                    }
                }

                    //foreach (itemCarrito item in enCarrito)
                    //{
                    //    carrito.total += item.subtotal;

                    //    lblTotal.Text = carrito.total.ToString();
                    //}

                repetidor.DataSource = enCarrito;
                repetidor.DataBind();

            }

            lblTotal.Text = carrito.total.ToString();

            Session.Add("listaEnCarro", enCarrito);
            Session.Add("Total", carrito);

        }

        protected void btnEliminar2_Click(object sender, EventArgs e)
        {
            var argument = ((Button)sender).CommandArgument;
            List<itemCarrito> enCarrito = (List<itemCarrito>)Session["listaEnCarro"];
            itemCarrito elim = enCarrito.Find(x => x.id.ToString() == argument);
            enCarrito.Remove(elim);

                carrito.total -= elim.subtotal;

                lblTotal.Text = carrito.total.ToString();



            Session.Add("listaEnCarro", enCarrito);
            Session.Add("Total", carrito);
            repetidor.DataSource = null;
            repetidor.DataSource = enCarrito;
            repetidor.DataBind();
        }

    }
}