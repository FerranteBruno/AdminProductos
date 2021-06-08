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
        //public List<Producto> ListaEnCarrito;
        public CarritoCompra carrito = new CarritoCompra();
        public List<itemCarrito> ListaEnCarrito;
        NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
        double totalAux;

        protected void Page_Load(object sender, EventArgs e)
        {

            ListaEnCarrito = (List<itemCarrito>)Session["listaEnCarro"];
            carrito = (CarritoCompra)Session["Total"];


            if (ListaEnCarrito == null)
                ListaEnCarrito = new List<itemCarrito>();

            if (carrito == null)
                carrito = new CarritoCompra();


            if (!IsPostBack)
            {
                if (Request.QueryString["ID"] != null)
                {
                    if (ListaEnCarrito.Find(x => x.item.ID.ToString() == Request.QueryString["ID"]) == null)
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

                        carrito.total += aux.item.Precio;

                        lblTotal.Text = "Total: " + carrito.total.ToString("c", nfi);

                        ListaEnCarrito.Add(aux);
                    }
                    carrito.listado = ListaEnCarrito;

                }
                repetidor.DataSource = ListaEnCarrito;
                repetidor.DataBind();
            }

            lblTotal.Text = "Total: " + carrito.total.ToString("c", nfi);
            Session.Add("listaEnCarro", ListaEnCarrito);
            Session.Add("Total", carrito);
        }

        protected void btnEliminar2_Click(object sender, EventArgs e)
        {
            carrito = (CarritoCompra)Session["Total"];

            var argument = ((Button)sender).CommandArgument;
            List<itemCarrito> ListaEnCarrito = (List<itemCarrito>)Session["listaEnCarro"];
            itemCarrito elim = ListaEnCarrito.Find(x => x.id.ToString() == argument);
            ListaEnCarrito.Remove(elim);

            carrito.total -= elim.subtotal;
            if (carrito.total < 0) carrito.total = 0;
            lblTotal.Text = "Total: " + carrito.total.ToString("c", nfi);

            Session.Add("listaEnCarro", ListaEnCarrito);
            Session.Add("Total", carrito);
            repetidor.DataSource = null;
            repetidor.DataSource = ListaEnCarrito;
            repetidor.DataBind();

            /*if(!(carrito.listado.Count()==1))
            Server.TransferRequest(Request.Url.AbsolutePath, false);*/


        }
        protected void btnInc_Click(object sender, EventArgs e)
        {
            carrito = (CarritoCompra)Session["Total"];
            totalAux = 0;
            var argument = ((Button)sender).CommandArgument;
            List<itemCarrito> ListaEnCarrito = (List<itemCarrito>)Session["listaEnCarro"];
            itemCarrito sobrecarga = ListaEnCarrito.Find(x => x.id.ToString() == argument);


            sobrecarga.cantidad++;
            sobrecarga.subtotal = sobrecarga.item.Precio * sobrecarga.cantidad;

            var indiceItem = ListaEnCarrito.FindIndex(x => x.id.ToString() == argument);
            ListaEnCarrito[indiceItem] = sobrecarga;

            foreach (itemCarrito i in ListaEnCarrito)
            {
                totalAux += i.subtotal;
            }


            carrito.total = totalAux;

            lblTotal.Text = "Total: " + carrito.total.ToString("c", nfi);

            Session.Add("listaEnCarro", ListaEnCarrito);
            Session.Add("Total", carrito);
            repetidor.DataSource = null;
            repetidor.DataSource = ListaEnCarrito;
            repetidor.DataBind();

            
            Server.TransferRequest(Request.Url.AbsolutePath, false);
        }

        protected void btnDec_Click(object sender, EventArgs e)
        {
            carrito = (CarritoCompra)Session["Total"];

            totalAux = 0;

            var argument = ((Button)sender).CommandArgument;
            List<itemCarrito> ListaEnCarrito = (List<itemCarrito>)Session["listaEnCarro"];
            itemCarrito sobrecarga = ListaEnCarrito.Find(x => x.id.ToString() == argument);
            if (sobrecarga.cantidad>1)
            {
                sobrecarga.cantidad--;
                sobrecarga.subtotal = sobrecarga.item.Precio * sobrecarga.cantidad;
                var elementIndex = ListaEnCarrito.FindIndex(x => x.id.ToString() == argument);
                ListaEnCarrito[elementIndex] = sobrecarga;

                foreach (itemCarrito i in ListaEnCarrito)
                {
                    totalAux += i.subtotal;
                }


                carrito.total = totalAux;

                lblTotal.Text ="Total: "+ carrito.total.ToString("c", nfi);


                Session.Add("listaEnCarro", ListaEnCarrito);
                Session.Add("Total", carrito);
                repetidor.DataSource = null;
                repetidor.DataSource = ListaEnCarrito;
                repetidor.DataBind();

                Server.TransferRequest(Request.Url.AbsolutePath, false);
            }       

            


        }

    }
}