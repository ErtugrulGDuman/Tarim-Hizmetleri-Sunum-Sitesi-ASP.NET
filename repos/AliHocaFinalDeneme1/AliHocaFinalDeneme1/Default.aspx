<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AliHocaFinalDeneme1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="AD : "></asp:Label>
        <asp:TextBox ID="TxtAd" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label2" runat="server" Text="SOYAD : "></asp:Label>
            <asp:TextBox ID="TxtSoyad" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="Label3" runat="server" Text="OKUL : "></asp:Label>
        <asp:TextBox ID="TxtOkul" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label4" runat="server" Text="BÖLÜM : "></asp:Label>
            <asp:TextBox ID="TxtBolum" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="Label5" runat="server" Text="YAŞ : "></asp:Label>
        <asp:TextBox ID="TxtYas" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label6" runat="server" Text="TEL NO : "></asp:Label>
            <asp:TextBox ID="TxtTelNo" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="BtnEkle" runat="server" OnClick="Button1_Click" Text="EKLE" Width="152px" />
        <p>
            <asp:Label ID="Label7" runat="server" Text="Kaydını Silmek İstediğiniz Kişinin ID'si : "></asp:Label>
            <asp:TextBox ID="TxtID" runat="server"></asp:TextBox>
            <asp:Button ID="BtnSil" runat="server" OnClick="Button1_Click1" Text="SİL" Width="93px" />
        </p>
        <p>
            <asp:Label ID="Label8" runat="server" Text="Kaydını Güncellemek İstediğiniz Kişinin ID'si : "></asp:Label>
            <asp:TextBox ID="TxtID1" runat="server"></asp:TextBox>
            <asp:Button ID="BtnGuncelle" runat="server" OnClick="BtnGuncelle_Click" Text="Güncelle" />
        </p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
                <asp:BoundField DataField="AD" HeaderText="AD" SortExpression="AD" />
                <asp:BoundField DataField="SOYAD" HeaderText="SOYAD" SortExpression="SOYAD" />
                <asp:BoundField DataField="OKUL" HeaderText="OKUL" SortExpression="OKUL" />
                <asp:BoundField DataField="BOLUM" HeaderText="BOLUM" SortExpression="BOLUM" />
                <asp:BoundField DataField="YAS" HeaderText="YAS" SortExpression="YAS" />
                <asp:BoundField DataField="TELNO" HeaderText="TELNO" SortExpression="TELNO" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Listele %>" SelectCommand="SELECT * FROM [Tbl_OgrBilgi]"></asp:SqlDataSource>
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
        <asp:DataList ID="DataList1" runat="server" DataKeyField="ID" DataSourceID="SqlDataSource2">
            <ItemTemplate>
                ID:
                <asp:Label ID="IDLabel" runat="server" Text='<%# Eval("ID") %>' />
                <br />
                AD:
                <asp:Label ID="ADLabel" runat="server" Text='<%# Eval("AD") %>' />
                <br />
                SOYAD:
                <asp:Label ID="SOYADLabel" runat="server" Text='<%# Eval("SOYAD") %>' />
                <br />
                OKUL:
                <asp:Label ID="OKULLabel" runat="server" Text='<%# Eval("OKUL") %>' />
                <br />
                BOLUM:
                <asp:Label ID="BOLUMLabel" runat="server" Text='<%# Eval("BOLUM") %>' />
                <br />
                YAS:
                <asp:Label ID="YASLabel" runat="server" Text='<%# Eval("YAS") %>' />
                <br />
                TELNO:
                <asp:Label ID="TELNOLabel" runat="server" Text='<%# Eval("TELNO") %>' />
                <br />
<br />
            </ItemTemplate>
        </asp:DataList>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:DataList %>" SelectCommand="SELECT * FROM [Tbl_OgrBilgi]"></asp:SqlDataSource>
    </form>
</body>
</html>
