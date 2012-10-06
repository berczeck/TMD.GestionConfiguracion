<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" 
AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="TMD.GC.Site.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h1 class="page-title">BIENVENIDOS A GESTION DE CONFIGURACION DE TMD</h1>
    <div id="menu-principal" class="panel-wrapper">
        <asp:Menu ID="NavigationMenu" runat="server" CssClass="menu" EnableViewState="false" IncludeStyleBlock="false" Orientation="Horizontal">
            <Items>
                <asp:MenuItem NavigateUrl="~/Vistas/LineaBase/ListaLineaBase.aspx" Text="Linea Base"/>
                <asp:MenuItem NavigateUrl="~/Account/Login.aspx" Text="Login"/>
                        
            </Items>
        </asp:Menu>
    </div>
</asp:Content>
