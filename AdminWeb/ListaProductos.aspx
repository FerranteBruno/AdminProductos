<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaProductos.aspx.cs" Inherits="AdminWeb.ListaProductos" %>

<asp:Content ID="ListaCont1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container" style="display:block;">

        <div class="input-group input-group-sm mb-1" style="padding-top: 2rem; padding-bottom: 2rem; max-width:100%; margin-left:30%;margin-right:30% ">
                  <div class="input-group-prepend">
                    <asp:TextBox ID="Buscador" class="form-control" runat="server" OnTextChanged="Buscador_OnTextChanged" ></asp:TextBox>
                    <span class="input-group-text" id="inputGroup-sizing-default">Buscador</span>
                  </div>
                </div> 
        <div class="row">
            
        <% foreach (dominio.Producto item in list)
            
            {%>
            

            <div class="card" style="width: 18rem;">
              <img src="<% = item.UrlImagen %>" class="card-img-top" alt="texto de imagen" onerror="this.src='img/earth-globe1.png';" >
                  <div class="card-body">
                    <h5 class="card-title"><% = item.Nombre %></h5>
                  </div>
                  <ul class="list-group list-group-flush">
                    <li class="list-group-item"><% = item.Precio.ToString("c",nfi) %></li>
                  </ul>
                  <div class="card-body">
                     <a href="DetalleProducto.aspx?id=<% = item.ID %>" class="btn btn-primary">Ver Detalle</a>
                     <a href="Carrito.aspx?id=<% = item.ID %>"><i class="fas fa-cart-plus" style="transform: scale(1.5); padding-left: 4vh"></i></a>
                </div>
            </div>


        <% } %>
                </div>
             </div>
</asp:Content>
