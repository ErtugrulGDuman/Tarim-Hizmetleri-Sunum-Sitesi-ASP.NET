<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="AliHocaDers2i.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br /><br />
        </div>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button runat="server" Text="Hesapla" Width="448px" OnClick="Unnamed1_Click" />
            </p>
        <p>
            <asp:Label ID="Sonuc" runat="server" Text="Sonuc"></asp:Label>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>
        <asp:Calendar ID="Calendar1" runat="server" Height="264px" OnSelectionChanged="Calendar1_SelectionChanged" Width="447px"></asp:Calendar>
    </form>
</body>
</html>
