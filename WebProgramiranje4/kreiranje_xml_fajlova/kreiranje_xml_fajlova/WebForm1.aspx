<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="kreiranje_xml_fajlova.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 343px;
            height: 219px;
        }
        .auto-style2 {
            position: absolute;
            top: 257px;
            left: 19px;
            z-index: 1;
            height: 155px;
            width: 320px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:TextBox ID="TbNiz" runat="server" CssClass="auto-style2" TextMode="MultiLine"></asp:TextBox>
        <table class="auto-style1" border="1">
            <tr>
                <td colspan="2">
                    <h3>Unos podataka o ucenicima</h3>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Unesite ID ucenika"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="Tbid" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Unesite prezime:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="Tbprezime" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Unesite ime:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="Tbime" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Unesite prosek:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="Tbprosek" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Btunos" runat="server" Text="Unesite podatke" OnClick="Btunos_Click" />
                </td>
                <td>
                    <asp:Button ID="Btkraj" runat="server" Text="Kraj unosa" OnClick="Btkraj_Click" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
