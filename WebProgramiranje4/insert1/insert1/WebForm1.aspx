<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="insert1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 395px">
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CS2 %>" DeleteCommand="DELETE FROM [prosek] WHERE [rb] = @rb" InsertCommand="INSERT INTO [prosek] ([rb], [prezime], [prosek]) VALUES (@rb, @prezime, @prosek)" SelectCommand="SELECT * FROM [prosek]" UpdateCommand="UPDATE [prosek] SET [prezime] = @prezime, [prosek] = @prosek WHERE [rb] = @rb">
                <DeleteParameters>
                    <asp:Parameter Name="rb" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="rb" Type="Int32" />
                    <asp:Parameter Name="prezime" Type="String" />
                    <asp:Parameter Name="prosek" Type="Single" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="prezime" Type="String" />
                    <asp:Parameter Name="prosek" Type="Single" />
                    <asp:Parameter Name="rb" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>
            <asp:TextBox ID="tbprosek" runat="server" style="z-index: 1; left: 673px; top: 182px; position: absolute; margin-bottom: 0px"></asp:TextBox>
            <asp:TextBox ID="tbime" runat="server" style="z-index: 1; left: 675px; top: 140px; position: absolute"></asp:TextBox>
            <asp:Button ID="btinsert" runat="server" OnClick="btinsert_Click" style="z-index: 1; left: 583px; top: 289px; position: absolute; height: 41px; width: 95px" Text="Insert" />
            <asp:Label ID="Label7" runat="server" style="z-index: 1; left: 532px; top: 141px; position: absolute; height: 20px; width: 136px" Text="Unesite ime i prezime:"></asp:Label>
            <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 532px; top: 180px; position: absolute; height: 20px; width: 136px" Text="Unesite prosek:"></asp:Label>
            <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 532px; top: 102px; position: absolute; height: 20px; width: 135px" Text="Unesite rb:"></asp:Label>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="rb" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" style="z-index: 1; left: 40px; top: 75px; position: absolute; height: 200px; width: 347px">
                <AlternatingRowStyle BackColor="White" />
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
                    <asp:TemplateField HeaderText="prezime" SortExpression="prezime">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("prezime") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label2" runat="server" Text='<%# Bind("prezime") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="prosek" SortExpression="prosek">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("prosek") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label3" runat="server" Text='<%# Bind("prosek") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>
            <asp:TextBox ID="tbrb" runat="server" style="z-index: 1; left: 675px; top: 100px; position: absolute"></asp:TextBox>
        </div>
    </form>
</body>
</html>
