<%@ Page Title="" Language="C#" MasterPageFile="~/AdminSite.master" AutoEventWireup="true" CodeFile="EditProduct.aspx.cs" Inherits="SendRequest" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div style="width:100%">
        <div style="width:50%;margin-left:25%;float:left;justify-content:center;align-content:center">
            <br />
            <br />
            <asp:Table ID="Table1" runat="server" Width="100%">
                <asp:TableRow runat="server" HorizontalAlign="Center">
                    <asp:TableCell runat="server" HorizontalAlign="Center">
                        <asp:Image ID="Image1" runat="server" Height="250px" Width="250px" ImageAlign="Middle"  />
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
            <div class="form-group">
            <asp:Label ID="Label1" runat="server" Text="Label" style="font-weight: 700; color: #003366"></asp:Label>
          
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
                  </div>
            
        </div>

            <br />
            <br />
                    <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button ID="Register" runat="server" OnClick="CreateUser_Click" Text="Update" CssClass="btn btn-default" />
                <asp:Button ID="Button1" runat="server"  Text="Delete" CssClass="btn btn-default" OnClick="Button1_Click" />

            </div>
        </div>

        </div>

    </div>
</asp:Content>

