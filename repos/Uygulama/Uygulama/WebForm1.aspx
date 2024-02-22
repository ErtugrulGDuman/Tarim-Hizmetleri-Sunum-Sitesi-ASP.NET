<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Uygulama.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Deneme Uygulaması</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>SELAM</h1>
            <h2>SELAM</h2>
            <h3>SELAM</h3>
            <h4><u>SELAM</u></h4>
            <h5><ins>SELAM</ins></h5>
            <h6>SELAM</h6>
            <p><b>html</b><br/>öğreniyorum</p>
            <code>int a = 5;<br />System.Out.Println("değer : " + a);</code>
            <a href="https://www.w3schools.com">This is a link</a>
        </div>
        <asp:Button ID="Button1" runat="server" Font-Bold="True" Font-Italic="True" ForeColor="#FF9999" OnClick="Button1_Click" Text="ekle" />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
