<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="AdminWeb.Carrito" %>

<asp:Content ID="CarrCont" ContentPlaceHolderID="MainContent" runat="server">

<table class="table">

       <asp:Repeater runat="server" ID="repetidor">
    
            <ItemTemplate>
                <tr>
                    <td><%#Eval("item.Nombre")%></td>
                    <td>
                        <asp:Label ID="lblSubTotal" runat="server" Text='<%#Eval("subtotal") %>'></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox TextMode="Number" ID="txtCantidad" runat="server" AutoPostBack="true" OnTextChanged="txtCantidad_TextChanged" Text="1" />
                    </td>
                    <td>
                    <asp:Button Text="Eliminar" CssClass="btn btn-primary" ID="btnEliminar2" onClick="btnEliminar2_Click" CommandArgument='<%#Eval("ID")%>' runat="server" />
                    </td>
                </tr>

            </ItemTemplate>
        </asp:Repeater>
  
    </table>




    <asp:Label ID="lblTotal" runat="server" Text="lale"></asp:Label>

</asp:Content>
