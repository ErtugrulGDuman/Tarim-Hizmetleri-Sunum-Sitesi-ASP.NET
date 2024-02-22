<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="AliHocaWebS.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="Ad" runat="server"></asp:TextBox>
            <br />
            <asp:TextBox ID="Soyad" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Kaydet" runat="server" Text="Kaydet" OnClick="Kaydet_Click" />
            <br />
        </div>
    </form>
</body>
</html>
