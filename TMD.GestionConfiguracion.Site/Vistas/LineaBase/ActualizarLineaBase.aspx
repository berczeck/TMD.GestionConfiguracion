<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ActualizarLineaBase.aspx.cs" Inherits="TMD.GC.Site.Vistas.LineaBase.ActualizarLineaBase" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div id="actualizarLB" class="content">
    <h1 class="page-title">LINEA BASE</h1>
        <div class="panel-wrapper">
            <table style="width: 800px;">
                <tr>
                    <td>
                        <label>Proyecto</label>
                        <asp:TextBox ID="cod_proyecto" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <label>Fase</label>
                            <asp:DropDownList ID="DropDownList2" runat="server">
                            </asp:DropDownList> 
                    </td>
                </tr>
            </table>
        </div>
        <div id="form_lineabase" class="panel-wrapper form">
            <table style="width: 600px;">
                    <tr>
                        <td>
                            <label>Descripcion</label>
                            <asp:TextBox ID="desc_lb" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <label>Nombre</label>
                            <asp:TextBox ID="nombre_lb" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <label>Fecha Entrega</label>
                            <asp:TextBox ID="fecha_lb" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <label>Responsable</label>
                            <asp:DropDownList ID="cbo_responsable" runat="server">
                            </asp:DropDownList>
                        </td>
                    </tr>
                </table>
                <p align="right"><asp:Button ID="btnECS" runat="server" Text="Detalle" /></p>
                <asp:GridView ID="GridActualizarLB" runat="server" AutoGenerateColumns="False">
                    <Columns>
                        <asp:BoundField DataField="codigo" HeaderText="Codigo" />
                        <asp:BoundField DataField="nombre" HeaderText="Nombre ECS" />
                        <asp:TemplateField HeaderText="responsable">
                            <ItemTemplate>
                                <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
                            </ItemTemplate>
                        </asp:TemplateField>

                    </Columns>
                </asp:GridView>
        </div><!-- END #form_lineabase -->

        <div id="ECS-master" class="panel-wrapper" style="display: none;">

        </div>


    </div><!-- END #content -->



</asp:Content>
