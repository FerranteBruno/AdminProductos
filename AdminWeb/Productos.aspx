<%@ Page Title="Productos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="AdminWeb.Productos" %>

<asp:Content ID="ProdContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    
    <asp:GridView ID="dgvProductos" runat="server"></asp:GridView>

</asp:Content>
