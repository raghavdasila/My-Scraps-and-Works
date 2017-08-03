<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Default3.aspx.cs" Inherits="Default3" %>

<asp:Content ID="Content5" ContentPlaceHolderID="MainContent" Runat="Server">
    <div class="well" style="text-align: center; font-size: x-large">
        &nbsp;
        <p>
            <asp:Table class="table" runat="server" HorizontalAlign="Center" Width="800" ID="AddUser">
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label runat="server">User Name</asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="Uname">

                        </asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label runat="server">Password</asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="P1">

                        </asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label runat="server">Confirm Password</asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="P2">

                        </asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ACCOUNTSConnectionString %>" SelectCommand="SELECT * FROM [Table]"></asp:SqlDataSource>
            <br />
            <asp:Button runat="server" OnClick="Unnamed_Click" ID="Confirm" Text="Confirm" />
            <br />
        <asp:GridView HorizontalAlign="Center" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="True" SortExpression="Id" />
                <asp:BoundField DataField="User" HeaderText="User" SortExpression="User" />
                <asp:BoundField DataField="Pass" HeaderText="Pass" SortExpression="Pass" />
            </Columns>
                    
              </asp:GridView>
            </p>
    </div>
</asp:Content>

