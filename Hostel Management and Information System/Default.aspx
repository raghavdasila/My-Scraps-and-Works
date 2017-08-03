<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <div class="well" style="text-align: center; font-size: x-large">
        &nbsp;<asp:Image ID="Image1" runat="server" Height="114px" ImageUrl="~/Content/Srmseal.png" Width="118px" />
        <br />
        SRM University Hostel Allocation & Management<br />
        <br />&nbsp;
        <p>
            <asp:Table class="table" runat="server" HorizontalAlign="Center" >
                <asp:TableRow><asp:TableCell>
                    Admin Login &nbsp
            <asp:Table class="table" Width="400" runat="server" HorizontalAlign="Center">
                <asp:TableRow>
                    <asp:TableCell>User ID</asp:TableCell>
                    <asp:TableCell><asp:TextBox class="form-control" ID="login" runat="server"></asp:TextBox></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>Password</asp:TableCell>
                    <asp:TableCell><asp:TextBox class="form-control" TextMode="Password" runat="server" ID="pass"></asp:TextBox></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell><asp:Label ID="Stat" runat="server" Font-Size="Medium">Enter Credentials</asp:Label></asp:TableCell>
                    <asp:TableCell></asp:TableCell>
                </asp:TableRow>
            </asp:Table>
               
            <asp:Button class="btn btn-primary" ID="auth" runat="server" Text="Login" OnClick="Authenticate"/>
                  </asp:TableCell>
                      <asp:TableCell>
                          Member Login&nbsp
                        <asp:Table class="table" Width="400" runat="server" HorizontalAlign="Center">
                <asp:TableRow>
                    <asp:TableCell>User ID</asp:TableCell>
                    <asp:TableCell><asp:TextBox class="form-control" ID="login2" runat="server"></asp:TextBox></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>Password</asp:TableCell>
                    <asp:TableCell><asp:TextBox class="form-control" TextMode="Password" runat="server" ID="pass2"></asp:TextBox></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell><asp:Label ID="Stat2" runat="server" Font-Size="Medium">Enter Credentials</asp:Label></asp:TableCell>
                    <asp:TableCell></asp:TableCell>
                </asp:TableRow>
            </asp:Table>
            <asp:Button class="btn btn-primary" ID="auth2" runat="server" Text="Login" OnClick="Authenticate"/>
                    </asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
        </p>
       </div>
</asp:Content>
