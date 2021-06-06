﻿using System;
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
        public List<Producto> enCarrito;
        protected void Page_Load(object sender, EventArgs e)
        {
            enCarrito = (List<Producto>)Session["listaEnCarro"];

            if (enCarrito == null)
                enCarrito = new List<Producto>();

            if(!IsPostBack)
            {
                if(Request.QueryString["ID"] != null)
                {
                    if(enCarrito.Find(x => x.ID.ToString() == Request.QueryString["ID"]) == null)
                    {
                        List<Producto> listadoOriginal = (List<Producto>)Session["listadoProductos"];
                        enCarrito.Add(listadoOriginal.Find(x => x.ID.ToString() == Request.QueryString["ID"]));
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