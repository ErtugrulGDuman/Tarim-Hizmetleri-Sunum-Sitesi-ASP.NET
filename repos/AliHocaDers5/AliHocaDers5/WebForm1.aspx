<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="AliHocaDers5.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>
    </title>
</head>
<body>
    <form id="form1" runat="server" style="border: medium ridge #800000; background-color: #008080">
        <div>
        </div>
        <asp:ListBox ID="ListBox1" runat="server" Width="186px" ForeColor="#000066" Height="530px" CssClass="ListBox"></asp:ListBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Rastgele 10 sayı" Width="131px" OnClick="Button1_Click" ForeColor="Red" />
        <br />
        <asp:Button ID="Button2" runat="server" Text="Toplamı" Width="130px" OnClick="Button2_Click" ForeColor="Red" />
        <br />
        <p>
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
