<%@ Page Title="" Language="C#" MasterPageFile="~/CoSite.master" AutoEventWireup="true" CodeFile="Response.aspx.cs" Inherits="Response" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div style="width:100%">
        <div style="width:50%; margin-left:25%; float:left">
            <h2>Response</h2>
            <p>&nbsp;</p>
            <p>&nbsp;</p>
            <div class="form-group">
  
                <asp:Label ID="Label1"  CssClass="form-control" runat="server"  Text="Label" Width="100%"></asp:Label>
     
        </div>
            <br />
               <br />
         <div class="form-group">
                       
                    
                            <asp:TextBox runat="server" ID="UserName" TextMode="MultiLine"  CssClass="form-control" Width="100%" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="UserName"
                                CssClass="text-danger" ErrorMessage="The response field is required." Width="100%" />
       
         </div>
            <br />
             <div class="form-group">
                        <div class="col-md-offset-2 col-md-10">
                            <asp:Button runat="server" Text="Submit" CssClass="btn btn-default" OnClick="Unnamed2_Click" />
                        </div>
                    </div>


    </div>
</div>
</asp:Content>

