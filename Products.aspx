<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Products.aspx.cs" Inherits="Products" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div style="width:100%">
        <div style="width:70%; margin-left:15%; float:left">
            <h2>Product Gallery</h2>
            <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="DropDownList1" CssClass="col-md-2 control-label">Category</asp:Label>
            <div class="col-md-10">
                <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True" CausesValidation="True"></asp:DropDownList>
                <br />
            </div>
                <asp:Table ID="Table1" runat="server" Width="100%" CellPadding="5" GridLines="Both"></asp:Table>
        </div>

        </div>


    </div>
    

</asp:Content>

