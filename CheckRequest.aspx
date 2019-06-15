<%@ Page Title="" Language="C#" MasterPageFile="~/CoSite.master" AutoEventWireup="true" CodeFile="CheckRequest.aspx.cs" Inherits="ShowRequest" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">

    <div style="width:100%">
        <div style="width:70%; margin-left:15%;float:left">
            <h2>Check Requests</h2>
            <p>&nbsp;</p>
             <div class="form-group">
              <asp:Label runat="server" AssociatedControlID="RadioButton1" CssClass="col-md-2 control-label">Status</asp:Label>
            <div class="col-md-5">
                <asp:RadioButton ID="RadioButton1" runat="server" Text="Pending" AutoPostBack="True" Checked="True" GroupName="a"  />
                &nbsp;&nbsp;
                <asp:RadioButton ID="RadioButton2" runat="server" Text="All" AutoPostBack="True" GroupName="a"  />
            </div>
        </div>
            <br />
            <br />
            <br />
            <asp:Table ID="Table1" runat="server" Width="100%" Font-Bold="True" GridLines="Both" HorizontalAlign="Center"></asp:Table>
        </div>

    </div>
</asp:Content>

