<%@ Page Title="" Language="C#" MasterPageFile="~/ClientSite.master" AutoEventWireup="true" CodeFile="ShowRequest.aspx.cs" Inherits="ShowRequest" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">

    <div style="width:100%">
        <div style="width:70%; margin-left:15%;float:left">
            <h2>Sent Requests</h2>
            <p>&nbsp;</p>
            <asp:Table ID="Table1" runat="server" Width="100%" Font-Bold="True" GridLines="Both"></asp:Table>
        </div>

    </div>
</asp:Content>

