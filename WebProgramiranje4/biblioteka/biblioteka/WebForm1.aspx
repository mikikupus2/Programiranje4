<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="biblioteka.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 955px;
            height: 281px;
            position: absolute;
            top: 15px;
            left: 10px;
            z-index: 1;
        }
        .auto-style2 {
            width: 945px;
            height: 205px;
            position: absolute;
            top: 312px;
            left: 13px;
            z-index: 1;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table border="1" class="auto-style1">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Unesite ISBN knjige:  "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="Tbisbn" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Unesite naslov knjige:  "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="Tbnaslov" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Unesite stanje knjige:  "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="Tbstanje" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Unesite citano:  "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="Tbcitano" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Btdodaj" runat="server" Text="Dodaj podatak" OnClick="Btdodaj_Click" />
                </td>
                <td>
                    <asp:Button ID="Btkraj" runat="server" Text="Kraj unosa" OnClick="Btkraj_Click" />
                    <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" CssClass="auto-style2" ForeColor="#333333" GridLines="None" OnSorting="GridView1_Sorting">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                        <Columns>
                            <asp:BoundField DataField="isbn" HeaderText="ISBN" />
                            <asp:BoundField DataField="naslov" HeaderText="Naslov" />
                            <asp:BoundField DataField="stanje" HeaderText="stanje" />
                            <asp:BoundField />
                            <asp:BoundField DataField="citano" HeaderText="Citano" SortExpression="citano" />
                        </Columns>
                        <EditRowStyle BackColor="#999999" />
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#E9E7E2" />
                        <SortedAscendingHeaderStyle BackColor="#506C8C" />
                        <SortedDescendingCellStyle BackColor="#FFFDF8" />
                        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                    </asp:GridView>
&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Btprikazi" runat="server" Text="Prikazi XML" OnClick="Btprikazi_Click" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
