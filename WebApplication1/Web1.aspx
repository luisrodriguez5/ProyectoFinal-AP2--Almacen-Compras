<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Web1.aspx.cs" Inherits="WebApplication1.Web1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="CategoriaId"></asp:Label>
          <asp:TextBox ID="CategoriaId" runat="server"></asp:TextBox>
    </div>
        <div>
            <asp:Label ID="Label2" runat="server" Text="Descripcion"></asp:Label>
            <asp:TextBox ID="Descripcion" runat="server"></asp:TextBox>


        </div>
      
    </form>
</body>
</html>
