<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DetalleProducto.aspx.cs" Inherits="AdminWeb.DetalleProducto" %>

<asp:Content ID="DetCont" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <div class="row">
            

            <div class="card-body">
                 <h5 class="card-title"><% = seleccionado.Nombre %></h5>
                 <p class="card-text"><% = seleccionado.Descripcion %></p>
                 <p class="card-text"><small class="text-muted"><% = seleccionado.Precio.ToString("c",nfi) %></small></p>
                 </div>
                 <img src="<% = seleccionado.UrlImagen %>" class="card-img-bottom" alt="...">
                </div>
             </div>

    <div class="container">
        <div class="row">

            <div class="input-group">
              <select class="custom-select" id="inputGroupSelect04" aria-label="Example select with button addon">
                <option value="1">Uno</option>
                <option value="2">Dos</option>
                <option value="3">Tres</option>
                <option value="4">Cuatro</option>
                <option value="5">Cinco</option>
                <option value="6">Seis</option>


              </select>
              <div class="input-group-append" style="margin-left:auto; margin-right:auto;">
                <a href="Carrito.aspx?id=<% = seleccionado.ID %>">
                    <button class="btn btn-outline-secondary" type="button">Añadir al Carrito <p class="card-text"><small class="text-muted"><% = seleccionado.Precio.ToString("c",nfi) %></small></p> </button>
                    
                  </a>
              </div>
            </div>


        </div>
    </div>


</asp:Content>