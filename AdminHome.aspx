<%@ Page Title="" Language="C#" MasterPageFile="~/AdminSite.master" AutoEventWireup="true" CodeFile="AdminHome.aspx.cs" Inherits="AdminHome" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div class="jumbotron">
         <h1><strong>Admin Home Page</strong></h1>
    </div>
    <div class="row">
        <div class="col-md-4">

            <asp:Image ID="Image1" runat="server" Height="100px" ImageAlign="Middle" ImageUrl="~/Images/adduser.png" Width="100px" />
            <p>
                Add New Costumer and Staff Account.
            </p>
           <p>
                <a class="btn btn-default" href="AddUser.aspx">Add User &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <asp:Image ID="Image2" runat="server" Height="100px" ImageUrl="~/Images/3db286cc805e66e763fba9b5370856e9.png" Width="100px" />
            <p>
                Edit and Delete Costumer and Staff Accounts.
            </p>
          <p>
                <a class="btn btn-default" href="EditUser.aspx">Manage User &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <asp:Image ID="Image4" runat="server" Height="100px" ImageUrl="~/Images/addProdcut.png" Width="100px" />
            <p>
                Add new product and assigne it to an specific company.
            </p>
           <p>
                <a class="btn btn-default" href="AddProdcut.aspx">Add Product &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <asp:Image ID="Image5" runat="server" Height="100px" ImageUrl="~/Images/532b66cc087b04f33e0000d1_icon-edit-2.png" Width="100px" />
            <p>
                Edit prodcuts details or delete them.
            </p>
           <p>
                <a class="btn btn-default" href="Products_A.aspx">Edit Prodcuts &raquo;</a>
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

