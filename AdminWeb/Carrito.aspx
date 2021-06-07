<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="AdminWeb.Carrito" %>

<asp:Content ID="CarrCont" ContentPlaceHolderID="MainContent" runat="server">

<table class="table">

       <asp:Repeater runat="server" ID="repetidor">
    
            <ItemTemplate>
                <tr>
                    <td><%#Eval("item.Nombre")%></td>
                    <td>
                        <%--<asp:Button ID="btnEliminar" CssClass="btn btn-primary" Text="Eliminar" CommandArgument='<%#Eval("Id")%>' CommandName="idPokemon" runat="server" OnClick="btnEliminar_Click" />--%>
                        <asp:Label ID="lblSubtotal" runat="server" Text="lelele"></asp:Label>
                        <asp:Button Text="Eliminar" CssClass="btn btn-primary" ID="btnEliminar2" onClick="btnEliminar2_Click" CommandArgument='<%#Eval("ID")%>' runat="server" />

                    </td>
                    <td>
                    <%//<asp:TextBox TextMode="Number" ID="txtCantidad" runat="server" AutoPostBack="true" OnTextChanged="txtCantidad_TextChanged" /> %>                     </td>
                </tr>

            </ItemTemplate>
        </asp:Repeater>
  
<hr class="mt-2 mb-3"/><% = carrito.total %>



    </table>


</asp:Content>
