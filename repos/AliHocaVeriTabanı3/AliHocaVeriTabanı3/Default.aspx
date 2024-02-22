﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AliHocaVeriTabanı3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>



        </div>
        <asp:TextBox ID="Adi" runat="server" BackColor="#FFCC99" BorderColor="Black" BorderStyle="Solid" TabIndex="1"></asp:TextBox>
        <asp:TextBox ID="Soyadi" runat="server" BackColor="#FFCC99" BorderColor="Black" BorderStyle="Solid"></asp:TextBox>
        <asp:TextBox ID="Bolumu" runat="server" BackColor="#FFCC99" BorderColor="Black" BorderStyle="Solid"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="İşlem Yap" BackColor="#99CCFF" BorderColor="Black" BorderStyle="Solid" OnClick="Button1_Click" />
        <p>
            &nbsp;</p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" AutoGenerateDeleteButton="True" AutoGenerateEditButton="True" AutoGenerateSelectButton="True" DataKeyNames="id" DataSourceID="SqlDataSource1" Width="427px">
            <Columns>
                <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                <asp:BoundField DataField="OgrenciAd" HeaderText="OgrenciAd" SortExpression="OgrenciAd" />
                <asp:BoundField DataField="OgrenciSoyad" HeaderText="OgrenciSoyad" SortExpression="OgrenciSoyad" />
                <asp:BoundField DataField="Bolumu" HeaderText="Bolumu" SortExpression="Bolumu" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BeysehirYBSConnectionString %>" SelectCommand="SELECT * FROM [Tbl_Ogrenciler]"></asp:SqlDataSource>
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource2">
            <Columns>
                <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                <asp:BoundField DataField="OgrenciAd" HeaderText="OgrenciAd" SortExpression="OgrenciAd" />
                <asp:BoundField DataField="OgrenciSoyad" HeaderText="OgrenciSoyad" SortExpression="OgrenciSoyad" />
                <asp:BoundField DataField="Bolumu" HeaderText="Bolumu" SortExpression="Bolumu" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:BeysehirYBSConnectionString2 %>" SelectCommand="SELECT * FROM [Tbl_Ogrenciler]"></asp:SqlDataSource>
    </form>
</body>
</html>
