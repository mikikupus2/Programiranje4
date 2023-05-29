<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Foto_galerija.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 626px;
            width: 901px;
        }
        .auto-style2 {
            position: absolute;
            top: 38px;
            left: 55px;
            z-index: 1;
            width: 227px;
        }
        .auto-style3 {
            position: absolute;
            top: 74px;
            left: 24px;
            z-index: 1;
            width: 178px;
        }
        .auto-style4 {
            position: absolute;
            top: 115px;
            z-index: 1;
            width: 179px;
            left: 23px;
        }
        .auto-style5 {
            position: absolute;
            top: 159px;
            left: 24px;
            z-index: 1;
            width: 177px;
        }
        </style>
</head>
<body style="height: 787px">
    <form id="form1" runat="server">
        <div class="auto-style1">
            <asp:Label ID="Label1" runat="server" CssClass="auto-style2" ForeColor="#3366FF" Text="FOTO GALERIJA"></asp:Label>
            <asp:Button ID="Button1" runat="server" BackColor="#99CCFF" CssClass="auto-style3" ForeColor="Blue" Text="POCETNA" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" BackColor="#99CCFF" CssClass="auto-style4" ForeColor="Blue" Text="O AUTORU" OnClick="Button2_Click" />
            <asp:Button ID="Button3" runat="server" BackColor="#99CCFF" CssClass="auto-style5" ForeColor="Blue" Text="UPUTSTVO" />
        </div>
    </form>
</body>
</html>
