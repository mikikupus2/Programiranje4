<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Maturski3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 33px;
            left: 300px;
            z-index: 1;
        }
        .auto-style2 {
            position: absolute;
            top: 101px;
            left: 242px;
            z-index: 1;
        }
        .auto-style3 {
            position: absolute;
            top: 97px;
            left: 419px;
            z-index: 1;
        }
        .auto-style4 {
            position: absolute;
            top: 103px;
            left: 590px;
            z-index: 1;
        }
        .auto-style5 {
            width: 930px;
            height: 60px;
            position: absolute;
            top: 85px;
            left: 9px;
            z-index: 1;
            margin-top: 0px;
        }
        .auto-style6 {
            width: 600px;
            height: 162px;
            position: absolute;
            top: 185px;
            left: 158px;
            z-index: 1;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" CssClass="auto-style1" Text="OSNOVNA SKOLA &quot;SONJA MARINKOVIC&quot;"></asp:Label>
        <asp:Button ID="Button1" runat="server" BackColor="#99FF33" CssClass="auto-style2" Text="Pocetna" />
        <asp:Button ID="Button2" runat="server" CssClass="auto-style3" Text="O autoru" />
        <asp:Button ID="Button3" runat="server" CssClass="auto-style4" Text="Uputstvo" />
        <div class="auto-style5">
        </div>
        <asp:Table ID="Table1" runat="server" CssClass="auto-style6">
            <asp:TableRow runat="server">
            </asp:TableRow>
            <asp:TableRow runat="server">
            </asp:TableRow>
            <asp:TableRow runat="server">
            </asp:TableRow>
        </asp:Table>
    </form>
</body>
</html>
