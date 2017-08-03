<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="About.aspx.cs" Inherits="About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Allocate and manage rooms.</h3>
    <p>Login with your credentials and choose one of the provided options<br />
        You can add new students to the database via Admissions<br />
        You can view and manage room related data via Manage Rooms<br />
        You can view and manage student related data via Manage Students<br />
        You can change your credential password via Change Passwords
    </p>
</asp:Content>
