<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="AliHocaDers7.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:Label ID="Label1" runat="server" Text="İlk Sayıyı Giriniz :"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" Width="38px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="İkinci Sayıyı Giriniz :"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" Width="38px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="margin-left: 1px" Text="HESAPLA" Width="88px" />
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        </p>
        <asp:Literal ID="Literal1" runat="server"></asp:Literal>
    </form>
</body>
</html>
