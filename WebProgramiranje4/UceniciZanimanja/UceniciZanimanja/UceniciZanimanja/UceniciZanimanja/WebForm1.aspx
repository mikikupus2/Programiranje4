<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="UceniciZanimanja.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            height: 483px;
            background-color: #CCFFFF;
        }
        .auto-style3 {
            width: 696px;
            height: 133px;
            position: absolute;
            top: 48px;
            left: 10px;
            z-index: 1;
        }
        .auto-style4 {
            position: absolute;
            top: 51px;
            left: 804px;
            z-index: 1;
            width: 48px;
        }
        .auto-style5 {
            position: absolute;
            top: 51px;
            left: 911px;
            z-index: 1;
        }
        .auto-style6 {
            position: absolute;
            top: 84px;
            left: 912px;
            z-index: 1;
        }
        .auto-style9 {
            position: absolute;
            top: 119px;
            left: 911px;
            z-index: 1;
            width: 102px;
        }
        .auto-style10 {
            position: absolute;
            top: 184px;
            left: 912px;
            z-index: 1;
        }
        .auto-style11 {
            position: absolute;
            top: 228px;
            left: 808px;
            z-index: 1;
            width: 114px;
        }
        .auto-style12 {
            position: absolute;
            top: 187px;
            left: 803px;
            z-index: 1;
        }
        .auto-style13 {
            position: absolute;
            top: 152px;
            left: 805px;
            z-index: 1;
        }
        .auto-style14 {
            position: absolute;
            top: 86px;
            left: 805px;
            z-index: 1;
        }
        .auto-style15 {
            position: absolute;
            left: 804px;
            z-index: 1;
            top: 120px;
            width: 87px;
        }
        .auto-style16 {
            position: absolute;
            top: 151px;
            left: 910px;
            z-index: 1;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style2">
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:UceniciConnectionString %>" DeleteCommand="DELETE FROM [Zanimanja] WHERE [rb] = @rb" InsertCommand="INSERT INTO [Zanimanja] ([rb], [prezziime], [pol], [razred], [zanimanje]) VALUES (@rb, @prezziime, @pol, @razred, @zanimanje)" SelectCommand="SELECT * FROM [Zanimanja]" UpdateCommand="UPDATE [Zanimanja] SET [prezziime] = @prezziime, [pol] = @pol, [razred] = @razred, [zanimanje] = @zanimanje WHERE [rb] = @rb">
                <DeleteParameters>
                    <asp:Parameter Name="rb" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="rb" Type="Int32" />
                    <asp:Parameter Name="prezziime" Type="String" />
                    <asp:Parameter Name="pol" Type="String" />
                    <asp:Parameter Name="razred" Type="Int16" />
                    <asp:Parameter Name="zanimanje" Type="String" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="prezziime" Type="String" />
                    <asp:Parameter Name="pol" Type="String" />
                    <asp:Parameter Name="razred" Type="Int16" />
                    <asp:Parameter Name="zanimanje" Type="String" />
                    <asp:Parameter Name="rb" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>
            <asp:TextBox ID="tbrazred" runat="server" CssClass="auto-style16"></asp:TextBox>
            <asp:Button ID="btinsert" runat="server" CssClass="auto-style11" OnClick="btinsert_Click" Text="Insert" />
            <asp:DropDownList ID="ddlzanimanje" runat="server" CssClass="auto-style10">
                <asp:ListItem>Elektrotehnicar IT</asp:ListItem>
                <asp:ListItem>Elektrotehnicar racunara</asp:ListItem>
            </asp:DropDownList>
            <asp:TextBox ID="tbpreziime" runat="server" CssClass="auto-style6"></asp:TextBox>
            <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" CssClass="auto-style3" DataKeyNames="rb" DataSourceID="SqlDataSource1" OnSorting="GridView1_Sorting">
                <Columns>
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                    <asp:TemplateField HeaderText="rb" SortExpression="rb">
                        <EditItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("rb") %>'></asp:Label>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text='<%# Bind("rb") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="prezziime" SortExpression="prezziime">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("prezziime") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label2" runat="server" Text='<%# Bind("prezziime") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="pol" SortExpression="pol">
                        <EditItemTemplate>
                            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="auto-style17" SelectedValue='<%# Bind("pol") %>' style="z-index: 1">
                                <asp:ListItem>Musko</asp:ListItem>
                                <asp:ListItem>Zensko</asp:ListItem>
                            </asp:DropDownList>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label3" runat="server" Text='<%# Bind("pol") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="razred" SortExpression="razred">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("razred") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label4" runat="server" Text='<%# Bind("razred") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="zanimanje" SortExpression="zanimanje">
                        <EditItemTemplate>
                            <asp:DropDownList ID="DropDownList2" runat="server" CssClass="auto-style17" SelectedValue='<%# Bind("zanimanje") %>' style="z-index: 1">
                                <asp:ListItem>Elektrotehnicar IT</asp:ListItem>
                                <asp:ListItem>Elektrotehnicar racunara</asp:ListItem>
                            </asp:DropDownList>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label5" runat="server" Text='<%# Bind("zanimanje") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#FFF1D4" />
                <SortedAscendingHeaderStyle BackColor="#B95C30" />
                <SortedDescendingCellStyle BackColor="#F1E5CE" />
                <SortedDescendingHeaderStyle BackColor="#93451F" />
            </asp:GridView>
            <asp:Label ID="Label6" runat="server" CssClass="auto-style4" Text="Rb"></asp:Label>
            <asp:TextBox ID="tbrb" runat="server" CssClass="auto-style5"></asp:TextBox>
            <asp:DropDownList ID="ddlpol" runat="server" CssClass="auto-style9">
                <asp:ListItem>Musko</asp:ListItem>
                <asp:ListItem>Zensko</asp:ListItem>
            </asp:DropDownList>
            <asp:Label ID="Label7" runat="server" CssClass="auto-style14" Text="Prezime i ime"></asp:Label>
            <asp:Label ID="Label8" runat="server" CssClass="auto-style15" Text="Pol:"></asp:Label>
            <asp:Label ID="Label9" runat="server" CssClass="auto-style13" Text="Razred:"></asp:Label>
            <asp:Label ID="Label10" runat="server" CssClass="auto-style12" Text="Zanimanje:"></asp:Label>
        </div>
    </form>
</body>
</html>
