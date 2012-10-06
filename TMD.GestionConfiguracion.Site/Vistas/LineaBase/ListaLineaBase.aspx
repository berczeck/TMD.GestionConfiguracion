<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaLineaBase.aspx.cs" Inherits="TMD.GC.Site.Vistas.LineaBase.ListaLineaBase" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div id="listaLB" class="content">
        <h1 class="page-title">LISTA DE LINEAS BASE</h1>
        <div class="panel-wrapper">
                <table style="width: 800px;">
                    <tr>
                        <td>
                            <label>Proyecto</label>
                            <asp:DropDownList ID="ddlProyecto" runat="server">
                            </asp:DropDownList> 
                            <asp:Button ID="btnBuscar" runat="server" onclick="btnBuscar_Click" 
                                Text="Buscar" />
                        </td>
                        <td>
                            
                        </td>
                    </tr>
                </table>
        </div>
        <asp:GridView ID="grvLineaBase" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Codigo" />
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                <asp:BoundField DataField="Descripcion" HeaderText="Responsable" />
                <asp:TemplateField HeaderText="Fase">
                    <ItemTemplate>
                        <%# Eval("ProyectoFase.Fase.Nombre")%>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
