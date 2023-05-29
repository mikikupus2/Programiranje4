<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="b6uspehucenika.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SkolaCS %>" DeleteCommand="DELETE FROM [Uspeh] WHERE [Razred] = @Razred" InsertCommand="INSERT INTO [Uspeh] ([Razred], [Odlican], [Vrlodobar], [Dobar], [Dovoljan], [Nedovoljan], [ProsOcena]) VALUES (@Razred, @Odlican, @Vrlodobar, @Dobar, @Dovoljan, @Nedovoljan, @ProsOcena)" SelectCommand="SELECT * FROM [Uspeh]" UpdateCommand="UPDATE [Uspeh] SET [Odlican] = @Odlican, [Vrlodobar] = @Vrlodobar, [Dobar] = @Dobar, [Dovoljan] = @Dovoljan, [Nedovoljan] = @Nedovoljan, [ProsOcena] = @ProsOcena WHERE [Razred] = @Razred">
            <DeleteParameters>
                <asp:Parameter Name="Razred" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Razred" Type="Int32" />
                <asp:Parameter Name="Odlican" Type="Int32" />
                <asp:Parameter Name="Vrlodobar" Type="Int32" />
                <asp:Parameter Name="Dobar" Type="Int32" />
                <asp:Parameter Name="Dovoljan" Type="Int32" />
                <asp:Parameter Name="Nedovoljan" Type="Int32" />
                <asp:Parameter Name="ProsOcena" Type="Decimal" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Odlican" Type="Int32" />
                <asp:Parameter Name="Vrlodobar" Type="Int32" />
                <asp:Parameter Name="Dobar" Type="Int32" />
                <asp:Parameter Name="Dovoljan" Type="Int32" />
                <asp:Parameter Name="Nedovoljan" Type="Int32" />
                <asp:Parameter Name="ProsOcena" Type="Decimal" />
                <asp:Parameter Name="Razred" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="Razred" DataSourceID="SqlDataSource1" OnSorted="GridView1_Sorted" OnSorting="GridView1_Sorting">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                <asp:BoundField DataField="Razred" HeaderText="Razred" ReadOnly="True" SortExpression="Razred" />
                <asp:BoundField DataField="Odlican" HeaderText="Odlican" SortExpression="Odlican" />
                <asp:BoundField DataField="Vrlodobar" HeaderText="Vrlodobar" SortExpression="Vrlodobar" />
                <asp:BoundField DataField="Dobar" HeaderText="Dobar" SortExpression="Dobar" />
                <asp:BoundField DataField="Dovoljan" HeaderText="Dovoljan" SortExpression="Dovoljan" />
                <asp:BoundField DataField="Nedovoljan" HeaderText="Nedovoljan" SortExpression="Nedovoljan" />
                <asp:BoundField DataField="ProsOcena" HeaderText="ProsOcena" SortExpression="ProsOcena" />
            </Columns>
            <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
            <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
            <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
            <RowStyle BackColor="White" ForeColor="#003399" />
            <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
            <SortedAscendingCellStyle BackColor="#EDF6F6" />
            <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
            <SortedDescendingCellStyle BackColor="#D6DFDF" />
            <SortedDescendingHeaderStyle BackColor="#002876" />
        </asp:GridView>
        <asp:Label ID="SortInformationLabel" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="Red"></asp:Label>
        <p>
            <asp:Label ID="Message" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="Red"></asp:Label>
        </p>
    </form>
</body>
</html>
