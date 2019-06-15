<%@ Page Title="" Language="C#" MasterPageFile="~/AdminSite.master" AutoEventWireup="true" CodeFile="EditUser.aspx.cs" Inherits="EditUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <h2>Edit New User</h2>
    <p class="text-danger">
        <asp:Literal runat="server" ID="ErrorMessage" />
    </p>

    <div class="form-horizontal">
        <h4>&nbsp;</h4>
        <hr />
        <asp:ValidationSummary runat="server" CssClass="text-danger" />
                 <div class="form-group">
              <asp:Label runat="server" AssociatedControlID="ConfirmPassword" CssClass="col-md-2 control-label">User type</asp:Label>
            <div class="col-md-5">
                <asp:RadioButton ID="RadioButton1" runat="server" Text="Staff" AutoPostBack="True" Checked="True" GroupName="a" OnCheckedChanged="RadioButton1_CheckedChanged" />
                &nbsp;&nbsp;
                <asp:RadioButton ID="RadioButton2" runat="server" Text="Costumer" AutoPostBack="True" GroupName="a" OnCheckedChanged="RadioButton2_CheckedChanged" />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="UserName" CssClass="col-md-2 control-label">User name</asp:Label>
            <div class="col-md-10">
                <asp:DropDownList ID="UserName" runat="server" CssClass="form-control" AutoPostBack="True" OnSelectedIndexChanged="UserName_SelectedIndexChanged"></asp:DropDownList>
                 <br />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Password" CssClass="col-md-2 control-label">Password</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Password" TextMode="Password" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Password"
                    CssClass="text-danger" ErrorMessage="The password field is required." />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="ConfirmPassword" CssClass="col-md-2 control-label">Confirm password</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="ConfirmPassword" TextMode="Password" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="ConfirmPassword"
                    CssClass="text-danger" Display="Dynamic" ErrorMessage="The confirm password field is required." />
                <asp:CompareValidator runat="server" ControlToCompare="Password" ControlToValidate="ConfirmPassword"
                    CssClass="text-danger" Display="Dynamic" ErrorMessage="The password and confirmation password do not match." />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="TextBox2" CssClass="col-md-2 control-label">Email</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="TextBox2" CssClass="form-control" />
                 <asp:RequiredFieldValidator runat="server" ControlToValidate="UserName"
                    CssClass="text-danger" ErrorMessage="The email field is required." />
                
            </div>
        </div>
        <asp:Panel ID="Panel1" runat="server">
             <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Name1" CssClass="col-md-2 control-label">Company Name</asp:Label>
            <div class="col-md-10">
                <asp:Label ID="Name1" runat="server" Text="Label"></asp:Label>
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Address" CssClass="col-md-2 control-label">Address</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Address" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Address"
                    CssClass="text-danger" ErrorMessage="The address field is required." />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="phno" CssClass="col-md-2 control-label">Phone Number</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="phno" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="phno"
                    CssClass="text-danger" ErrorMessage="The phone number field is required." />
            </div>
        </div>
         <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="site" CssClass="col-md-2 control-label">Website</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="site" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="site"
                    CssClass="text-danger" ErrorMessage="The Website field is required." />
            </div>
        </div>
        <div class="form-group">
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <asp:Image ID="Image1" runat="server" Width="50" Height="50" />
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="FileUpload1" CssClass="col-md-2 control-label">Logo</asp:Label>
            <div>
               
            <asp:FileUpload ID="FileUpload1" runat="server" CssClass="form-control" accept=".png,.jpg,.jpeg"/>
                  </div>
            
        </div>

        </asp:Panel>

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button ID="Update" runat="server" OnClick="CreateUser_Click" Text="Update" CssClass="btn btn-default" />
                <asp:Button ID="Delete" runat="server"  Text="Delete" CssClass="btn btn-default" OnClick="Delete_Click" />
            </div>
        </div>
    </div>
</asp:Content>

