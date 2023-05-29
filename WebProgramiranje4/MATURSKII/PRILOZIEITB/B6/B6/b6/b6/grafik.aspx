<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="grafik.aspx.cs" Inherits="b6.WebForm1" %><%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 102px;
            left: 216px;
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
        </div>
        <asp:Chart ID="Chart1" runat="server" CssClass="auto-style1" DataSourceID="SqlDataSource1" Height="317px" Width="432px">
            <series>
                <asp:Series Name="Series1" XValueMember="razred" YValueMembers="prosek">
                </asp:Series>
            </series>
            <chartareas>
                <asp:ChartArea Name="ChartArea1">
                </asp:ChartArea>
            </chartareas>
        </asp:Chart>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString2 %>" ProviderName="<%$ ConnectionStrings:ConnectionString2.ProviderName %>" SelectCommand="SELECT * FROM [uspeh]"></asp:SqlDataSource>
    </form>
</body>
</html>
