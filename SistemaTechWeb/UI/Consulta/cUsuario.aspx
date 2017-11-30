<%@ Page Title="" Language="C#" MasterPageFile="~/Base.Master" AutoEventWireup="true" CodeBehind="cUsuario.aspx.cs" Inherits="SistemaTechWeb.UI.Consulta.cUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--DropDowmList y TextBox-->
    <div class="row">
        <div class="col-12 col-sm-5">
            <asp:DropDownList ID="FiltrarDropDownList" runat="server" CssClass="form-control ">
                <asp:ListItem>Todo</asp:ListItem>
                <asp:ListItem>ID</asp:ListItem>
                <asp:ListItem>Nombres</asp:ListItem>
                <asp:ListItem>Nombre de Usuario</asp:ListItem>
                <asp:ListItem>Fecha Ingreso</asp:ListItem>
                <asp:ListItem>Cargo Usuario</asp:ListItem>
            </asp:DropDownList>
        </div>
        <div class="col-12 col-sm-7">
            <asp:TextBox ID="FiltroTextBox" runat="server" CssClass="form-control" autoComplete="off"></asp:TextBox>
        </div>
    </div>
    <!--TextBox Fecha-->
    <div class="row">
        <div class="form-group col-12 col-sm-6">
            <asp:Label ID="DesdeLabel" runat="server" Text="Desde:" CssClass=""></asp:Label>
            <asp:TextBox type="date" CssClass="form-control" ID="FechaDesdeTextBox" runat="server"></asp:TextBox>
        </div>
        <div class="form-group col-12 col-sm-6">
            <asp:Label ID="HastaLabel" runat="server" Text="Hasta:"></asp:Label>
            <asp:TextBox type="date" CssClass="form-control" ID="FechaHastaTextBox" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="float-right">
        <asp:Button ID="FiltroButton" runat="server" CssClass="btn btn-secondary" Text="Filtrar" OnClick="FiltroButton_Click" />
    </div>
    <div class="container">
        <div class="col-12">
            <asp:GridView CssClass="table table-responsive table-hover" BorderStyle="None" ID="UsuariosConsultaGridView" runat="server"
                AutoGenerateColumns="False" GridLines="Horizontal" DataKeyNames="UsuarioId,Nombres" ShowFooter="true">
                <HeaderStyle CssClass="bg-secondary" />
                <Columns>
                    <asp:BoundField DataField="UsuarioId" HeaderText="Usuario Id" />
                    <asp:BoundField DataField="Nombres" HeaderText="Nombres" />
                    <asp:BoundField DataField="NombreUsuario" HeaderText="Nombre Usuario" />
                    <asp:BoundField DataField="FechaIngreso" DataFormatString="{0:d}" HeaderText="Fecha Ingreso" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <!--<asp:Button ID="SeleccionButton" runat="server" CommandName="Select" CssClass="btn btn-secondary" Text="Eliminar"/>-->
                            <asp:Button ID="EnviarAlModalEliminarButton" CommandName="Select" CssClass="btn btn-secondary" runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="EnviarAlModalModificarButton" CommandName="Select" CssClass="btn btn-secondary" runat="server"
                                Text="Modificar" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <FooterStyle CssClass="bg-secondary" />
            </asp:GridView>
            </div>
        </div>
</asp:Content>
