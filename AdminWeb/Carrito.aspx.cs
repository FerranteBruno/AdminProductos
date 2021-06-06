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
            carrito.listado = enCarrito;

            carrito.listado = (List<itemCarrito>)Session["listaEnCarro"];


            if (carrito.listado == null)
                carrito.listado = new List<itemCarrito>();

            if(!IsPostBack)
            {
                if(Request.QueryString["ID"] != null)
                {
                    if(carrito.listado.Find(x => x.item.ID.ToString() == Request.QueryString["ID"]) == null)
                    {
                        List<Producto> listadoOriginal = (List<Producto>)Session["listadoProductos"];
                        carrito.listado.Add(listadoOriginal.Find(x => x.item.ID.ToString() == Request.QueryString["ID"]));
                        
                    }
                }
                repetidor.DataSource = carrito.listado;
                repetidor.DataBind();
            }

            Session.Add("listaEnCarro", carrito.listado);
        }

        protected void btnEliminar2_Click(object sender, EventArgs e)
        {
            var argument = ((Button)sender).CommandArgument;
            List<Producto> enCarrito = (List<Producto>)Session["listaEnCarro"];
            Producto elim = enCarrito.Find(x => x.ID.ToString() == argument);
            enCarrito.Remove(elim);
            Session.Add("listaEnCarro", enCarrito);
            repetidor.DataSource = null;
            repetidor.DataSource = enCarrito;
            repetidor.DataBind();
        }

    }
}