<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="AliVize0.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 475px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem Value="0">İbo</asp:ListItem>
            <asp:ListItem Value="1">Uğur</asp:ListItem>
            <asp:ListItem Value="2">Eto</asp:ListItem>
            <asp:ListItem Value="3">Mıstaa</asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Panel ID="Panel1" runat="server" Height="294px">
            <asp:Panel ID="Panel2" runat="server" Height="122px">
            </asp:Panel>
        </asp:Panel>
    </form>
</body>
</html>
