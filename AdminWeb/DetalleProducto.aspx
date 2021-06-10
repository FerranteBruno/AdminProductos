<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DetalleProducto.aspx.cs" Inherits="AdminWeb.DetalleProducto" %>

<asp:Content ID="DetCont" ContentPlaceHolderID="MainContent" runat="server">

    <div style="margin: auto; text-align: center">



        <div class="card-body" style="margin: auto">
            <h5 class="card-title" style="font-size: 25px"><% = seleccionado.Nombre %></h5>
            <!--<p class="card-text"><small class="text-muted"><% = seleccionado.Precio.ToString("c",nfi) %></small></p>-->
        </div>
        <img src="<% = seleccionado.UrlImagen %>" class="card-img-bottom" alt="..." style="max-height: 50%; max-width: 50%; margin: auto;">

        <div style="text-align: center">
            <div style="text-align: left;display:block;margin-left:30%;margin-right:30%">
                <p class="card-text">Descripcion: <% = seleccionado.Descripcion %></p>
                <p class="card-text">Categoria: <% = seleccionado.Categoria %></p>
                <p class="card-text">Marca: <% = seleccionado.Marca %></p>
            </div>
        </div>

        <div class="input-group-append" style="text-align: center; display: block;margin-top:10px">
            <a href="Carrito.aspx?id=<% = seleccionado.ID %>">

                <button class="btn btn-outline-secondary" type="button" style="text-align: center">
                    Añadir al Carrito
                        <p class="card-text"><small class="text-muted"><% = seleccionado.Precio.ToString("c",nfi) %></small></p>
                </button>


            </a>
        </div>



    </div>


    <div class="container">
        <div class="row">
        </div>


    </div>


</asp:Content>
