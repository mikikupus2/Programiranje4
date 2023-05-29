<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormaGrid.aspx.cs" Inherits="login1.FormaGrid" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 664px;
            height: 157px;
            position: absolute;
            top: 126px;
            left: 230px;
            z-index: 1;
        }
        .auto-style2 {
            width: 656px;
            height: 133px;
            position: absolute;
            top: 325px;
            left: 235px;
            z-index: 1;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CssClass="auto-style1" DataKeyNames="korime" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="korime" HeaderText="korime" ReadOnly="True" SortExpression="korime" />
                <asp:BoundField DataField="lozinka" HeaderText="lozinka" SortExpression="lozinka" />
                <asp:BoundField DataField="uloga" HeaderText="uloga" SortExpression="uloga" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:zastita3grupaConnectionString2 %>" DeleteCommand="DELETE FROM [adminnalozi] WHERE [korime] = @korime" InsertCommand="INSERT INTO [adminnalozi] ([korime], [lozinka], [uloga]) VALUES (@korime, @lozinka, @uloga)" SelectCommand="SELECT * FROM [adminnalozi]" UpdateCommand="UPDATE [adminnalozi] SET [lozinka] = @lozinka, [uloga] = @uloga WHERE [korime] = @korime">
            <DeleteParameters>
                <asp:Parameter Name="korime" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="korime" Type="String" />
                <asp:Parameter Name="lozinka" Type="String" />
                <asp:Parameter Name="uloga" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="lozinka" Type="String" />
                <asp:Parameter Name="uloga" Type="String" />
                <asp:Parameter Name="korime" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" CssClass="auto-style2" DataKeyNames="korime" DataSourceID="SqlDataSource2">
            <Columns>
                <asp:BoundField DataField="korime" HeaderText="korime" ReadOnly="True" SortExpression="korime" />
                <asp:BoundField DataField="lozinka" HeaderText="lozinka" SortExpression="lozinka" />
                <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
                <asp:BoundField DataField="pitanje" HeaderText="pitanje" SortExpression="pitanje" />
                <asp:BoundField DataField="odgovor" HeaderText="odgovor" SortExpression="odgovor" />
                <asp:BoundField DataField="uloga" HeaderText="uloga" SortExpression="uloga" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:KorisniciConnection %>" DeleteCommand="DELETE FROM [korisnici] WHERE [korime] = @korime" InsertCommand="INSERT INTO [korisnici] ([korime], [lozinka], [email], [pitanje], [odgovor], [uloga]) VALUES (@korime, @lozinka, @email, @pitanje, @odgovor, @uloga)" SelectCommand="SELECT * FROM [korisnici]" UpdateCommand="UPDATE [korisnici] SET [lozinka] = @lozinka, [email] = @email, [pitanje] = @pitanje, [odgovor] = @odgovor, [uloga] = @uloga WHERE [korime] = @korime">
            <DeleteParameters>
                <asp:Parameter Name="korime" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="korime" Type="String" />
                <asp:Parameter Name="lozinka" Type="String" />
                <asp:Parameter Name="email" Type="String" />
                <asp:Parameter Name="pitanje" Type="String" />
                <asp:Parameter Name="odgovor" Type="String" />
                <asp:Parameter Name="uloga" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="lozinka" Type="String" />
                <asp:Parameter Name="email" Type="String" />
                <asp:Parameter Name="pitanje" Type="String" />
                <asp:Parameter Name="odgovor" Type="String" />
                <asp:Parameter Name="uloga" Type="String" />
                <asp:Parameter Name="korime" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </form>
</body>
</html>
