<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Default2" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    
    <div class="well"><p style="font-size: x-large; text-align: center">
        Select an option</p>
    <p style="font-size: x-large; text-align: center">
        <asp:Button class="btn btn-primary" ID="Button5" runat="server" Text="Manage Users" OnClick="Button5_Click" Width="150px" />
    </p>
    <p style="font-size: x-large; text-align: center">
        <asp:Button class="btn btn-primary" ID="Button2" runat="server" Text="Admission" OnClick="Button2_Click" Width="150px" />
    </p>
    <p style="font-size: x-large; text-align: center">
        <asp:Button class="btn btn-primary" ID="Button1" runat="server" Text="Manage Rooms" OnClick="Button1_Click" width ="150px"/>
    </p>
    <p style="font-size: x-large; text-align: center">
        <asp:Button class="btn btn-primary" ID="Button3" runat="server" Text="Manage Students" Width="150px" OnClick="Button3_Click" />
    </p>
    <p style="font-size: x-large; text-align: center">
        <asp:Button class="btn btn-primary" ID="Button4" runat="server" Text="Change Password" Width="150px" OnClick="Button4_Click" />
    </p>
    </div>
    <p style="font-size:large;text-align:center">
    <asp:Label ID="stat" Visible="false" runat="server" Text=""/>
    </p>
        <asp:Table ID="chngpswrd" Visible="false" runat="server" HorizontalAlign="Center">
        <asp:TableRow><asp:TableCell>
        <asp:Table class="table" ID="passT" Width="450" runat="server" HorizontalAlign="Center">
                <asp:TableRow>
                    <asp:TableCell>Old Password</asp:TableCell>
                    <asp:TableCell><asp:TextBox class="form-control" TextMode="Password" ID="opass" runat="server"></asp:TextBox></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>New Password</asp:TableCell>
                    <asp:TableCell><asp:TextBox class="form-control" TextMode="Password" runat="server" ID="npass"></asp:TextBox></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>Confirm Password</asp:TableCell>
                    <asp:TableCell><asp:TextBox class="form-control" TextMode="Password" runat="server" ID="npass2"></asp:TextBox></asp:TableCell>
                </asp:TableRow>
            </asp:Table>
            <asp:Button class="btn btn-primary" ID="auth" runat="server" Text="Change Password" OnClick="auth_Click" />
           </asp:TableCell> </asp:TableRow>
    </asp:Table>
</asp:Content>