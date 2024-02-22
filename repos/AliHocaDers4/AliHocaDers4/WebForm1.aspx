<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="AliHocaDers4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Ali Hoca Ders 4</title>
</head>
<body>
    
        background-color: #66CCCC;
    <form id="form1" runat="server">
        <div>
            <h4>BURASI DEFAULT</h4>
            <asp:HyperLink ID="HyperLink1" runat="server">HyperLink</asp:HyperLink>
        </div>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Ad"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 69px" Width="183px"></asp:TextBox>
        </p>
        <asp:Label ID="Label2" runat="server" Text="Soyad"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" style="margin-left: 46px" Width="177px"></asp:TextBox>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Ekle" />
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        </p>
        <asp:Calendar ID="Calendar1" runat="server" style="margin-left: 2px" BackColor="White" BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399" Height="400px" ShowGridLines="True" VisibleDate="2022-11-16" Width="420px">
            <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
            <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
            <OtherMonthDayStyle ForeColor="#999999" />
            <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
            <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
            <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
            <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
            <WeekendDayStyle BackColor="#CCCCFF" />
        </asp:Calendar>
        <p>
            <asp:Label ID="Label4" runat="server" Text="Doğum Tarihinizi Seçiniz"></asp:Label>
        </p>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Yaş Hesapla" Width="193px" />
        <p>
            <asp:Label ID="Label5" runat="server" Text="Yaşınız :"></asp:Label>
            <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
        </p>
        <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True">
            <asp:ListItem Value="1">Pazartesi</asp:ListItem>
            <asp:ListItem Value="2">Salı</asp:ListItem>
            <asp:ListItem Value="3">Çarşamba</asp:ListItem>
            <asp:ListItem Value="4">Perşembe</asp:ListItem>
            <asp:ListItem Value="5">Cuma</asp:ListItem>
            <asp:ListItem Value="6">Cumartesi</asp:ListItem>
            <asp:ListItem Value="7">Pazar</asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Seç =&gt;" />
        <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
        <p>
            <asp:Label ID="Label8" runat="server" Text="Haftanın Kaçıncı Gününü Yazdırmak İstediğinizi Giriniz :"></asp:Label>
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Yazdır" />
        </p>
        <asp:TextBox ID="TextBox3" runat="server" Height="49px" style="margin-top: 0px; margin-bottom: 31px"></asp:TextBox>
        <asp:Label ID="Label9" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
