<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Report.aspx.cs" Inherits="Default6" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <p style="text-align: center">Report</p><div style="text-align: center" class="well" >
    <asp:TextBox ID="Rep" AutoPostBack="true" runat="server" TextMode="MultiLine" Height="450" Width="350" ReadOnly="True" Wrap="false"></asp:TextBox>
        <br />
        <asp:Button runat="server" class="btn btn-primary" ID="cnfrm" Text="Confirm" OnClick="confirm"/>
        </div>
</asp:Content>