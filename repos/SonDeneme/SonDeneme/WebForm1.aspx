<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="SonDeneme.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="DT" runat="server"></asp:TextBox>
            <asp:TextBox ID="YR" runat="server"></asp:TextBox>
            <asp:Button ID="Hesapla" runat="server" Text="Button" />
            <asp:Label ID="SonucGoster" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
