<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Students.aspx.cs" Inherits="Default5" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="server">
    <div class="well">
    <p style="font-size: x-large;text-align:center">
        Manage Students</p>

        <asp:GridView ID="GridView1" class="table" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="True" SortExpression="Id" />
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                <asp:BoundField DataField="Gender" HeaderText="Gender" SortExpression="Gender" />
                <asp:BoundField DataField="Hostel" HeaderText="Hostel" SortExpression="Hostel" />
                <asp:BoundField DataField="DOB" HeaderText="DOB" SortExpression="DOB" />
                <asp:BoundField DataField="Blood" HeaderText="Blood" SortExpression="Blood" />
                <asp:BoundField DataField="Dept" HeaderText="Dept" SortExpression="Dept" />
                <asp:BoundField DataField="F_Name" HeaderText="F_Name" SortExpression="F_Name" />
                <asp:BoundField DataField="F_No" HeaderText="F_No" SortExpression="F_No" />
                <asp:BoundField DataField="House" HeaderText="House" SortExpression="House" />
                <asp:BoundField DataField="Street" HeaderText="Street" SortExpression="Street" />
                <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
                <asp:BoundField DataField="State" HeaderText="State" SortExpression="State" />
                <asp:BoundField DataField="e-mail" HeaderText="e-mail" SortExpression="e-mail" />
                <asp:BoundField DataField="DD" HeaderText="DD" SortExpression="DD" />
                <asp:BoundField DataField="Amt" HeaderText="Amt" SortExpression="Amt" />
                <asp:BoundField DataField="DD_Date" HeaderText="DD_Date" SortExpression="DD_Date" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:STUDENTSConnectionString %>" SelectCommand="SELECT * FROM [Table]"></asp:SqlDataSource>

    <asp:Table ID="Student" class="table" Visible="false" runat="server" HorizontalAlign="Center" CellSpacing="5">
        <asp:TableHeaderRow>
            <asp:TableHeaderCell>ID</asp:TableHeaderCell>
            <asp:TableHeaderCell>Name</asp:TableHeaderCell>
            <asp:TableHeaderCell>Room</asp:TableHeaderCell>
            <asp:TableHeaderCell>Address</asp:TableHeaderCell>
            <asp:TableHeaderCell>Father</asp:TableHeaderCell>
            <asp:TableHeaderCell>Father Contact</asp:TableHeaderCell>
            <asp:TableHeaderCell>Pay Details</asp:TableHeaderCell>
            <asp:TableHeaderCell>e-mail</asp:TableHeaderCell>
            <asp:TableHeaderCell>Blood Group</asp:TableHeaderCell>
            <asp:TableHeaderCell>Manage</asp:TableHeaderCell>
        </asp:TableHeaderRow>
        <asp:TableRow>
            <asp:TableCell></asp:TableCell>
            <asp:TableCell></asp:TableCell>
            <asp:TableCell></asp:TableCell>
            <asp:TableCell></asp:TableCell>
            <asp:TableCell></asp:TableCell>
            <asp:TableCell></asp:TableCell>
            <asp:TableCell></asp:TableCell>
            <asp:TableCell></asp:TableCell>
            <asp:TableCell></asp:TableCell>
            <asp:TableCell></asp:TableCell>
        </asp:TableRow>
    </asp:Table>
        </div>
</asp:Content>

