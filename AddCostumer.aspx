<%@ Page Title="" Language="C#" MasterPageFile="~/AdminSite.master" AutoEventWireup="true" CodeFile="AddCostumer.aspx.cs" Inherits="AddCostumer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
      <h2>Add New User</h2>
    <p class="text-danger">
        <asp:Literal runat="server" ID="ErrorMessage" />
    </p>

    <div class="form-horizontal">
        <h4>&nbsp;</h4>
        <hr />
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="UserName" CssClass="col-md-2 control-label">Company Name</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="UserName" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="UserName"
                    CssClass="text-danger" ErrorMessage="The company name field is required." />
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
            <asp:Label runat="server" AssociatedControlID="FileUpload1" CssClass="col-md-2 control-label">Logo</asp:Label>
            <div>
            <asp:FileUpload ID="FileUpload1" runat="server" CssClass="form-control" accept=".png,.jpg,.jpeg,.gif"/>
              <asp:RequiredFieldValidator runat="server" ControlToValidate="FileUpload1"
                    CssClass="text-danger" ErrorMessage="The company logo is required." />
                  </div>
            
        </div>

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button ID="Register" runat="server" OnClick="CreateUser_Click" Text="Register" CssClass="btn btn-default" />
            </div>
        </div>
    </div>
</asp:Content>

