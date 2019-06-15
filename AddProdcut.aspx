<%@ Page Title="" Language="C#" MasterPageFile="~/AdminSite.master" AutoEventWireup="true" CodeFile="AddProdcut.aspx.cs" Inherits="AddProdcut" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
        <h2>Add New Product</h2>
    <p class="text-danger">
        <asp:Literal runat="server" ID="ErrorMessage" />
    </p>

    <div class="form-horizontal">
        <h4>&nbsp;</h4>
        <hr />
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="DropDownList1" CssClass="col-md-2 control-label">Company Name</asp:Label>
            <div class="col-md-10">
                <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control"></asp:DropDownList>
               
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Category" CssClass="col-md-2 control-label">Category</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Category" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Category"
                    CssClass="text-danger" ErrorMessage="The address field is required." />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Name" CssClass="col-md-2 control-label">Name</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Name" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Name"
                    CssClass="text-danger" ErrorMessage="The phone number field is required." />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="FileUpload1" CssClass="col-md-2 control-label">Picture</asp:Label>
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

