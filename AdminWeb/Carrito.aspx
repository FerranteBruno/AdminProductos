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
                            <asp:Button ID="Button1" runat="server" Text="1" type="button" onClick="Button1_Click" class="btn btn-secondary" CommandArgument='<%#Eval("ID")%>'/>
                              <asp:Button ID="Button2" runat="server" Text="2" type="button" class="btn btn-secondary" onClick="Button2_Click" CommandArgument='<%#Eval("ID")%>'/>
                              <asp:Button ID="Button3" runat="server" Text="3" type="button" class="btn btn-secondary" onClick="Button3_Click" CommandArgument='<%#Eval("ID")%>'/>
                              <asp:Button ID="Button4" runat="server" Text="4" type="button" class="btn btn-secondary" onClick="Button4_Click" CommandArgument='<%#Eval("ID")%>'/>
                          </div>
                        </div>
                        
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
