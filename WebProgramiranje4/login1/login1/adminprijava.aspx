<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adminprijava.aspx.cs" Inherits="login1.adminprijava" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 18px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Prijava korisnika<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:korisnicics %>" DeleteCommand="DELETE FROM [korisnici] WHERE [korime] = @korime" InsertCommand="INSERT INTO [korisnici] ([korime], [lozinka], [email], [pitanje], [odgovor], [uloga]) VALUES (@korime, @lozinka, @email, @pitanje, @odgovor, @uloga)" SelectCommand="SELECT * FROM [korisnici]" UpdateCommand="UPDATE [korisnici] SET [lozinka] = @lozinka, [email] = @email, [pitanje] = @pitanje, [odgovor] = @odgovor, [uloga] = @uloga WHERE [korime] = @korime">
                <DeleteParameters>
                    <asp:Parameter Name="korime" Type="String" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="korime" Type="String" />
                    <asp:Parameter Name="lozinka" Type="String" />
                    <asp:Parameter Name="email" Type="String" />
                    <asp:Parameter Name="pitanje" Type="String" />
                    <asp:Parameter Name="odgovor" Type="String" />
                    <asp:Parameter Name="uloga" Type="String" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="lozinka" Type="String" />
                    <asp:Parameter Name="email" Type="String" />
                    <asp:Parameter Name="pitanje" Type="String" />
                    <asp:Parameter Name="odgovor" Type="String" />
                    <asp:Parameter Name="uloga" Type="String" />
                    <asp:Parameter Name="korime" Type="String" />
                </UpdateParameters>
            </asp:SqlDataSource>
            </h1>
            <asp:Login ID="Login1" runat="server" BackColor="#F7F7DE" BorderColor="#CCCC99" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="10pt" OnAuthenticate="Login1_Authenticate" CreateUserText="Kreiraj nalog" CreateUserUrl="~/kreiranjenaloga.aspx">
                <LayoutTemplate>
                    <table cellpadding="1" cellspacing="0" style="border-collapse: collapse;">
                        <tr>
                            <td>
                                <table cellpadding="0">
                                    <tr>
                                        <td align="center" colspan="2" style="color:White;background-color:#6B696B;font-weight:bold;">Log In</td>
                                    </tr>
                                    <tr>
                                        <td align="right">
                                            <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">User Name:</asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="UserName" runat="server"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName" ErrorMessage="User Name is required." ToolTip="User Name is required." ValidationGroup="Login1">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="right">
                                            <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password">Password:</asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password" ErrorMessage="Password is required." ToolTip="Password is required." ValidationGroup="Login1">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="2">
                                            <asp:CheckBox ID="RememberMe" runat="server" Text="Remember me next time." />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="center" colspan="2" style="color:Red;">
                                            <asp:Literal ID="FailureText" runat="server" EnableViewState="False"></asp:Literal>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="right" colspan="2">&nbsp;<asp:Button ID="LoginButton" runat="server" CommandName="Login" Text="Log In" ValidationGroup="Login1" OnClick="LoginButton_Click" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="2">
                                            <asp:HyperLink ID="CreateUserLink" runat="server" NavigateUrl="~/kreiranjenaloga.aspx">Kreiraj nalog</asp:HyperLink>
                                            &nbsp; </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </LayoutTemplate>
                <TitleTextStyle BackColor="#6B696B" Font-Bold="True" ForeColor="#FFFFFF" />
            </asp:Login>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Korisnicko ime:" Visible="False"></asp:Label>
        <asp:TextBox ID="AdminKorime" runat="server" Visible="False" Width="156px"></asp:TextBox>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:zastita3grupaConnectionString %>" DeleteCommand="DELETE FROM [adminnalozi] WHERE [korime] = @korime" InsertCommand="INSERT INTO [adminnalozi] ([korime], [lozinka], [uloga]) VALUES (@korime, @lozinka, @uloga)" SelectCommand="SELECT * FROM [adminnalozi]" UpdateCommand="UPDATE [adminnalozi] SET [lozinka] = @lozinka, [uloga] = @uloga WHERE [korime] = @korime">
            <DeleteParameters>
                <asp:Parameter Name="korime" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="korime" Type="String" />
                <asp:Parameter Name="lozinka" Type="String" />
                <asp:Parameter Name="uloga" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="lozinka" Type="String" />
                <asp:Parameter Name="uloga" Type="String" />
                <asp:Parameter Name="korime" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <asp:ChangePassword ID="ChangePassword1" runat="server" BackColor="#F7F7DE" BorderColor="#CCCC99" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="10pt" Visible="False">
            <ChangePasswordTemplate>
                <table cellpadding="1" cellspacing="0" style="border-collapse:collapse;">
                    <tr>
                        <td>
                            <table cellpadding="0">
                                <tr>
                                    <td align="center" colspan="2" style="color:White;background-color:#6B696B;font-weight:bold;">Change Your Password</td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        <asp:Label ID="CurrentPasswordLabel" runat="server" AssociatedControlID="CurrentPassword">Password:</asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="CurrentPassword" runat="server" TextMode="Password"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="CurrentPasswordRequired" runat="server" ControlToValidate="CurrentPassword" ErrorMessage="Password is required." ToolTip="Password is required." ValidationGroup="ChangePassword1">*</asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        <asp:Label ID="NewPasswordLabel" runat="server" AssociatedControlID="NewPassword">New Password:</asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="NewPassword" runat="server" TextMode="Password"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="NewPasswordRequired" runat="server" ControlToValidate="NewPassword" ErrorMessage="New Password is required." ToolTip="New Password is required." ValidationGroup="ChangePassword1">*</asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        <asp:Label ID="ConfirmNewPasswordLabel" runat="server" AssociatedControlID="ConfirmNewPassword">Confirm New Password:</asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="ConfirmNewPassword" runat="server" TextMode="Password"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="ConfirmNewPasswordRequired" runat="server" ControlToValidate="ConfirmNewPassword" ErrorMessage="Confirm New Password is required." ToolTip="Confirm New Password is required." ValidationGroup="ChangePassword1">*</asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="center" colspan="2">
                                        <asp:CompareValidator ID="NewPasswordCompare" runat="server" ControlToCompare="NewPassword" ControlToValidate="ConfirmNewPassword" Display="Dynamic" ErrorMessage="The Confirm New Password must match the New Password entry." ValidationGroup="ChangePassword1"></asp:CompareValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="center" colspan="2" style="color:Red;" class="auto-style1">
                                        <asp:Literal ID="FailureText" runat="server" EnableViewState="False"></asp:Literal>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        <asp:Button ID="changepassword" runat="server" OnClick="changepassword_Click" Text="ChangePassword" />
                                    </td>
                                    <td>
                                        <asp:Button ID="CancelPushButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </ChangePasswordTemplate>
            <TitleTextStyle BackColor="#6B696B" Font-Bold="True" ForeColor="#FFFFFF" />
        </asp:ChangePassword>
    </form>
</body>
</html>
