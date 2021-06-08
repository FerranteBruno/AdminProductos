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

                        if (aux.cantidad == 0)
                        {
                            aux.cantidad = 1;
                        }

                        aux.item = listadoOriginal.Find(x => x.ID.ToString() == Request.QueryString["ID"]);
                        aux.subtotal = aux.cantidad * aux.item.Precio;
                        aux.id = aux.item.ID;

                        enCarrito.Add(aux);


                    }

                    carrito.listado = enCarrito;
                }


                repetidor.DataSource = enCarrito;
                repetidor.DataBind();

            }


            foreach (itemCarrito item in enCarrito)
            {
                carrito.total += item.subtotal;
            }

            lblTotal.Text = carrito.total.ToString("c", nfi);

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

        protected void btnInc_Click(object sender, EventArgs e)
        {

            var argument = ((Button)sender).CommandArgument;
            List<itemCarrito> enCarrito = (List<itemCarrito>)Session["listaEnCarro"];
            itemCarrito sobrecarga = enCarrito.Find(x => x.id.ToString() == argument);

            sobrecarga.cantidad++;

            int cont = 0;

            foreach(itemCarrito item in enCarrito)
            {
                cont++;
                if (item.id == sobrecarga.id)
                {
                    enCarrito[cont].cantidad = sobrecarga.cantidad;
                }
            }

            Session.Add("listaEnCarro", enCarrito);
            Session.Add("Total", carrito);
            repetidor.DataSource = null;
            repetidor.DataSource = enCarrito;
            repetidor.DataBind();
        }

        protected void btnDec_Click(object sender, EventArgs e)
        {
           
            var argument = ((Button)sender).CommandArgument;
            List<itemCarrito> enCarrito = (List<itemCarrito>)Session["listaEnCarro"];
            itemCarrito sobrecarga = enCarrito.Find(x => x.id.ToString() == argument);

            sobrecarga.cantidad--;
            int cont = 0;

            foreach (itemCarrito item in enCarrito)
            {
                cont++;
                if (item.id == sobrecarga.id)
                {
                    enCarrito[cont].cantidad = sobrecarga.cantidad;
                }
            }

            Session.Add("listaEnCarro", enCarrito);
            Session.Add("Total", carrito);
            repetidor.DataSource = null;
            repetidor.DataSource = enCarrito;
            repetidor.DataBind();

        }

    }
}