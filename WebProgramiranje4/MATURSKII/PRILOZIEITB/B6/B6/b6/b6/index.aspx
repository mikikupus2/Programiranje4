<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="b6.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 440px;
            height: 157px;
            position: absolute;
            top: 156px;
            left: 170px;
            z-index: 1;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <header>
            <asp:Button ID="Button1" runat="server" Text="Pocetna" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="Grafik" OnClick="Button2_Click" />
            <asp:Button ID="Button3" runat="server" Text="O autoru" />
            <asp:Button ID="Button4" runat="server" Text="Upustvo" />
        </header>
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" CssClass="auto-style1" DataKeyNames="ID" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="razred" HeaderText="razred" SortExpression="razred" />
                    <asp:BoundField DataField="odlican" HeaderText="odlican" SortExpression="odlican" />
                    <asp:BoundField DataField="dovoljan" HeaderText="dovoljan" SortExpression="dovoljan" />
                    <asp:BoundField DataField="dobar" HeaderText="dobar" SortExpression="dobar" />
                    <asp:BoundField DataField="nedovoljan" HeaderText="nedovoljan" SortExpression="nedovoljan" />
                    <asp:BoundField DataField="prosek" HeaderText="prosek" SortExpression="prosek" />
                    <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
                    <asp:BoundField DataField="vrlodobar" HeaderText="vrlodobar" SortExpression="vrlodobar" />
                </Columns>
                <FooterStyle BackColor="White" ForeColor="#000066" />
                <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                <RowStyle ForeColor="#000066" />
                <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#007DBB" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#00547E" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT [razred], [odlican], [dovoljan], [dobar], [nedovoljan], [prosek], [ID], [vrlodobar] FROM [uspeh] ORDER BY [prosek] DESC"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
