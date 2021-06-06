<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaProductos.aspx.cs" Inherits="AdminWeb.ListaProductos" %>

<asp:Content ID="ListaCont1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">

        <% foreach (dominio.Producto item in list)
            {%>
            

            <div class="card" style="width: 18rem;">
              <img src="<% = item.UrlImagen %>" class="card-img-top" alt="...">
                  <div class="card-body">
                    <h5 class="card-title"><% = item.Nombre %></h5>
                    <p class="card-text"><% = item.Descripcion %></p>
                  </div>
                  <ul class="list-group list-group-flush">
                    <li class="list-group-item">$ <% = item.Precio %></li>
                    <li class="list-group-item"><% = item.Categoria %></li>
                    <li class="list-group-item"><% = item.Marca %></li>
                  </ul>
                  <div class="card-body">
                     <a href="DetalleProducto.aspx?id=<% = item.ID %>" class="btn btn-primary">Ver Detalle</a>
                     <a href="Carrito.aspx?id=<% = item.ID %>&e=t"><i class="bi bi-cart-plus"></i></a>
                </div>
            </div>


        <% } %>
             </div>
        </div>
</asp:Content>
