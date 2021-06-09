using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;
using negocio;

namespace AdminWeb
{
    public partial class ListaProductos : System.Web.UI.Page
    {
        public List<Producto> list;
        public NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
        protected void Page_Load(object sender, EventArgs e)
        {

            ProductoNegocio negocio = new ProductoNegocio();

            if(Buscador.Text == "") { }
            try{
                list = negocio.listar();

                Session.Add("listadoProductos", list);

            }catch(Exception ex)
            {
                Session.Add("Error", ex.ToString());
                Response.Redirect("Error.aspx");
            }
        }

        protected void Buscador_OnTextChanged(object sender, EventArgs e)
        {
            ProductoNegocio negocio = new ProductoNegocio();
            
            try
            {
                if (Buscador.Text == "")
                {
                    list = negocio.listar();

                }
                else
                {
                    list = negocio.listar(armaConsultaFiltro());
                }
                    Session.Add("listadoProductos", list);
            }
            catch (Exception ex)
            {
                Session.Add("Error", ex.ToString());
                Response.Redirect("Error.aspx");
            }
        }

        private string armaConsultaFiltro()
        {
            string consulta = "";
            if (Buscador.Text != "")
            {
                consulta += " AND Nombre LIKE '%" + Buscador.Text.Trim().ToString() + "%'";

            }

            return consulta;
        }


    }
}