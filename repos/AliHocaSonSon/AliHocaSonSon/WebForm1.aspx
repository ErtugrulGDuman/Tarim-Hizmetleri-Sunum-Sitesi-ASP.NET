<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="AliHocaSonSon.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:TextBox ID="TextBox1" runat="server" Width="231px"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" Width="232px"></asp:TextBox>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="İşlem Yap" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Güncelle" />
        </p>
    </form>
</body>
</html>
