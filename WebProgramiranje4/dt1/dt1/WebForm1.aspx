<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="dt1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 561px">
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 205px; top: 459px; position: absolute; width: 203px; height: 63px" Text="Prikazi tabelu" />
            <asp:Button ID="Button2" runat="server" Height="62px" OnClick="Button2_Click" style="z-index: 1; left: 421px; top: 459px; position: absolute" Text="Kreiraj XML" Width="206px" />
        </div>
    </form>
</body>
</html>
