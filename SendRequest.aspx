<%@ Page Title="" Language="C#" MasterPageFile="~/ClientSite.master" AutoEventWireup="true" CodeFile="SendRequest.aspx.cs" Inherits="SendRequest" %>

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
            <br />
            <asp:Label ID="Label2" runat="server" Text="Label" style="font-weight: 700; color: #003366"></asp:Label>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Label" style="font-weight: 700; color: #003366"></asp:Label>
            </div>

            <br />
            <br />
            <div class="form-group">
              <asp:Label runat="server" AssociatedControlID="RadioButton1" CssClass="col-md-2 control-label">User type</asp:Label>
            <div class="col-md-5">
                <asp:RadioButton ID="RadioButton1" runat="server" Text="Request" AutoPostBack="True" Checked="True" GroupName="a" OnCheckedChanged="RadioButton1_CheckedChanged" />
                &nbsp;&nbsp;
                <asp:RadioButton ID="RadioButton2" runat="server" Text="Feedback" AutoPostBack="True" GroupName="a" OnCheckedChanged="RadioButton2_CheckedChanged" />
            </div>
                <br />
        </div>
            <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="TEXT" CssClass="col-md-2 control-label">Text</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="TEXT" CssClass="form-control" TextMode="MultiLine" Width="330px" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="TEXT"
                    CssClass="text-danger" ErrorMessage="The text field is required." />
            </div>
        </div>
                    <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button ID="Register" runat="server" OnClick="CreateUser_Click" Text="Submit" CssClass="btn btn-default" />
            </div>
        </div>

        </div>

    </div>
</asp:Content>

