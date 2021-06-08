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
                        <%// <asp:TextBox TextMode="Number" ID="txtCantidad" runat="server" AutoPostBack="true" OnTextChanged="txtCantidad_TextChanged" Text="1" />%>
                        <div class="btn-toolbar justify-content-between" role="toolbar" aria-label="Toolbar with button groups">
                          <div class="btn-group" role="group" aria-label="First group">
                            <asp:Button ID="btnInc" runat="server" Text="+" type="button" AutoPostBack="true" onClick="btnInc_Click" class="btn btn-secondary" CommandArgument='<%#Eval("ID")%>'/>
                              <asp:Button ID="btnCant" runat="server" Text='<%#Eval("cantidad") %>' type="text" class="btn btn-secondary" AutoPostBack="true" CommandArgument='<%#Eval("ID")%>'/>
                              <asp:Button ID="btnDec" runat="server" Text="-" type="button" class="btn btn-secondary" AutoPostBack="true" onClick="btnDec_Click" CommandArgument='<%#Eval("ID")%>'/>
                          </div>
                        </div>
                        
                    </td>
                    <td>
                    <asp:Button Text="Eliminar" CssClass="btn btn-primary" ID="btnEliminar2" onClick="btnEliminar2_Click" CommandArgument='<%#Eval("ID")%>' runat="server" AutoPostBack="true"/>
                    </td>
                </tr>

            </ItemTemplate>
        </asp:Repeater>
  
    </table>




    <asp:Label ID="lblTotal" runat="server" Text="lale" AutoPostBack="true"></asp:Label>

</asp:Content>
