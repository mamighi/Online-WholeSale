<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/ClientSite.Master" AutoEventWireup="true" CodeFile="Default_C.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


   
    <div style="width:100%;">
        <div style="width:70%; margin-left:15%;">
            <div id="slider">
            <img src="Images/slide.jpg" alt="" />
        </div>
          
            <h2>Companies</h2>
   

             <asp:Table ID="Table1" runat="server" Width="450px" CellPadding="5" GridLines="Both" HorizontalAlign="Center"></asp:Table>
    

        </div>


    </div>

    </asp:Content>
