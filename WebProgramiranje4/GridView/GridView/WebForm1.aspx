<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="GridView.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BANKA %>" ProviderName="<%$ ConnectionStrings:BANKA.ProviderName %>" SelectCommand="SELECT * FROM [BANKA]"></asp:SqlDataSource>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="BANKA_ID" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="BANKA_ID" HeaderText="BANKA_ID" InsertVisible="False" ReadOnly="True" SortExpression="BANKA_ID" />
                    <asp:BoundField DataField="NAZIV" HeaderText="NAZIV" SortExpression="NAZIV" />
                    <asp:BoundField DataField="SEDIŠTE" HeaderText="SEDIŠTE" SortExpression="SEDIŠTE" />
                    <asp:BoundField DataField="BRZAPOSLENIH" HeaderText="BRZAPOSLENIH" SortExpression="BRZAPOSLENIH" />
                </Columns>
            </asp:GridView>
            <asp:TextBox ID="tbnaziv" runat="server"></asp:TextBox>
            <asp:TextBox ID="tbsediste" runat="server"></asp:TextBox>
            <asp:TextBox ID="nedeljkovic" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Button" />
        </div>
    </form>
</body>
</html>
