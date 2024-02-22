<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AliHocaSonDers.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
        </div>
        <asp:ListBox ID="ListBox1" runat="server" BackColor="#660066" ForeColor="#FF6699" Height="199px" Width="497px"></asp:ListBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Sayı Üret" OnClick="Button1_Click1" />
        <asp:Button ID="Button2" runat="server" Text="Topla" OnClick="Button2_Click" />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
