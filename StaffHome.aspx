<%@ Page Title="" Language="C#" MasterPageFile="~/StaffSite.master" AutoEventWireup="true" CodeFile="StaffHome.aspx.cs" Inherits="AdminHome" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div class="jumbotron">
         <h1><strong>Staff Home Page</strong></h1>
    </div>
    <div class="row">
        <div class="col-md-4">

            <asp:Image ID="Image1" runat="server" Height="100px" ImageAlign="Middle" ImageUrl="~/Images/adduser.png" Width="100px" />
            <p>
                Add New Costumer and Staff Account.
            </p>
           <p>
                <a class="btn btn-default" href="AddUser_S.aspx">Add User &raquo;</a>
            </p>
        </div>

        <div class="col-md-4">
            <asp:Image ID="Image4" runat="server" Height="100px" ImageUrl="~/Images/addProdcut.png" Width="100px" />
            <p>
                Add new product and assigne it to an specific company.
            </p>
           <p>
                <a class="btn btn-default" href="AddProdcut_S.aspx">Add Product &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <asp:Image ID="Image3" runat="server" Height="100px" ImageUrl="~/Images/logout_318-10026.jpg" Width="100px" />
            <p>
                Sign Out.
            </p>
           <p>
                <a class="btn btn-default" href="LogOut.aspx">Log Out &raquo;</a>
            </p>
        </div>
    </div>
</asp:Content>

