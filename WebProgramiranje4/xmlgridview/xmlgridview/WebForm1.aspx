<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="xmlgridview.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 394px;
        }
        .auto-style2 {
            width: 254px;
            height: 165px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <table class="auto-style2">
                <tr>
                    <td><asp:Label ID="Label1" runat="server" Text="ISBN:"></asp:Label></td>
                    <td><asp:TextBox ID="tbisbn" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label2" runat="server" Text="Naslov:"></asp:Label></td>
                    <td><asp:TextBox ID="tbnaslov" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label3" runat="server" Text="Stanje:"></asp:Label></td>
                    <td><asp:TextBox ID="tbstanje" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label4" runat="server" Text="Citano:"></asp:Label></td>
                    <td><asp:TextBox ID="tbcitano" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Button ID="btdodaj" runat="server" Text="Dodaj" Width="114px" OnClick="btdodaj_Click" /></td>
                    <td><asp:Button ID="btkraj" runat="server" Text="Kraj" Width="130px" OnClick="btkraj_Click" /></td>
                </tr>
            </table>
            <asp:GridView ID="gvknjige" runat="server" OnSorted="gvknjige_Sorted" OnSorting="gvknjige_Sorting">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
