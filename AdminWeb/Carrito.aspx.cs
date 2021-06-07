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


            if (enCarrito == null)
                enCarrito = new List<itemCarrito>();

            if(!IsPostBack)
            {
                if(Request.QueryString["ID"] != null)
                {
                    if(enCarrito.Find(x => x.item.ID.ToString() == Request.QueryString["ID"]) == null)
                    {
                        List<Producto> listadoOriginal = (List<Producto>)Session["listadoProductos"];
                        itemCarrito aux = new itemCarrito();

                        aux.cantidad = 1;
                        aux.item = listadoOriginal.Find(x => x.ID.ToString() == Request.QueryString["ID"]);
                        aux.subtotal = aux.cantidad * aux.item.Precio;
                        aux.id = aux.item.ID;

                        enCarrito.Add(aux);
                        
                    }
                }
                repetidor.DataSource = enCarrito;
                repetidor.DataBind();
            }

            Session.Add("listaEnCarro", enCarrito);
        }

        protected void btnEliminar2_Click(object sender, EventArgs e)
        {
            var argument = ((Button)sender).CommandArgument;
            List<itemCarrito> enCarrito = (List<itemCarrito>)Session["listaEnCarro"];
            itemCarrito elim = enCarrito.Find(x => x.id.ToString() == argument);
            enCarrito.Remove(elim);
            Session.Add("listaEnCarro", enCarrito);
            repetidor.DataSource = null;
            repetidor.DataSource = enCarrito;
            repetidor.DataBind();
        }

    }
}