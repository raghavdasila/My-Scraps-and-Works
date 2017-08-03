<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Admission.aspx.cs" Inherits="Default3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
        <div class="well">
            <br />

            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:STUDENTSConnectionString %>" SelectCommand="SELECT * FROM [Table]"></asp:SqlDataSource>

        <asp:Table  class="table" ID="Table1" runat="server" Height="180px" Width="584px" Font-Names="Times New Roman" HorizontalAlign="Center" BorderStyle="None">
         
            <asp:TableRow runat="server">
                <asp:TableCell>
                   &nbsp&nbsp Gender :  
                </asp:TableCell>
                <asp:TableCell>
                    <asp:DropDownList AutoPostBack="true" class="form-control" width="150px" ID="Gender" runat="server"  OnTextChanged="Gender_SelectedIndexChanged" OnSelectedIndexChanged="Gender_SelectedIndexChanged">
            <asp:ListItem Value="0">Select</asp:ListItem>
            <asp:ListItem Value="M">MALE</asp:ListItem>
            <asp:ListItem Value="F">FEMALE</asp:ListItem>
                        </asp:DropDownList>                   
                </asp:TableCell>
                        </asp:TableRow>
     
            <asp:TableRow runat="server">
                <asp:TableCell>
                    &nbsp&nbsp Hostel :
                </asp:TableCell>
                <asp:TableCell>
                    <asp:DropDownList  class="form-control" Width="150px" ID ="Hostel" runat = "server" Visible="false">
                        <asp:ListItem Value="0">Select</asp:ListItem>
                        <asp:ListItem Enabled="false" Value="1">Siva Sakthi</asp:ListItem>
                        <asp:ListItem Enabled="false" Value="2">Chellamal</asp:ListItem>
                        <asp:ListItem Enabled="false" Value="3">Om Vinayaga</asp:ListItem>
                        <asp:ListItem Enabled="false" Value="4">BH1</asp:ListItem>
                        <asp:ListItem Enabled="false" Value="5">BH2</asp:ListItem>
                        <asp:ListItem Enabled="false" Value="6">BH3</asp:ListItem>
                   </asp:DropDownList>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server">
                    <asp:TableCell>
                   &nbsp&nbsp Name :
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="Name" class="form-control" runat="server" Font-Names="Times New Roman" Width="283px" AutoPostBack="true"></asp:TextBox>
                    <asp:RequiredFieldValidator ForeColor="Red" ErrorMessage="Required Field" SetFocusOnError="true" ControlToValidate="Name" runat="server" />
                        </asp:TableCell></asp:TableRow><asp:TableRow runat="server">
                <asp:TableCell>
                   &nbsp&nbsp Date of Birth: 
                </asp:TableCell><asp:TableCell>
                    <asp:TextBox class="form-contorl" Text="" Width="150px" ID="bday" runat="server" TextMode="Date" AutoPostBack="true"></asp:TextBox>
                    <asp:RequiredFieldValidator ForeColor="Red" ErrorMessage="Required Field" SetFocusOnError="true" ControlToValidate="bday" runat="server" />
                </asp:TableCell></asp:TableRow><asp:TableRow>
                <asp:TableCell>
                  &nbsp&nbsp  Blood Group:
                </asp:TableCell><asp:TableCell>
                    <asp:TextBox class="form-control" ID="BloodGroup" runat="server" Width="300px"></asp:TextBox>
                    <asp:RequiredFieldValidator ForeColor="Red" ErrorMessage="Required Field" SetFocusOnError="true" ControlToValidate="BloodGroup" runat="server" />
                </asp:TableCell></asp:TableRow><asp:TableRow>
                <asp:TableCell>
                   &nbsp&nbsp Department :
                </asp:TableCell><asp:TableCell>
                    <asp:TextBox class="form-control" ID="Dept" runat="server" Width="300px"></asp:TextBox>
                    <asp:RequiredFieldValidator ForeColor="Red" ErrorMessage="Required Field" SetFocusOnError="true" ControlToValidate="Dept" runat="server" />
                </asp:TableCell></asp:TableRow><asp:TableRow>
                <asp:TableCell>
                  &nbsp&nbsp  Father's Name :
                </asp:TableCell><asp:TableCell>
                    <asp:TextBox class="form-control" ID="Father" runat="server" Width="300px"></asp:TextBox>
                    <asp:RequiredFieldValidator ForeColor="Red" ErrorMessage="Required Field" SetFocusOnError="true" ControlToValidate="Father" runat="server" />
                </asp:TableCell></asp:TableRow><asp:TableRow>
                <asp:TableCell>
                  &nbsp&nbsp  Father's Phone Number :
                </asp:TableCell><asp:TableCell>
                    <asp:TextBox class="form-control" TextMode="Phone" ID="FathersPhoneNumber" runat="server" Width="300px"></asp:TextBox>
                    <asp:RequiredFieldValidator ForeColor="Red" ErrorMessage="Required Field" SetFocusOnError="true" ControlToValidate="FathersPhoneNumber" runat="server" />
                </asp:TableCell></asp:TableRow><asp:TableRow>
              <asp:TableCell>
                  &nbsp&nbsp  House/Plot No. : 
                </asp:TableCell><asp:TableCell>
                    <asp:TextBox class="form-control" ID="House" runat="server" Width="300px"></asp:TextBox>
                    <asp:RequiredFieldValidator ForeColor="Red" ErrorMessage="Required Field" SetFocusOnError="true" ControlToValidate="House" runat="server" />
                </asp:TableCell></asp:TableRow><asp:TableRow>
                <asp:TableCell>
                  &nbsp&nbsp  Street/Location :
                </asp:TableCell><asp:TableCell>
                    <asp:TextBox class="form-control" ID="Street" runat="server" Width="300px"></asp:TextBox>
                    <asp:RequiredFieldValidator ForeColor="Red" ErrorMessage="Required Field" SetFocusOnError="true" ControlToValidate="Street" runat="server" />
                </asp:TableCell></asp:TableRow><asp:TableRow>
                <asp:TableCell>
                  &nbsp&nbsp  City :
                </asp:TableCell><asp:TableCell>
                    <asp:TextBox class="form-control" ID="City" runat="server" Width="300px"></asp:TextBox>
                    <asp:RequiredFieldValidator ForeColor="Red" ErrorMessage="Required Field" SetFocusOnError="true" ControlToValidate="City" runat="server" />
                </asp:TableCell></asp:TableRow><asp:TableRow>
                <asp:TableCell>
                    &nbsp&nbsp State :
                </asp:TableCell><asp:TableCell>
                    <asp:TextBox class="form-control" ID="State" runat="server" Width="300px"></asp:TextBox>
                    <asp:RequiredFieldValidator ForeColor="Red" ErrorMessage="Required Field" SetFocusOnError="true" ControlToValidate="State" runat="server" />
                </asp:TableCell></asp:TableRow><asp:TableRow>
                <asp:TableCell>
                    &nbsp&nbsp E-mail ID :
                </asp:TableCell><asp:TableCell>
                    <asp:TextBox ID="email" TextMode="Email" runat="server" Width="300px"></asp:TextBox>
                    <asp:RequiredFieldValidator ForeColor="Red" ErrorMessage="Required Field" SetFocusOnError="true"  ControlToValidate="email" runat="server" />
                </asp:TableCell></asp:TableRow><asp:TableRow>
                <asp:TableCell>
                    Payment Details:
                </asp:TableCell><asp:TableCell>
                </asp:TableCell></asp:TableRow><asp:TableRow>
                <asp:TableCell>
                    &nbsp&nbsp DD no.:
                </asp:TableCell><asp:TableCell>
                    <asp:TextBox ID="DD"  runat="server" Width="300px"></asp:TextBox>
                    <asp:RequiredFieldValidator ForeColor="Red" ErrorMessage="Required Field" SetFocusOnError="true" ControlToValidate="DD" runat="server" />
                </asp:TableCell></asp:TableRow><asp:TableRow>
                <asp:TableCell>
                    &nbsp&nbsp Amount :
                </asp:TableCell><asp:TableCell>
                    <asp:TextBox ID="Amount"  runat="server" Width="300px"></asp:TextBox>
                    <asp:RequiredFieldValidator ForeColor="Red" ErrorMessage="Required Field" SetFocusOnError="true" ControlToValidate="Amount" runat="server" />
                </asp:TableCell></asp:TableRow><asp:TableRow>
                <asp:TableCell>
                    &nbsp&nbsp Date :
                </asp:TableCell><asp:TableCell>
                    <asp:TextBox ID="DDDay" runat="server" Width="150px" TextMode="Date"></asp:TextBox>
                </asp:TableCell></asp:TableRow></asp:Table><br />
</div>
    <div class="well well-sm" style="text-align: center">
        
    &nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="RESET" class="btn btn-primary" runat="server"  OnClick="RESET_Click" Text="Reset" />
&nbsp;&nbsp; <asp:Button ID="Submit" class="btn btn-primary" runat="server" Text="Submit" OnClick="Submit_Click" />

        <br />
    </div>
</asp:Content>