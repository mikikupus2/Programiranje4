<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="forma1.aspx.cs" Inherits="baze1.forma1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BANKACS %>" DeleteCommand="DELETE FROM [BANKA] WHERE [BANKA_ID] = ?" InsertCommand="INSERT INTO [BANKA] ([BANKA_ID], [NAZIV], [SEDIŠTE], [BRZAPOSLENIH]) VALUES (?, ?, ?, ?)" ProviderName="<%$ ConnectionStrings:BANKACS.ProviderName %>" SelectCommand="SELECT [BANKA_ID], [NAZIV], [SEDIŠTE], [BRZAPOSLENIH] FROM [BANKA]" UpdateCommand="UPDATE [BANKA] SET [NAZIV] = ?, [SEDIŠTE] = ?, [BRZAPOSLENIH] = ? WHERE [BANKA_ID] = ?">
            <DeleteParameters>
                <asp:Parameter Name="BANKA_ID" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="BANKA_ID" Type="Int32" />
                <asp:Parameter Name="NAZIV" Type="String" />
                <asp:Parameter Name="SEDIŠTE" Type="String" />
                <asp:Parameter Name="BRZAPOSLENIH" Type="Int32" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="NAZIV" Type="String" />
                <asp:Parameter Name="SEDIŠTE" Type="String" />
                <asp:Parameter Name="BRZAPOSLENIH" Type="Int32" />
                <asp:Parameter Name="BANKA_ID" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <div style="height: 488px">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" DataKeyNames="BANKA_ID" DataSourceID="SqlDataSource1" Height="251px" Width="579px" ShowFooter="True" AllowSorting="True">
                <Columns>
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                    <asp:TemplateField HeaderText="BANKA_ID" InsertVisible="False" SortExpression="BANKA_ID">
                        <EditItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("BANKA_ID") %>'></asp:Label>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text='<%# Bind("BANKA_ID") %>'></asp:Label>
                        </ItemTemplate>
                        <FooterTemplate>
                            <asp:Button ID="Button1" runat="server" OnClick="Radi" Text="Insert" />
                        </FooterTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="NAZIV" SortExpression="NAZIV">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("NAZIV") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label2" runat="server" Text='<%# Bind("NAZIV") %>'></asp:Label>
                        </ItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="txtNaziv" runat="server"></asp:TextBox>
                        </FooterTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="SEDIŠTE" SortExpression="SEDIŠTE">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("SEDIŠTE") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label3" runat="server" Text='<%# Bind("SEDIŠTE") %>'></asp:Label>
                        </ItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="txtSediste" runat="server"></asp:TextBox>
                        </FooterTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="BRZAPOSLENIH" SortExpression="BRZAPOSLENIH">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("BRZAPOSLENIH") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label4" runat="server" Text='<%# Bind("BRZAPOSLENIH") %>'></asp:Label>
                        </ItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="txtZaposleni" runat="server"></asp:TextBox>
                        </FooterTemplate>
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
        </div>
    </form>
</body>
</html>
