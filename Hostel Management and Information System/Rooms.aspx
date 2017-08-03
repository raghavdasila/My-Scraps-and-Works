<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Rooms.aspx.cs" Inherits="Default4" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div class="well">
    <p style="font-size: x-large; text-align:center">
        Manage Rooms</p>

    <asp:Table ID="Rooms" class="table" runat="server" Height="38px" Width="65px" HorizontalAlign="Center" CellSpacing="1">
        <asp:TableHeaderRow>
            <asp:TableHeaderCell>ID</asp:TableHeaderCell>
            <asp:TableHeaderCell>Hostel</asp:TableHeaderCell>
            <asp:TableHeaderCell>Room</asp:TableHeaderCell>
            <asp:TableHeaderCell>Status</asp:TableHeaderCell>
            <asp:TableHeaderCell>Manage</asp:TableHeaderCell>
        </asp:TableHeaderRow>
        <asp:TableRow>
            <asp:TableCell></asp:TableCell>
            <asp:TableCell></asp:TableCell>
            <asp:TableCell></asp:TableCell>
            <asp:TableCell></asp:TableCell>
            <asp:TableCell></asp:TableCell>
        </asp:TableRow>
    </asp:Table>
        </div>
</asp:Content>

